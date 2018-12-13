using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Attempts : MonoBehaviour
{
    public GUIText Level2attempts;

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

        Level2attempts.text = "Attempts: " + Spawner2.L2Attempts;
    }
}
