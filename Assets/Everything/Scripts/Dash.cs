using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float playerSpeed = 5f;
   


    private Rigidbody RB_PC;
    public double Timer;
    private Vector2 v2_movement;

    // Use this for initialization
    void Start()
    {
        RB_PC = gameObject.GetComponent<Rigidbody>();
        Timer = 0.5;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);
        if (GetComponent<Rigidbody>().useGravity == false)
        {
            Timer -= Time.deltaTime;

        }
        if(Timer <= 0)
        {
            playerSpeed = 5f;
            GetComponent<Rigidbody>().useGravity = true;
            Timer = 0.5;
        }
    }

    private void OnMouseDown()
    {
        //maybe there is a time component too?
        //stop moving when you click on it
        RB_PC.velocity = Vector2.zero;
    }

    private void OnMouseUp()
    {
        PointToMouse();
        playerSpeed = 15f;
        GetComponent<Rigidbody>().useGravity = false;
      
    }


    void PointToMouse()
    {
        // convert mouse position into world coordinates
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // get direction you want to point at
        Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;

        // set vector of transform directly
        transform.up = direction;
    }
}