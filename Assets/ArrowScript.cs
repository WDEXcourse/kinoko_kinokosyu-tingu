using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    float Speed =1250;
    AudioSource DIY;
    Vector3 force;
    Rigidbody Rigit;
    public GameObject StrongEnemy;
    


    void Start()
    {
        StrongEnemy = GameObject.Find("kinositakyouteki");
        audioSource = GetComponent<AudioSource>();
        Rigit = GetComponent<Rigidbody>();
        force = StrongEnemy.transform.forward * Speed;
        Rigit.AddForce(force);
        Destroy(gameObject, 4);
    }

    void Update()
    {
       if (Input.GetMouseButton(0))
        {
            audioSource.PlayOneShot(sound1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "field")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "kariudonoya")
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "kariudonoya")
        {
            Destroy(this.gameObject);
        }
    }
}