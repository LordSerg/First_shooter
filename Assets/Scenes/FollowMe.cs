using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour
{
    public enum RotAxes
    {
        MouseXandY=0,
        MouseX=1,
        MouseY=2
    }
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;
    }
    public RotAxes axes = RotAxes.MouseXandY;
    public float sensHorizon = 9.0f;
    public float sensVertical = 9.0f;
    public float minAngle = -89.0f;
    public float maxAngle = 89.0f;
    private float vertAngle=0.0f;
    // Update is called once per frame
    void Update()
    {
        if(axes==RotAxes.MouseX)//по горизонтали
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizon, 0);
        }
        else if(axes==RotAxes.MouseY)//по вертикали
        {
            vertAngle += Input.GetAxis("Mouse Y") * sensVertical;
            vertAngle = Mathf.Clamp(vertAngle, minAngle, maxAngle);
            float rotationY =transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(vertAngle, rotationY, 0);
        }
        else
        {
            vertAngle += Input.GetAxis("Mouse Y") * sensVertical;
            vertAngle = Mathf.Clamp(vertAngle, minAngle, maxAngle);
            float delta = Input.GetAxis("Mouse X")*sensHorizon;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(vertAngle, rotationY, 0);
        }
    }
}
