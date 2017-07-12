using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Text score;
    public GameObject gameover;
    public GameObject restart;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        score.text = "Score:" + GM.score;
        if (GM.isActive == false)
        {
            gameover.SetActive(true);
            restart.SetActive(true);
        }
		
	}
}
