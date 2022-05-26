using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookVector : MonoBehaviour
{
    [SerializeField]
    private Transform lookPointTf;
    [SerializeField]
    private Transform lookTargetTf;
    [SerializeField][Range(0f, 1f)]
    private float strictness = 1f;


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Vector2 lookPointPos = lookPointTf.position;
        Vector2 PlayerPos = transform.position;
        Vector2 LookTargetPos = lookTargetTf.position;

        Vector2 lookVector = lookPointPos - PlayerPos;
        float lookVectorMagnitude = Mathf.Sqrt(lookVector.x * lookVector.x + lookVector.y * lookVector.y);
        Vector2 lookVectorNormalized = lookVector / lookVectorMagnitude;

        Vector2 lookTargetVector = LookTargetPos - PlayerPos;
        float lookTargetVectorMagnitude = Mathf.Sqrt(lookTargetVector.x * lookTargetVector.x + lookTargetVector.y * lookTargetVector.y);
        Vector2 lookTargetVectorNormalized = lookTargetVector / lookTargetVectorMagnitude;

        float dot = lookVectorNormalized.x * lookTargetVectorNormalized.x + lookVectorNormalized.y * lookTargetVectorNormalized.y;

        
        if(dot >= strictness)
        {
            Gizmos.color = Color.green;
        }

        Gizmos.DrawRay(PlayerPos, lookVector);
    }
}
