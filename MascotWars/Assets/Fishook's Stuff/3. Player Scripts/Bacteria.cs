using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D col)
    {
        HealthBar.health -= 10f;

        UnityEngine.Debug.Log("-10");
    }
}
