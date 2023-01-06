using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (HealthBarP1.health <= 0f)
        {
            UnityEngine.Debug.Log("Grizzlyn is KOd");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////

        //If Grizzlyn is player 2
        if (name == "Grizzlyn_PrefabP2" && Input.anyKey)
        {
            //walking 
            if (Input.GetKey(KeyCode.L))
            {

                dirX = moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //walking backwards
            if (Input.GetKey(KeyCode.L))
            {

                dirX = -moveSpeed;
                anim.SetBool("isWalking", true);
            }

            //Punch
            if (Input.GetKeyDown(KeyCode.J))
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
        if (HealthBarP1.health <= 0f)
        {
            UnityEngine.Debug.Log("Grizzlyn is KOd");
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
