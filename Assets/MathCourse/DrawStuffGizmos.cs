using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawStuffGizmos : MonoBehaviour
{
    [SerializeField]
    private Transform A;
    [SerializeField]
    private Transform B;

    private void OnDrawGizmos()
    {
        Vector2 aPos = A.position;
        Vector2 bPos = B.position;

        Vector2 aTob = bPos - aPos;
        float aTobMagnitude = Mathf.Sqrt( (aTob.x * aTob.x) + (aTob.y * aTob.y) );
        Gizmos.DrawWireSphere(aPos, aTobMagnitude);
        
        //Gizmos.DrawLine(aPos, aPos + );
    }
}
