using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    [SerializeField]
    GameObject hand;
    float distance = 10.0f;

    //Vector3 Pos;
    private void Start()
    {

    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(hand.transform.position, hand.transform.right, distance );

        Debug.DrawRay(hand.transform.position,hand.transform.right * distance);
        if(hit)
        {
            Debug.Log(hit.point);



            //Pos = hit.point;
        }

        Vector3 Hand_Dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - hand.transform.position;
        float angle = Mathf.Atan2(Hand_Dir.y,Hand_Dir.x) * Mathf.Rad2Deg;
        hand.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
    }

    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(Pos, 0.5f);
    }
}
