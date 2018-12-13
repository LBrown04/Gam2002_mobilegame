using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{

    public GameObject player;


    public Vector3 offset;

    // Use this for initialization
    void Start()
    {
        
    }


    void LateUpdate()
    {
        if (player==null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        transform.position = player.transform.position + offset;
    }
}