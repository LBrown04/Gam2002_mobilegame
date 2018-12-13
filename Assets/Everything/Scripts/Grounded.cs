using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Grounded : MonoBehaviour {
    public GameObject Jump;
	// Use this for initialization
	void Start () {
        Jump = GameObject.FindGameObjectWithTag("Button");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Floor")
        {
            Jump.GetComponent<ButtonJump>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Floor")
        {
            Jump.GetComponent<ButtonJump>().enabled = false;
        }
    }
}
