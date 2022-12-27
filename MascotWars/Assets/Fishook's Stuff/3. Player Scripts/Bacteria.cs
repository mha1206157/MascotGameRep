using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D col)
    {
        //if something touches bacteria, then it takes 10 from health bar
        HealthBar.health -= 10f;

        //message to detect collision
        UnityEngine.Debug.Log("-10");
    }
}
