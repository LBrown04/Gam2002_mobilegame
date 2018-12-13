using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Attempts : MonoBehaviour {
    public GUIText Level1attempts;

	// Use this for initialization
	void Start () {
        Addattempt();
        
    }
	
	// Update is called once per frame
	void Update () {
        
                
    }

    void Addattempt()
    {
    
        Level1attempts.text = "Attempts: " + Spawner.L1Attempts;
    }
}
