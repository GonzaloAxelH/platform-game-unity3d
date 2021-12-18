using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int value;

    public GameObject coinEffect;
    public AudioSource music;
    public AudioClip audio;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            music.clip = audio;
            music.Play();
            Destroy(gameObject);
        }
    }
}
