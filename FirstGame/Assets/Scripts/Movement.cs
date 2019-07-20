using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Door")
        {
            transform.position = new Vector3(15, 0, 5);
        }
    }
}
