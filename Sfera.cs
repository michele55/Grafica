using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sfera : MonoBehaviour
{
    public Rigidbody Sphere;



    void Start(){
        Sphere=GetComponent<Rigidbody>();
    }
   private void Update()
{
    int speed = 10;
    int jumpForce = 100;
    if (Sphere.transform.position.y<0){
        Debug.Log("OKKKK");
    }
    if(Input.GetKey(KeyCode.LeftArrow))
    {
        Sphere.AddForce(Vector3.left * speed, ForceMode.Force);
    }
     if(Input.GetKey(KeyCode.UpArrow))
    {
        Sphere.AddForce(Vector3.forward * speed, ForceMode.Force);
    }
    if(Input.GetKey(KeyCode.RightArrow))
    {
        Sphere.AddForce(Vector3.right * speed, ForceMode.Force);
    }
    if(Input.GetKeyDown(KeyCode.Space))
    {
        Sphere.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
}
