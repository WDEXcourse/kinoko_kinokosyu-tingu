using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossArrowScript : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    float Speed = 1250;
    AudioSource DIY;
    Vector3 force;
    Rigidbody Rigit;
    public GameObject Boss;



    void Start()
    {
        Boss = GameObject.Find("kinositaboss(Clone)");
        audioSource = GetComponent<AudioSource>();
        transform.Rotate(Boss.transform.forward);
        Rigit = GetComponent<Rigidbody>();
        force = transform.forward * Speed;
        Rigit.AddForce(force);
        Destroy(this.gameObject, 4);
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