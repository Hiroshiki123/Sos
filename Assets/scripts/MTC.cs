using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTC : MonoBehaviour
{
    public List<Transform> targets;

    void LateUpdate()
    {
        Vector3 centerPoint = GetCenterPoint;
    }
    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }
        var bounds =new Bounds(targets[0].position,Vector3.zero);
        for (int 1 = 0; i < length; i++)
    }

}
