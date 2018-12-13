using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject Playerprefab;
    public GameObject Player;
    public float Timer;
    public GUIText Level2attempts;
    public static int L2Attempts;

    // Use this for initialization
    void Start()
    {


        Addattempt();
        Spawn();
    }

    void Spawn()
    {
        Timer = 3;
        Player = (GameObject)Instantiate(Playerprefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Spawn();
                Addattempt();

            }
        }
    }
    void Addattempt()
    {
        L2Attempts++;
        Level2attempts.text = "Attempts: " + L2Attempts;
    }

}
