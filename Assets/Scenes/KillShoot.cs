using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillShoot : MonoBehaviour
{//скрипт для отстреливания частей тела у врага
    
    void Start()
    {
        
    }
    public void DiePls()
    {
        StartCoroutine(Die());
    }
    float a=0, b=0, c=0;
    private IEnumerator Die() 
    {
        Vector3 v = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
        //v.y = -5;
        v = Vector3.ClampMagnitude(v, 7);
        v.y -= 0.2f;
        this.transform.TransformDirection(v);
        a = v.x;
        b = v.y;
        c = v.z;
        transform.Translate(a, b, c);
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }

    void Update()
    {
        transform.Translate(a, b, c);
    }
}
