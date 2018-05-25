using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;





public class DotControler : MonoBehaviour
{

    GameCounter gameCounter;

    GameController GameController;
    

    public GameObject dot;
    // Use this for initialization
    public void Start()
    {
        gameCounter = GameObject.Find("GameCounter").GetComponent<GameCounter>();

        GameController = GameObject.Find("GameController").GetComponent<GameController>();

     

    }

    // Update is called once per frame
    void Update()
    { 
        {
            


        }


    }



    void OnTriggerEnter(Collider other)
    {

        Debug.Log(gameCounter.dotCount++);

        GameController.Audio();

        
        Destroy(dot);
        


    }


}
