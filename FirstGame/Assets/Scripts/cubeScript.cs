using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    public float speed = 5;
    public GameObject Cube;
    public TextMeshPro TextMesh;

    private int j = 0;

    // Start is called before the first frame update
    void Start()
    {
        j = 0;
        TextMesh.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(j == 1)
        {
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKey(KeyCode.Z))
            {
                Cube.transform.Rotate(Vector3.up * (speed * Time.deltaTime), -2f);
                //TextMesh.transform.Rotate(Vector3.up * (speed * Time.deltaTime), -2f);
                TextMesh.transform.RotateAround(Cube.transform.position, Vector3.up * (speed * Time.deltaTime), -2f);
                transform.RotateAround(Cube.transform.position, Vector3.up * (speed * Time.deltaTime), -2f);
                if (transform.eulerAngles != Cube.transform.eulerAngles)
                {
                    transform.eulerAngles = Cube.transform.eulerAngles;
                }
            }

            if (Input.GetKeyDown(KeyCode.C) || Input.GetKey(KeyCode.C))
            {
                Cube.transform.Rotate(Vector3.up * (speed * Time.deltaTime), 2f);
                //TextMesh.transform.Rotate(Vector3.up * (speed * Time.deltaTime), 2f);
                TextMesh.transform.RotateAround(Cube.transform.position, Vector3.up * (speed * Time.deltaTime), 2f);
                transform.RotateAround(Cube.transform.position, Vector3.up * (speed * Time.deltaTime), 2f);
                if (transform.eulerAngles != Cube.transform.eulerAngles)
                {
                    transform.eulerAngles = Cube.transform.eulerAngles;
                }
            }

            if (Input.GetAxis("Horizontal") != 0)
            {
                Vector3 direction = new Vector3(0, 0, 0);
                direction.x = Input.GetAxis("Horizontal");
                Cube.transform.Translate(direction * (speed * Time.deltaTime));
                TextMesh.transform.Translate(direction * (speed * Time.deltaTime));
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                Vector3 direction = new Vector3(0, 0, 0);
                direction.z = Input.GetAxis("Vertical");
                Cube.transform.Translate(direction * (speed * Time.deltaTime));
                TextMesh.transform.Translate(direction * (speed * Time.deltaTime));
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(j == 1)
            {
                TextMesh.enabled = true;
                j = 0;
            }
            else
            {
                TextMesh.enabled = false;
                j = 1;
            }
        }
    }
}
