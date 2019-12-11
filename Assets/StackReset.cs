using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackReset : MonoBehaviour
{

    public GameObject stackBlock;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 3; i++) {
            for(int j = 0; j < 4; j++) {
                Instantiate(stackBlock, new Vector3(-1.05f + (0.2f * j), 0.8f, 4.2f - (0.3f * i)), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) {
            foreach(GameObject foo in GameObject.FindGameObjectsWithTag("StackCube")) {
                if(foo.gameObject.name != "TransferCube") Destroy(foo);
            }

            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 4; j++) {
                Instantiate(stackBlock, new Vector3(-1.05f + (0.2f * j), 0.8f, 4.2f - (0.3f * i)), Quaternion.identity);
                }
            }
        }
    }
}
