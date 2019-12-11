using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactWithBaton : MonoBehaviour
{
    void Start() {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
    }
    // void OnCollisionEnter(Collision col) {
    //     if(col.gameObject.name == "Baton") {
    //         gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    //     }
    // }
    // void OnCollisionExit(Collision col) {
    //     if(col.gameObject.name == "Baton") {
    //         gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
    //     }
    // }
}
