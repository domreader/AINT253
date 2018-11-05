using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {

    Animator anim;

    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.E)) anim.SetTrigger("DoorOpen");

        if (Input.GetKeyDown(KeyCode.R)) anim.SetTrigger("DoorClosed");
        
    }
}
