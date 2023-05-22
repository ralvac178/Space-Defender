using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float minSpawnerPos = -5.5f;
    private float maxSpawnerPos = 5.5f;
    [SerializeField] private float spawnerPos;
    [SerializeField] private GameObject meteor;
    [SerializeField] public float time = 2;

    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(MeteorSpawner());
    }

    IEnumerator MeteorSpawner()
    {
        while (!gm.gameOver)
        {
            spawnerPos = Random.Range(minSpawnerPos, maxSpawnerPos);
            Instantiate(meteor, new Vector3(spawnerPos, 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
