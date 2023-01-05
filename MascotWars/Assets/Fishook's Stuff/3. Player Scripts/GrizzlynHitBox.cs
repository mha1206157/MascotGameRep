using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrizzlynHitBox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //if player 2
        if (col.gameObject.name == "Hawkson_PrefabP2" || col.gameObject.name == "Grizzlyn_PrefabP2")
        {
            //if P2 touches bacteria, then it takes 10 from health bar
            HealthBarP2.health -= 10f;

            //message to detect P2 collision
            UnityEngine.Debug.Log("-10 to P2");
        }
    }
}
