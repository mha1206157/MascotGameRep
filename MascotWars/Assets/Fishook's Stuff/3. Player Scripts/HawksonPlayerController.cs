using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HawksonPlayerController : MonoBehaviour
{
    //movement variables
    private Rigidbody2D rb;
    float dirX, moveSpeed;
    Animator anim;

    //HealthBar script
    public HealthBarP1 healthScript;

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
        if (name == "Hawkson_PrefabP1" && Input.anyKey)
        {
            //walking forwards
            if (Input.GetKey(KeyCode.D))
            {

                dirX = moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //walking backwards
            if (Input.GetKey(KeyCode.A))
            {

                dirX = - moveSpeed;
                anim.SetBool("isWalking", true);
            }
          
            //Punch
            if (Input.GetKeyDown(KeyCode.Space))
            {

                anim.SetTrigger("Punch");
            }
        }
        else if (name == "Hawkson_PrefabP1" && !Input.anyKey)
        {
            dirX = 0f;
            anim.SetBool("isWalking", false);
        }
        //once health depletes
        if (HealthBarP1.health <= 0f)
        {
            UnityEngine.Debug.Log("Hawkson is KOd");
        }
       
        ///////////////////////////////////////////////////////////////////////////////////////////////

        //If Hawkson is player 2
        if (name == "Hawkson_PrefabP2" && Input.anyKey)
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

                dirX = -moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //Punch
            if (Input.GetKeyDown(KeyCode.T))
            {

                anim.SetTrigger("Punch");
            }

        }
        else if (name == "Hawkson_PrefabP2" && !Input.anyKey)
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
