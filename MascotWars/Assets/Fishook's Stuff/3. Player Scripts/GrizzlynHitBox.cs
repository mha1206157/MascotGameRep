using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrizzlynHitBox : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Hawkson_PrefabP2" || col.gameObject.name == "Grizzlyn_PrefabP2")
        {
            //if P1 collides with P2, -10 to healthbar
            HealthBarP2.health -= 10f;

            //message to detect collision
            UnityEngine.Debug.Log("-10 to P2");
        }
    }
}
