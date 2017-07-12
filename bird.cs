using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bird : MonoBehaviour {

    Rigidbody2D rg;
    public float upForce =400f;

	// Use this for initialization
	void Start () {

        rg = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space")) {

            if (GM.isActive == true)
            {
                rg.AddForce(Vector2.up * upForce);
            }
        }
        if (Input.GetKeyDown("r")) {
            SceneManager.LoadScene(0);
        }
		
	}
}
