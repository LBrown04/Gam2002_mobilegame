using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float playerSpeed = 5.0f;

    // Use this for initialization
    void Start()
    {       
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);

        
    }

}


        