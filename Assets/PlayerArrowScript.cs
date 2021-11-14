using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArrowScript : MonoBehaviour
{
    public static int arrow;
    void Start()
    {
        arrow = 1;
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "field")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "tekinoarrow")
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "tekinoarrow")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "field")
        {
            Destroy(this.gameObject);
        }
    }
}
