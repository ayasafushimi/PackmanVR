using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControler : MonoBehaviour {

    //赤パックマン→追いかける
    //追いかけてプレイヤーに追いつくとゲームオーバー

    public GameObject packman;

   // public Transform goal;

    // Use this for initialization
    void Start ()
    {


    }
	
	// Update is called once per frame
	void Update ()

    {
		
	}



    void OnTriggerEnter(Collider other)
    {
 
        if(other.gameObject.CompareTag("player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    

    }
}
