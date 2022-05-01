using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StrongEnemyScript : MonoBehaviour
{
    //public float kakudo1;
    //public float kakudo2;
    //public float kakudo3;
    public GameObject target;
    NavMeshAgent agent;
    public GameObject EnemyArrowa;
    public GameObject EnemyArrowb;
    public GameObject EnemyArrowc;
    public float Degree, diffusion_angle;
    float _theta;
    float PI = Mathf.PI;
     //public GameObject EnemyArrow2;
     //public GameObject EnemyArrow3;
     [SerializeField]
    private float ArrowSpeed = 1250;
    Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("kinositakariudo");
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("ArrowAttack", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kariudonoya")
        {
            CreateEnemyScript.numberofenemy--;
            CountEnemyScript.CountEnemy++;
            Destroy(this.gameObject);
        }
    }
    void ArrowAttack()
    {
        GameObject EnemyArrow1 = Instantiate(EnemyArrowa);
        GameObject EnemyArrow2 = Instantiate(EnemyArrowb);
        GameObject EnemyArrow3 = Instantiate(EnemyArrowc);
        Debug.Log(501);

        //EnemyArrows2.transform.rotation = Quaternion.Euler(0, 20, 0);
        //EnemyArrows2.transform.position = this.transform.position + new Vector3(5, 3, 0);
        //force = this.gameObject.transform.forward * ArrowSpeed;
        //EnemyArrows2.GetComponent<Rigidbody>().AddForce(force);
        //Destroy(EnemyArrows2.gameObject, 4);
        Arrow(EnemyArrow1, ArrowSpeed, new Vector3(0, 3, 4),0);
        Arrow(EnemyArrow2, ArrowSpeed, new Vector3(2, 3, 2),20);
        Arrow(EnemyArrow3, ArrowSpeed, new Vector3(-2, 3, 2),-20);
    }
    void Arrow(GameObject DIY, float Speed, Vector3 Position, float Rotate)
    {
        DIY.transform.position = this.transform.position + Position;
        DIY.transform.rotation = Quaternion.Euler(0, Rotate, 0);
        force = DIY.gameObject.transform.forward * Speed;
        DIY.GetComponent<Rigidbody>().AddForce(force);
        Destroy(DIY.gameObject, 4);
        //GameObject EnemyArrows = Instantiate(EnemyArrow, this.transform.position, this.transform.rotation) as GameObject;
        //EnemyArrows.transform.position = this.transform.position + new Vector3(0, 3, 0);
        //force = this.gameObject.transform.forward * ArrowSpeed;
        //EnemyArrows.GetComponent<Rigidbody>().AddForce(force);
        //Destroy(EnemyArrows.gameObject, 4);
    }
}