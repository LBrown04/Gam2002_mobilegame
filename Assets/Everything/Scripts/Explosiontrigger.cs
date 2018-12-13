using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosiontrigger : MonoBehaviour
{
    public GameObject explosives;
    public Vector3 offset;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(explosives, transform.position + offset, Quaternion.identity);

        }
    }
}
