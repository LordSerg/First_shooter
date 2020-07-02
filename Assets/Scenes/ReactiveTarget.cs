using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    private CharacterController bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,Input.GetAxis("Mouse X")*5,0);
        
        Vector3 v = new Vector3(0,-2f,0.1f);
        v = transform.TransformDirection(v);

        //transform.Translate(v.x, v.y, v.z);
        bc.Move(v);
    }
}
