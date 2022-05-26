using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookVector : MonoBehaviour
{
    [SerializeField]
    private Transform lookTargetTf;
    [SerializeField][Range(0f, 1f)]
    private float strictness = 1f;

    private Vector2 lookDirection = Vector2.zero;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Vector2 PlayerPos = transform.position;
        Vector2 LookTargetPos = lookTargetTf.position;

        Vector2 lookTargetVector = LookTargetPos - PlayerPos;
        float lookTargetVectorMagnitude = Mathf.Sqrt(lookTargetVector.x * lookTargetVector.x + lookTargetVector.y * lookTargetVector.y);
        Vector2 lookTargetVectorNormalized = lookTargetVector / lookTargetVectorMagnitude;

        lookDirection = transform.right;

        float dot = lookDirection.x * lookTargetVectorNormalized.x + lookDirection.y * lookTargetVectorNormalized.y;

        
        if(dot >= strictness)
        {
            Gizmos.color = Color.green;
        }

        Gizmos.DrawRay(PlayerPos, lookDirection);
    }
}
