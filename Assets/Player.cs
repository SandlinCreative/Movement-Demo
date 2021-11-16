using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed = 10;
    void Start()
    {
        //transform.position = new Vector3(0,10,0);
    }
    // Update is called once per frame
    void Update()
    {
        //float h = UnityEngine.Input.GetAxis("Horizontal");
        Vector3 input = new Vector3(UnityEngine.Input.GetAxis("Horizontal"), 0, UnityEngine.Input.GetAxis("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.position += moveAmount;
    }
}
