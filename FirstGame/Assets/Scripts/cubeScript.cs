using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    public GameObject Cube;
    public float speed = 1;
    private Vector3 cameraLocation;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Cube);
        cameraLocation = transform.position - Cube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Cube.transform.position + cameraLocation;
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 direction = new Vector3(0, 0, 0);
            direction.x = Input.GetAxis("Horizontal");
            transform.Translate(direction * speed * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            Vector3 direction = new Vector3(0, 0, 0);
            direction.z = Input.GetAxis("Vertical");
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
