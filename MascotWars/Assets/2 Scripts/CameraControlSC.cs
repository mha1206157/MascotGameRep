using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlSC : MonoBehaviour
{

    //Variables
    public float cameraPanSpeed = -5f;
    Vector2 startPos;
    public Transform ground;

    // Start is called before the first frame update
    void Start()
    {
        //Start Position
        startPos = transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        //Vector2 newPos = new Vector2(100, Time.deltaTime * cameraPanSpeed);
        //transform.position = new Vector2(15, Time.deltaTime * cameraPanSpeed);
        //startPos + Vector2.down * newPos;
        transform.position = Vector3.Lerp(transform.position, ground.position, Time.deltaTime);
    }
}

