using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCube : MonoBehaviour
{
    int num_times_entered;
    float start_time;
    // Start is called before the first frame update
    void Start()
    {
        num_times_entered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if(gameObject.name == "TimerCube2") {
            if(col.gameObject.name == "Baton") {
                float now = Time.time;
                // float elapsed = now - col.GetComponent(FloatCarrier).val;
                Debug.Log($"Time: {now}");
                // Debug.Log($"{Time.time} == {gameObject.name}: {col.gameObject.name}");
            }
        }
    }

    void OnCollisionExit(Collision col) {
        if(gameObject.name == "TimerCube1") {
            Debug.Log(col);
            num_times_entered++;
            // col.GetComponent(FloatCarrier).val = Time.time;
        }
    }
}
