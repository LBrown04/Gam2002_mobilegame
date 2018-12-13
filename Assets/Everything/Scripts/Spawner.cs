using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Playerprefab;
    public GameObject Player;
    public float Timer;
    public GUIText Level1attempts;
    public static int L1Attempts;

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
        L1Attempts++;
        Level1attempts.text = "Attempts: " + L1Attempts;
    }

}
