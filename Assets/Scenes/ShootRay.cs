using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRay : MonoBehaviour
{
    private Camera c;
    void Start()
    {
        c = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //int size = 12;
        //float x = c.pixelWidth / 2 - size / 4;
        //float y = c.pixelHeight / 2 - size / 4;
        //GUI.Label(new Rect(x, y, size, size), "+");
    }

    void OnGUI()
    {
        int size = 12;
        float x = c.pixelWidth / 2 - size / 4;
        float y = c.pixelHeight / 2 - size / 4;
        GUI.Label(new Rect(x, y, size, size), "!");
        GUI.Label(new Rect(10, 10, 100, 20), "Score = "+score.ToString());
    }
    int score = 0;
    private IEnumerator SphereIndicator(Vector3 position,GameObject ololo)
    {
        //GameObject sphere = GameObject.
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Cube);//GameObject.Cube;
        sphere.transform.position = position;

        yield return new WaitForSeconds(5);
        Destroy(sphere);
    }
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 p = new Vector3(c.pixelWidth / 2, c.pixelHeight / 2, 0);
            Ray r = c.ScreenPointToRay(p);
            RaycastHit hit;
            
            if(Physics.Raycast(r,out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                KillShoot deth = hitObject.GetComponent<KillShoot>();
                KillDeth f = hitObject.GetComponent<KillDeth>();
                if (deth != null)
                {//попадание в часть тела
                    //Debug.Log("i`m working!!!!!!!!!!!!!");
                    //CreatingEnemy.num_of_enemy--;
                    score++;
                    deth.DiePls();
                }
                else if (f != null)
                {//поражение противника
                    CreatingEnemy.num_of_enemy--;
                    score +=10;
                    f.DiePls();
                }
                else
                {
                    StartCoroutine(SphereIndicator(hit.point, hit.transform.gameObject));
                }
            }
        }
    }
}
