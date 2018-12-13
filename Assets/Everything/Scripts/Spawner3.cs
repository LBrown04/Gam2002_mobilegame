using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject Playerprefab;
    public GameObject Player;
    public float Timer;
    public GUIText Level3attempts;
    public static int L3Attempts;

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
        L3Attempts++;
        Level3attempts.text = "Attempts: " + L3Attempts;
    }

}
