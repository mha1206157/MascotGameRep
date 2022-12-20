using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrizzlynPlayerController : MonoBehaviour
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
<<<<<<< HEAD
<<<<<<< HEAD
        //Allows character to move left and right
=======
>>>>>>> parent of a7e65e0 (Revert "Imported Assets")
=======
>>>>>>> parent of 1373ec5 (Merge branch 'Martin')
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + dirX, transform.position.y);

<<<<<<< HEAD
<<<<<<< HEAD
        //Animation rules

        //If character is moving and punch is not active, walk anim starts
=======
>>>>>>> parent of a7e65e0 (Revert "Imported Assets")
=======
>>>>>>> parent of 1373ec5 (Merge branch 'Martin')
        if (dirX != 0 && !anim.GetCurrentAnimatorStateInfo(0).IsName("Punch"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
<<<<<<< HEAD
<<<<<<< HEAD

        //If button is pressed and punch is not active, punch anim starts
        if (Input.GetButtonDown("Fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("Punch"))
        {
            anim.SetBool("isWalking", true);
=======
        if (Input.GetButtonDown("Fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("Punch"))
        {
            anim.SetBool("isWalking", false);
>>>>>>> parent of a7e65e0 (Revert "Imported Assets")
=======
        if (Input.GetButtonDown("Fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("Punch"))
        {
            anim.SetBool("isWalking", false);
>>>>>>> parent of 1373ec5 (Merge branch 'Martin')
            anim.SetTrigger("Punch");
        }
    }
}
