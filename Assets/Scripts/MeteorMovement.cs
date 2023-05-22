using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] private float speedMin, speedMax, speed;
    // Start is called before the first frame update
    void Start()
    {
        float xDir = Random.Range(-0.5f,0.5f);
        float yDir = Random.Range(-0.5f, -1.0f);

        direction = new Vector3(xDir, yDir, 0);
        speed = Random.Range(speedMin, speedMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
