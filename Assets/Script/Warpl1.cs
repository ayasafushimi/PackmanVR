using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warpl1 : MonoBehaviour
{

    public GameObject Warpr1;


    private GameObject player;

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
        Vector3 pos = GameObject.Find("Player").transform.position;
        GameObject.Find("Player").transform.position = Warpr1.transform.position;

    }
}
