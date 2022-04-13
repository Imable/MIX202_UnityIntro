using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float turnRate;
    [SerializeField] GameObject camera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += camera.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= camera.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= camera.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += camera.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jump * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -turnRate);
            //transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, turnRate);

            //transform.position += Vector3.up * jump * Time.deltaTime;
        }
    }
}
