using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrizzlynHitBox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //if Hawkson collides with Grizzlyn
        if(col.gameObject.name == "Grizzlyn_PrefabP1") 
        {
            //-10 to Grizzlyn health bar
            HealthBarP1.health -= 10f;

            //message to detect collision
            UnityEngine.Debug.Log("-10 to Grizzlyn");
        }
        if(col.gameObject.name == "Grizzlyn_PrefabP2")
        {
            //-10 to Grizzlyn health bar
            HealthBarP2.health -= 10f;

            //message to detect collision
            UnityEngine.Debug.Log("-10 to Grizzlyn");
        }
    }
}
