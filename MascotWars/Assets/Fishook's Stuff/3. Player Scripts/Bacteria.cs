using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //if player 1
        if (name == "Hawkson_PrefabP1" || name == "Grizzlyn_PrefabP1")
        {
            //if P2 touches bacteria, then it takes 10 from health bar
            HealthBarP1.health -= 10f;

            //message to detect P2 collision
            UnityEngine.Debug.Log("-10 to P1");
        }
    
        //if player 2
        if (name == "Hawkson_PrefabP2" || name == "Grizzlyn_PrefabP2")
        {
            //if P2 touches bacteria, then it takes 10 from health bar
            HealthBarP2.health -= 10f;

            //message to detect P2 collision
            UnityEngine.Debug.Log("-10 to P2");
        }
    }
}
