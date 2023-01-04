using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawksonHitBox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //if player 1 
        if (name == "Hawkson_PrefabP1" || name == "Grizzlyn_PrefabP1")
        {
            //if P1 touches bacteria, then it takes 10 from health bar
            HealthBarP2.health -= 10f;

            //message to detect P1 collision
            UnityEngine.Debug.Log("-10 to P1");
        }
    }
}
