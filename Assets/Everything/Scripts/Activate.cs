using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {
    public GameObject Gun;
    public GameObject player;
	// Use this for initialization
	void Start () {

        
        Gun.GetComponent<EnemyShooting>().enabled = false;
        Gun.GetComponent<FacesPlayer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            Gun.GetComponent<EnemyShooting>().enabled = false;
            Gun.GetComponent<FacesPlayer>().enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Gun.GetComponent<EnemyShooting>().enabled = true;
            Gun.GetComponent<FacesPlayer>().enabled = true;
        }
    }
   
}
