using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 1;

    private int j = 1;
    private Vector3 oldy;
    private Vector3 jump;

    // Start is called before the first frame update
    void Start()
    {
        oldy = new Vector3(0, 0, 0);
        jump = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
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

        if (Input.GetAxis("Jump") != 0 && j == 1)
        {
            j = 0;
            Vector3 direction = new Vector3(0, 0, 0);
            direction.y = Input.GetAxis("Jump");
            transform.Translate(direction * 20 * Time.deltaTime);
            jump = direction;
        }
        else
        {
            if (transform.position.y > oldy.y)
            {
                transform.Translate(jump * Time.deltaTime * (-1));
            }
            else
            {
                j = 1;
            }
        }
    }
}
