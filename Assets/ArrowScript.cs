﻿using System.Collections;
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
        StrongEnemy = GameObject.Find("kinositakyouteki (Clone)");
        audioSource = GetComponent<AudioSource>();
        //transform.Rotate(StrongEnemy.transform.forward);
        //transform.localEulerAngles = StrongEnemy.transform.forward;
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
    public void Init(float angle, float speed)
    {
        //var direction = Utils.GetDirection(angle);
        var angles = transform.localEulerAngles;
        angles.x = angle - 90;
        transform.localEulerAngles = angles;
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