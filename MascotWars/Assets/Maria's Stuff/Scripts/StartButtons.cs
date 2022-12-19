using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtons : MonoBehaviour
{

    //Start Button
    public GameObject one;
    //Options Button
    public GameObject two; 
    //Camera Position
    public Transform mainCamera;

    //Vectors
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        //one.GameObject.GetActive(false);
        //two.GameObject.GetActive(false);
        //Make Buttons Invisible
        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        //GetComponent<RectTransform>().scale = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
