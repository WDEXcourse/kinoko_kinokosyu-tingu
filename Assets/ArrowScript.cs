using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    
    void Start()
    {
      
    }

    void Update()
    {
        //if (PlayerArrowScript.arrow == 0)
        //{
        //    Destroy(this.gameObject);
        //}
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