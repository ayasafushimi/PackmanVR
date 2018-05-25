using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCounter : MonoBehaviour
{

    public int dotCount = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int i = dotCount;
        if (i == 236)
        {
           SceneManager.LoadScene("GameClear");
        }
	}
}
