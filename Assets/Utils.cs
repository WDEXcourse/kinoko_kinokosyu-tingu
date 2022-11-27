using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils 
{
    public static Vector3 GetDirection(float angle)
    {
        return new Vector3
            (
                Mathf.Cos(angle * Mathf.Deg2Rad),
                0,
                Mathf.Sin(angle * Mathf.Deg2Rad)
            );
    }
    public static float GetAngle(Vector3 from,Vector3 to )
    {
        var dx = to.x - from.x;
        var dz = to.z - from.z;
        var rad = Mathf.Atan2(dz, dx);
        return rad * Mathf.Rad2Deg;
    }
}
