using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StrongKyoutekiScript : MonoBehaviour
{
    public Shot m_shotPrefab;
    public float m_shotSpeed;
    public float m_shotAngleRange;
    public float angle;
    public float m_shotTimer;
    public int m_shotCount;
    public float m_shotInterval;
    public Vector3 arrowhight;
    public GameObject target;
    // Start is called before the first frame update
    NavMeshAgent agent;
    void Start()
    {
        target = GameObject.Find("kinositakariudo");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        angle = transform.localEulerAngles.y;
        //transform.Rotate(0f, -1f, 0f);
        m_shotTimer += Time.deltaTime;
        if (m_shotTimer < m_shotInterval) return;
        m_shotTimer = 0;
        ShootNWay(angle, m_shotAngleRange, m_shotSpeed, m_shotCount);
        //Debug.Log(this.transform.localEulerAngles);
    }
    private void ShootNWay(float angleBase,float angleRange,float speed,int count)
    {
        var pos = transform.position; //+ arrowhight;
        var rot = this.transform.localEulerAngles;
        if (1<count)
        {
            for(int i = 0; i < count; ++i)
            {
                var angle = angleBase + angleRange * ((float)i / (count - 1) - 0.5f);
                var shot = Instantiate(m_shotPrefab, pos,Quaternion.Euler(-rot));
                //shot.Init( angle, speed);rot.y +
                //Debug.Log(i + "angle" + angle);
                //Debug.Log(i +  "rot" + rot.y);
                Debug.Log("angleBase" + angleBase + " angleRange" + angleRange + " i" + i);
            }
        }
        else if (count == 1)
        {
            //var shot = Instantiate(m_shotPrefab, pos, rot);
            //shot.Init(angleBase, speed);
        }
    }
}
