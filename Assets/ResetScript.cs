using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{

    void OnCollideEnter(Collision col) {
        if(col.gameObject.name == "ButtonBack") {
            Debug.Log("HIT HIM");
        }

    }
}
