using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTransform : MonoBehaviour
{
    public Vector2 localPoint;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.right);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.up);
        Gizmos.color = Color.blue;
        Vector2 worldPoint = LocalToWorld(localPoint);
        Gizmos.DrawSphere(worldPoint, 0.5f);
    }

    Vector2 LocalToWorld(Vector2 point)
    {
        Vector2 offset = (transform.right * point.x) + (transform.up * point.y);
        return (Vector2)transform.position + offset;
    }
}
