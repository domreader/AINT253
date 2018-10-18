using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {


        // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Animator anim = GetComponent<Animator>();
            if (null != anim)
            {
                Debug.Log("Playing anim");
                anim.Play("anim");
            }
        }
    }
}
