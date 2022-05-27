using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceConverter : MonoBehaviour
{
    [SerializeField]
    private Transform localSpaceTf;
    [SerializeField]
    private Transform objTf;
    [SerializeField]
    private bool displayWorldSpace = true;

    private void OnDrawGizmos()
    {
        Vector2 localOriginInWorld = localSpaceTf.position;
        Vector2 objPosition = objTf.position;

        //draw world space
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Vector2.zero, Vector2.right);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(Vector2.zero, Vector2.up);

        //draw local space
        Gizmos.color = Color.red;
        Gizmos.DrawRay(localOriginInWorld, localSpaceTf.right);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(localOriginInWorld, localSpaceTf.up);

        if (!displayWorldSpace)
        {


            Gizmos.color = Color.black;
            Gizmos.DrawLine(localOriginInWorld, objPosition);
        }
        else
        {
            Gizmos.color = Color.black;
            Gizmos.DrawLine(Vector2.zero, objPosition);
        }
    }
    private Vector2 LocalToWorld(Vector2 localOriginPointInWorld, Vector2 localPos)
    {
        return Vector2.zero;
    }

    private Vector2 WorldToLocal(Vector2 localOriginPointInWorld, Vector2 worldPos)
    {
        return Vector2.zero;
    }

}
