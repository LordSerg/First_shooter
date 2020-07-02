using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int loc_y = 0;
    int min = -2, max = 2;
    bool b = false;
    public float delt = 0.05f;
    // Update is called once per frame
    void Update()
    {
        if (b == true)
        {
            transform.Translate(0, delt, 0);
            loc_y++;
        }
        else
        {
            transform.Translate(0, -delt, 0);
            loc_y--;
        }
        if (loc_y < min || loc_y > max)
            b = !b;
    }
}
