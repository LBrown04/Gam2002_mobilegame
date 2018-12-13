using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Attempts : MonoBehaviour
{
    public GUIText Level3attempts;

    // Use this for initialization
    void Start()
    {
        Addattempt();

    }

    // Update is called once per frame
    void Update()
    {


    }

    void Addattempt()
    {

        Level3attempts.text = "Attempts: " + Spawner3.L3Attempts;
    }
}
