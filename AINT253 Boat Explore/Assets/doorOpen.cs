using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {

    Animator anim;
    private float DetRange;
    private bool CloseEnough;
    private Transform PlayerLocation;
    private Transform NearObject;
    private bool enter;

    void Start()
    {

        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = false;
        }
    }
    // Update is called once per frame
    void Update() {


            
            
            if (Input.GetKeyDown(KeyCode.E) & (enter == true)) anim.SetTrigger("DoorOpen");

            if (Input.GetKeyDown(KeyCode.R) & (enter == true)) anim.SetTrigger("DoorClosed");

        }

        

    
}
