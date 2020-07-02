using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManipulation : MonoBehaviour
{
    private CharacterController cc;
    public float speed = 0.2f;
    public float gravity = -10.0f;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    public float deltX, deltZ;
    void Update()
    {
        deltX = Input.GetAxis("Horizontal") * speed;
        deltZ = Input.GetAxis("Vertical") * speed;
        Vector3 movment = new Vector3(deltX, 0, deltZ);
        //movment = Vector3.ClampMagnitude(movment, speed);
        movment.y = gravity;
        movment *= Time.deltaTime;
        movment = transform.TransformDirection(movment);
        cc.Move(movment);
    }
}
