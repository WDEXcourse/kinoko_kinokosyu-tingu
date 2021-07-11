using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPbarControalScript : MonoBehaviour
{
    public int HP = 10;
    private Slider _slider;
    public GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        _slider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            SceneManager.LoadScene("kinositashu-ting2");
        }
        _slider.value = HP;
        Debug.Log(HP);
    }
    //void OnTregerEnter(Collider collision)
    //{
    //    if (collision.gameObject.tag == "tekinoarrow")
    //  {
    //        HP -- ;
    //        Debug.Log(HP);
    //    }
    //    if (HP <= 0)
    //    {
    //        print("GameOver");
    //    }
    //}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="tekinoarrow")
        {
            HP -- ;
            Debug.Log(HP);
        }
        if (HP <= 0)
        {
            print("GameOver");
        }
    }
}
