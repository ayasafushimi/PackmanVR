using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{


    private Rigidbody rigd;
    public float speed;
    

    void Start()
    {



    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("up"))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.position -= Vector3.forward * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }

    }




}



    

