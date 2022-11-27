using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strongbulletscript : MonoBehaviour
{
    private Vector3 m_velocity;
    private void Update()
    {
        transform.localPosition += m_velocity;
    }
    public void Init(float angle, float speed)
    {
        var direction = Utils.GetDirection(angle);
        m_velocity = direction * speed;
        var angles = transform.localEulerAngles;
        angles.x = angle - 90;
        transform.localEulerAngles = angles;
        Destroy(gameObject, 4);
    }
}
