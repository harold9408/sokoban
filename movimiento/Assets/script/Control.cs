using System.Collections;
using UnityEngine;

public class Control : MonoBehaviour {

    public Animator anim;
    public float WalkSpeed;
    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.W)){
            anim.SetBool("Walk", true);
            transform.Translate(Vector3.forward * WalkSpeed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        
    }
}
