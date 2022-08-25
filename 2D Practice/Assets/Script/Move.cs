using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 Dir = Vector3.right * h + Vector3.up * v;

        transform.position += Dir * 5.0f * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ㅎㅇ");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ㅂㅇ");

    }
}
