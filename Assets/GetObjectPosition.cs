using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObjectPosition : MonoBehaviour
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
		string str = $"{Time.time} {gameObject.transform.position.x} {gameObject.transform.position.y} {gameObject.transform.position.z} {gameObject.transform.rotation.eulerAngles.x} {gameObject.transform.rotation.eulerAngles.y} {gameObject.transform.rotation.eulerAngles.z}";
		positions.Add(str);
    }

	void OnApplicationQuit() 
	{
        string filepath = $@"C:\Users\vr\Desktop\PlayTests\{System.DateTime.Now.ToString("MMddyyyy hhmmss tt")} - {gameObject.name}Position.txt";
		System.IO.File.WriteAllLines(@filepath, positions);
	}
}
