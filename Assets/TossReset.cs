using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int red = 0, green = 0;
            foreach(GameObject foo in GameObject.FindGameObjectsWithTag("TossCube")) {
                Vector3 p = foo.transform.position;
                p.y = 1.05f;
                if(foo.name.Contains("Red")) {
                    p.x = 4.3f + (red * 0.2f);
                    p.z = 3.2f;
                    red++;
                } else {
                    p.x = 4.3f + (green * 0.2f);
                    p.z = 2.8f;
                    green++;
                }
                foo.transform.position = p;
            }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) {
            int red = 0, green = 0;
            foreach(GameObject foo in GameObject.FindGameObjectsWithTag("TossCube")) {
                Vector3 p = foo.transform.position;
                p.y = 1.05f;
                if(foo.name.Contains("Red")) {
                    p.x = 4.3f + (red * 0.2f);
                    p.z = 3.2f;
                    red++;
                } else {
                    p.x = 4.3f + (green * 0.2f);
                    p.z = 2.8f;
                    green++;
                }
                foo.transform.position = p;
            }
        }
    }
}
