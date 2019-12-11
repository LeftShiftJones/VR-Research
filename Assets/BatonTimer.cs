using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatonTimer : MonoBehaviour
{
    List<string> times;
    float start_time;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject foo in GameObject.FindGameObjectsWithTag("MazeCube")) {
            foo.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
        }
        start_time = 0;
        times = new List<string>();
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.name == "TimerCube1") {
            foreach(GameObject foo in GameObject.FindGameObjectsWithTag("MazeCube")) {
                foo.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
            }
        }

        if(col.gameObject.name == "TimerCube2" && start_time > 0) { // impossible for users to start at 0
            times.Add($"{Time.time} - {start_time} = {Time.time - start_time}");
            start_time = 0;
        }
        
        if(col.gameObject.name.Contains("MazeCube") && start_time > 0) {
            times.Add($"{Time.time} - {start_time} = {Time.time - start_time} x");
            start_time = 0;
            foreach(GameObject foo in GameObject.FindGameObjectsWithTag("MazeCube")) {
                foo.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
        }
    }

    void OnCollisionExit(Collision col) {
        if(col.gameObject.name == "TimerCube1") {
            start_time = Time.time;
        }
    }

    void OnApplicationQuit() 
	{
		 System.IO.File.WriteAllLines($@"C:\Users\vr\Desktop\PlayTests\{System.DateTime.Now.ToString("MMddyyyy hhmmss tt")} - MazeTimes.txt", times);
	}

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.B)) {
            gameObject.transform.position = new Vector3(-3.732f, 1.01f, 0.867f);
        }
    }
}
