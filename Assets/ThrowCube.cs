using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ThrowCube : MonoBehaviour
{

	List<string> positions;
    // Start is called before the first frame update
    void Start()
    {
        positions = new List<string>();
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
            positions.Add("-----");
        } else  {
            double x = gameObject.transform.position.x;
            double y = gameObject.transform.position.y;
            double z = gameObject.transform.position.z;
            double dist = 0.0;
            if(gameObject.name.Contains("Red")) {
                dist = Math.Sqrt(Math.Pow((3.5 - x), 2) + Math.Pow(y, 2) + Math.Pow((-3.5 - z), 2));
            } else {
                dist = Math.Sqrt(Math.Pow((3.5 - x), 2) + Math.Pow(y, 2) + Math.Pow((0 - z), 2));
            }
            string str = $"{Time.time} {x} {y} {z} {dist}";
            positions.Add(str);
        }
    }

	void OnApplicationQuit() 
	{
        string filepath = $@"C:\Users\vr\Desktop\PlayTests\{System.DateTime.Now.ToString("MMddyyyy hhmmss tt")} - {gameObject.name}.txt";
		System.IO.File.WriteAllLines(@filepath, positions);
	}
}
