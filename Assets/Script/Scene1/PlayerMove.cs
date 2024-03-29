using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
        transform.position += speed * transform.forward * Time.deltaTime;
        }

         if(Input.GetKey(KeyCode.S))
        {
        transform.position -= speed * transform.forward * Time.deltaTime;
        }

         if(Input.GetKey(KeyCode.D))
        {
        transform.position += speed * transform.right * Time.deltaTime;
        }

         if(Input.GetKey(KeyCode.A))
        {
        transform.position -= speed * transform.right * Time.deltaTime;
        }

        if(Input.GetKey("up"))
        {
        transform.position += speed * transform.forward * Time.deltaTime;
        }

         if(Input.GetKey("down"))
        {
        transform.position -= speed * transform.forward * Time.deltaTime;
        }

         if(Input.GetKey("right"))
        {
        transform.position += speed * transform.right * Time.deltaTime;
        }

         if(Input.GetKey("left"))
        {
        transform.position -= speed * transform.right * Time.deltaTime;
        }
    }
}
