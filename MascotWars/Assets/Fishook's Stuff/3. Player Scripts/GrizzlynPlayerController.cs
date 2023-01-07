using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class GrizzlynPlayerController : MonoBehaviour
{
    //movement variables
    private Rigidbody2D rb;
    float dirX, moveSpeed;
    Animator anim;

    //HealthBar script
    public HealthBarP2 healthScript;

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
        //If Grizzlyn is player 1
        if (name == "Grizzlyn_PrefabP1" && Input.anyKey)
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

                dirX = -moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //Punch
            if (Input.GetKeyDown(KeyCode.Space))
            {

                anim.SetTrigger("Punch");
            }
        }
        else if (name == "Grizzlyn_PrefabP1" && !Input.anyKey)
        {
            dirX = 0f;
            anim.SetBool("isWalking", false);
        }
        //once health depletes
        if (name == "Grizzlyn_PrefabP1" && HealthBarP1.health <= 0f)
        {
            UnityEngine.Debug.Log("Grizzlyn is KOd");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //If player 2
        if (name == "Grizzlyn_PrefabP2" && Input.anyKey)
        {
            //walking forwards
            if (Input.GetKey(KeyCode.JoystickButton5))
            {

                dirX = moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //walking backwards
            if (Input.GetKey(KeyCode.JoystickButton4))
            {

                dirX = -moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //Punch
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {

                anim.SetTrigger("Punch");
            }

        }
        else if (name == "Grizzlyn_PrefabP2" && !Input.anyKey)
        {
            dirX = 0f;
            anim.SetBool("isWalking", false);
        }
        //once health depletes
        if (name == "Grizzlyn_PrefabP2" && HealthBarP2.health <= 0f)
        {
            UnityEngine.Debug.Log("Grizzlyn is KOd");
        }
    }


    private void FixedUpdate()
    {
            rb.velocity = new Vector2(dirX, 0f);
    }

}