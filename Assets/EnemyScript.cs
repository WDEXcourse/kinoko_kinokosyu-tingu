using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    public GameObject EnemyArrow;
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
        GameObject EnemyArrows = Instantiate(EnemyArrow,this.transform.position,this.transform.rotation) as GameObject;
        EnemyArrows.transform.position = this.transform.position + new Vector3(0,3,0);
        force = this.gameObject.transform.forward * ArrowSpeed;
        EnemyArrows.GetComponent<Rigidbody>().AddForce(force);
        Destroy(EnemyArrows.gameObject, 4);
        
    }
}
