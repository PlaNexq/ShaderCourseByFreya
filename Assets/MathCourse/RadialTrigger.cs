using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    [SerializeField]
    private Transform targetTf;
    [SerializeField]
    private float radius;


    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Handles.color = Color.red;
        Vector2 origin = transform.position;
        Vector2 target = targetTf.position;

        Vector2 originToTarget = target - origin;
        float originToTargetMagnitude = (originToTarget.x * originToTarget.x) + (originToTarget.y * originToTarget.y);
        if (originToTargetMagnitude <= radius * radius)
        {
            Handles.color = Color.green;
        }

        Handles.DrawWireDisc(origin, Vector3.forward, radius);
        //Gizmos.DrawLine(origin,origin + originToTarget);
    }
}
