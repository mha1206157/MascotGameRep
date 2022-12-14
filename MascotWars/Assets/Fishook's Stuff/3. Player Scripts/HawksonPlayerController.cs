using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawksonPlayerController : MonoBehaviour
{
    float dirX, moveSpeed;
    Animator anim;

    // Initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //walking
        transform.position = new Vector2(transform.position.x + dirX, transform.position.y);

        if (Input.GetKey(KeyCode.J))
        {
            
            transform.Translate(Vector3.left);
            anim.SetBool("isWalking", true);
        }
        else
        {
            transform.Translate(Vector3.zero);
            anim.SetBool("isWalking", false);
        }

        //Punch
        if(Input.GetKeyDown(KeyCode.T))
        {
            
            anim.SetTrigger("Punch");
        }
    }
}
