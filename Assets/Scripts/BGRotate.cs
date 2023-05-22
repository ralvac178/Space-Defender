using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRotate : MonoBehaviour
{
    [SerializeField] private MeshRenderer mR;
    private float speed = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        mR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mR.material.mainTextureOffset = new Vector2(1,1) * Time.time * speed;
    }
}
