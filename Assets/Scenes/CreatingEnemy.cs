using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingEnemy : MonoBehaviour
{
    [SerializeField] private GameObject newEnemy;
    private GameObject enmy;
    void Start()
    {
        
    }
    public static int num_of_enemy = 0;
    void Update()
    {

        if (enmy == null || num_of_enemy < 6)
        {
            enmy = Instantiate(newEnemy) as GameObject;
            int a = Random.Range(0, 6);
            if (a == 1)
                enmy.transform.position = new Vector3(-40f, 2f, -40f);
            else if (a == 2)
                enmy.transform.position = new Vector3(40f, 2f, -40f);
            else if (a == 3)
                enmy.transform.position = new Vector3(-40f, 2f, 40f);
            else if (a == 4)
                enmy.transform.position = new Vector3(40f, 2f, 40f);
            else if (a == 5)
                enmy.transform.position = new Vector3(0, 2f, -30f);
            else
                enmy.transform.position = new Vector3(0, 2f, 30f);
            //enmy.transform.position = new Vector3(-0.5f, 0.5f, -2f);
            enmy.transform.Rotate(0, (float)(Random.Range(0, 360)), 0);
            num_of_enemy++;
        }
    }
}
