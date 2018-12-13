using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonJump : MonoBehaviour
{
    public bool isbuttondown = false;
    public GameObject player;
    public Vector2 jumpHeight;
    public double timer;

    // Use this for initialization
    void Start()
    {
        timer = 0.1;

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (isbuttondown && timer == 0.1)
        {
            player.GetComponent<Rigidbody>().AddForce(jumpHeight, ForceMode.Impulse);
            timer -= Time.deltaTime;
        }
        if (timer < 0.1)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timer = 0.1;
        }

    }

    public void Buttonclickdown()
    {
        isbuttondown = true;
    }

    public void Buttonclickup()
    {
        isbuttondown = false;
    }
}


