using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Straight : MonoBehaviour
{
    public float m_shotSpeed;
    public float m_shotTimer;
    public float m_shotInterval;
    public GameObject target;
    public GameObject MyRotato;
    public float rot;
    public float i;
    Vector3 forse;
    // Start is called before the first frame update
    void Start()
    {
        i = 1;
        MyRotato = transform.root.gameObject;
        //StartCoroutine("timer");
        //target = GameObject.FindGameObjectWithTag("ya2");
    }

    // Update is called once per frame
    void Update()
    {
        //target = GameObject.FindGameObjectWithTag("ya2");
        m_shotTimer += Time.deltaTime;
        if (m_shotTimer < m_shotInterval) return;
        m_shotTimer = 0;
        StartCoroutine("timer");
        //Instantiate(target, transform.position, Quaternion.identity);
        //GameObject targets = Instantiate(target) as GameObject;
        //targets.transform.position = this.transform.position + new Vector3(0, -3, 0);
        //target.transform.localPosition = transform.position;
        //target.transform.localRotation = MyRotato.transform.rotation;
        //forse = target.transform.forward * m_shotSpeed;
        //Debug.Log(forse);
        //Debug.Log(i);
        //i++;
        //targets.GetComponent<Rigidbody>().AddForce(forse);
    }
    IEnumerator timer()
    {
        GameObject targets = Instantiate(target) as GameObject;
        //targets.transform.position = this.transform.position + new Vector3(0, -3, 0);
        target.transform.localPosition = transform.position;
        target.transform.localRotation = MyRotato.transform.rotation;
        forse = target.transform.forward * m_shotSpeed;
        //Debug.Log(forse);
        //Debug.Log(i);
        //i++;
        targets.GetComponent<Rigidbody>().AddForce(forse);
        yield return new WaitForSeconds(1);
    }
}
