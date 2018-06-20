using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimScript : MonoBehaviour {

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float forward = Input.GetAxis("Vertical") * 3.55f;
        float right = Input.GetAxis("Horizontal") * 2.86f;

        if (forward != 0 ||right != 0){
            animator.SetBool("isMoving", true);
            animator.SetFloat("Forward", forward);
            animator.SetFloat("Right", right);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        
        
	}
}
