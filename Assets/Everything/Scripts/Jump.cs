using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool Ground;
    public float jumpcount;
    public Vector2 jumpHeight;
    // Use this for initialization
    void Start()
    {
        jumpcount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpcount == 1 && Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody>().AddForce(jumpHeight, ForceMode.Impulse);
            jumpcount -= 1;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Floor")
        {
            jumpcount += 1;
        }
    }
}