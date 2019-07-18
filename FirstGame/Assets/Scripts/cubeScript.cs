using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Cube);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(Cube, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)), new Quaternion(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)));
        }
    }
}
