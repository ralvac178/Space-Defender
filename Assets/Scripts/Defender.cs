using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    private Sounds soundManager;
    [SerializeField] private AudioClip collideMeteor;
    private Spawner spawnerScript;
    private GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        spawnerScript = GameObject.Find("Spawner").GetComponent<Spawner>();
        soundManager = GameObject.Find("SoundManager").GetComponent<Sounds>();
    }

    private void OnMouseDown()
    {
        Instantiate(explosion,transform.position,Quaternion.identity);
        soundManager.EmitSound(collideMeteor);
        gm.meteorCount++;
        ChangeTime();
        Destroy(this.gameObject);
    }

    public void ChangeTime()
    {
        if (gm.meteorCount % 10 == 0 && gm.meteorCount < 41)
        {
            spawnerScript.time -= 0.425f;
        }
    }
}
