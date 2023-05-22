using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimerItems : MonoBehaviour
{
    private float minSpawnerPos = -5.5f;
    private float maxSpawnerPos = 5.5f;
    [SerializeField] private float spawnerPos;
    [SerializeField] private GameObject[] timerItem;
    [SerializeField] public float time = 20;

    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(TimerItemSpawner());
    }

    IEnumerator TimerItemSpawner()
    {
        yield return new WaitForSeconds(4f);
        while (!gm.gameOver)
        {
            spawnerPos = Random.Range(minSpawnerPos, maxSpawnerPos);
            int item = Random.Range(0, timerItem.Length);
            Instantiate(timerItem[item], new Vector3(spawnerPos, 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
            time -= 0.0001f;
        }
    }
}
