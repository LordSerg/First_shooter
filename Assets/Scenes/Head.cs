using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float sens = -5f;
    float delt = 0f;
    // Update is called once per frame
    void Update()
    {
        delt+= Input.GetAxis("Mouse Y")*sens;
        delt = Mathf.Clamp(delt, -45f, 45f);
        float rotationY = transform.localEulerAngles.y;
        transform.localEulerAngles = new Vector3(delt,rotationY,0);
    }
}
