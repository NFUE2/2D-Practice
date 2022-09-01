using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    float distance = 10.0f;

    Vector3 Pos;
    Vector3 cursor;
    private void Start()
    {

    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, distance );

        if(hit)
            Pos = hit.point;

        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 Hand_Dir = cursor - transform.position;

        float angle = Mathf.Atan2(Hand_Dir.x,Hand_Dir.y) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, -angle);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(Pos, 0.2f);

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(cursor, 0.2f);
    }
}
