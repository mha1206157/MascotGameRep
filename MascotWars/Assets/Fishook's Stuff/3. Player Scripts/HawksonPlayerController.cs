using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawksonPlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    float dirX, moveSpeed;

    Animator anim;

    // Initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //If Hawkson is player 1
        if (name == "Hawkson_Prefab" && Input.anyKey)
        {
            //walking forwards
            if (Input.GetKey(KeyCode.L))
            {

                dirX = moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //walking backwards
            if (Input.GetKey(KeyCode.J))
            {

                dirX = - moveSpeed;
                anim.SetBool("isWalking", true);
            }
          
            //Punch
            if (Input.GetKeyDown(KeyCode.T))
            {

                anim.SetTrigger("Punch");
            }

        }
        else if (name == "Hawkson_Prefab" && !Input.anyKey)
        {
            dirX = 0f;
            anim.SetBool("isWalking", false);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
