using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarP2 : MonoBehaviour
{
    //variables
    Image healthBarP2;
    public float maxHealth = 100f;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        healthBarP2 = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //HealthBar fill depends on health divided by total health
        healthBarP2.fillAmount = health / maxHealth;
    }
}
