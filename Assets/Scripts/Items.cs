using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] GameObject itemParticles;
    private Sounds soundManager;
    [SerializeField] private AudioClip clipItem;
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
        Instantiate(itemParticles, transform.position, Quaternion.identity);
        soundManager.EmitSound(clipItem);
        if (transform.tag == "timer")
        {
            ChangeTime();           
        }else if(transform.tag == "gem")
        {
            HealthPlanet();
        }

        Destroy(this.gameObject);
    }

    public void ChangeTime()
    {
        gm.AddTime(10f);
    }

    public void HealthPlanet()
    {
        if (gm.life < 10)
        {
            gm.life++;
        }
    }
}
