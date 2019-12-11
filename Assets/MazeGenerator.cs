using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public GameObject block;

    List<GameObject> cubes;
    List<Vector3> positions = new List<Vector3> {
        //top row
         new Vector3(-4.5f, 0, 0.0f)
        ,new Vector3(-4.5f, 0, 0.1f)
        ,new Vector3(-4.5f, 0, 0.2f)
        ,new Vector3(-4.5f, 0, 0.3f)
        ,new Vector3(-4.5f, 0, 0.4f)
        ,new Vector3(-4.5f, 0, 0.5f)
        ,new Vector3(-4.5f, 0, 0.6f)
        ,new Vector3(-4.5f, 0, 0.7f)
        ,new Vector3(-4.5f, 0, 0.8f)
        ,new Vector3(-4.5f, 0, 0.9f)
        ,new Vector3(-4.5f, 0, 1.0f)
        //2nd row
        ,new Vector3(-4.5f, -0.1f, 0.6f)
        ,new Vector3(-4.5f, -0.1f, 1)
        //3rd row
        ,new Vector3(-4.5f, -0.2f, 0.0f)
        ,new Vector3(-4.5f, -0.2f, 0.1f)
        ,new Vector3(-4.5f, -0.2f, 0.2f)
        ,new Vector3(-4.5f, -0.2f, 0.4f)
        ,new Vector3(-4.5f, -0.2f, 0.6f)
        ,new Vector3(-4.5f, -0.2f, 0.8f)
        ,new Vector3(-4.5f, -0.2f, 0.9f)
        ,new Vector3(-4.5f, -0.2f, 1.0f)
        //4th row
        ,new Vector3(-4.5f, -0.3f, 0.0f)
        ,new Vector3(-4.5f, -0.3f, 0.4f)
        ,new Vector3(-4.5f, -0.3f, 0.6f)
        ,new Vector3(-4.5f, -0.3f, 0.8f)
        ,new Vector3(-4.5f, -0.3f, 1.0f)
        //5th row
        ,new Vector3(-4.5f, -0.4f, 0.0f)
        ,new Vector3(-4.5f, -0.4f, 0.2f)
        ,new Vector3(-4.5f, -0.4f, 0.3f)
        ,new Vector3(-4.5f, -0.4f, 0.4f)
        ,new Vector3(-4.5f, -0.4f, 0.5f)
        ,new Vector3(-4.5f, -0.4f, 0.6f)
        ,new Vector3(-4.5f, -0.4f, 0.8f)
        ,new Vector3(-4.5f, -0.4f, 1.0f)
        //6th row
        ,new Vector3(-4.5f, -0.5f, 0.0f)
        ,new Vector3(-4.5f, -0.5f, 0.2f)
        ,new Vector3(-4.5f, -0.5f, 0.6f)
        ,new Vector3(-4.5f, -0.5f, 1.0f)
        //7th row
        ,new Vector3(-4.5f, -0.6f, 0.0f)
        ,new Vector3(-4.5f, -0.6f, 0.2f)
        ,new Vector3(-4.5f, -0.6f, 0.4f)
        ,new Vector3(-4.5f, -0.6f, 0.5f)
        ,new Vector3(-4.5f, -0.6f, 0.6f)
        ,new Vector3(-4.5f, -0.6f, 0.7f)
        ,new Vector3(-4.5f, -0.6f, 0.8f)
        ,new Vector3(-4.5f, -0.6f, 1.0f)
        //8th row
        ,new Vector3(-4.5f, -0.7f, 0.0f)
        ,new Vector3(-4.5f, -0.7f, 0.4f)
        ,new Vector3(-4.5f, -0.7f, 1.0f)
        //9th row
        ,new Vector3(-4.5f, -0.8f, 0.0f)
        ,new Vector3(-4.5f, -0.8f, 0.2f)
        ,new Vector3(-4.5f, -0.8f, 0.4f)
        ,new Vector3(-4.5f, -0.8f, 0.6f)
        ,new Vector3(-4.5f, -0.8f, 0.7f)
        ,new Vector3(-4.5f, -0.8f, 0.8f)
        ,new Vector3(-4.5f, -0.8f, 1.0f)
        //10th row
        ,new Vector3(-4.5f, -0.9f, 0.0f)
        ,new Vector3(-4.5f, -0.9f, 0.2f)
        ,new Vector3(-4.5f, -0.9f, 0.6f)
        //11th row
        ,new Vector3(-4.5f, -1.0f, 0.0f)
        ,new Vector3(-4.5f, -1.0f, 0.1f)
        ,new Vector3(-4.5f, -1.0f, 0.2f)
        ,new Vector3(-4.5f, -1.0f, 0.3f)
        ,new Vector3(-4.5f, -1.0f, 0.4f)
        ,new Vector3(-4.5f, -1.0f, 0.5f)
        ,new Vector3(-4.5f, -1.0f, 0.6f)
        ,new Vector3(-4.5f, -1.0f, 0.7f)
        ,new Vector3(-4.5f, -1.0f, 0.8f)
        ,new Vector3(-4.5f, -1.0f, 0.9f)
        ,new Vector3(-4.5f, -1.0f, 1.0f)
    };
    // Start is called before the first frame update
    void Start()
    {
        for (int y=0; y < positions.Count; ++y){
            Instantiate(block, positions[y] + new Vector3(0, 1.85f, -0.5f), Quaternion.identity);
        }
    }
}
