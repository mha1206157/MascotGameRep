using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawksonHitBox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //if Grizzlyn collides with Hawkson
        if (col.gameObject.name == "Hawkson_PrefabP1")
        { 
            //-10 to Hawkson health bar
            HealthBarP1.health -= 10f;

            //message to detect collision
            UnityEngine.Debug.Log("-10 to Hawkson");
        }
        if(col.gameObject.name == "Hawkson_PrefabP2")
        {
            //-10 to Hawkson health bar
            HealthBarP2.health -= 10f;

            //message to detect collision
            UnityEngine.Debug.Log("-10 to Hawkson");
        }
    }
}
