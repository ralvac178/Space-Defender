using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetColission : MonoBehaviour
{
    [SerializeField] private AudioClip impact;
    [SerializeField] private GameObject impactObject;
    private GameManager gm;
    private Sounds soundManager;
    // Start is called before the first frame update

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<Sounds>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Planet")
        {
            Instantiate(impactObject, transform.position, Quaternion.identity);
            AddDamage();
            soundManager.EmitSound(impact);
            Destroy(gameObject);
        }
    }

    private void AddDamage()
    {
        if(gm.life > 0)
        {
            gm.life--;
        }
        else
        {
            gm.gameOver = true;
        }
    }
}
