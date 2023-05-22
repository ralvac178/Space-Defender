using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update

    private void Start()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }
    public void EmitSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
