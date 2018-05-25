using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warpr2 : MonoBehaviour
{

    public GameObject Warpl2;


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
        GameObject.Find("Player").transform.position = Warpl2.transform.position;

    }
}