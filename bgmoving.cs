using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmoving : MonoBehaviour {

    public float speed = 1f;

    // Use this for initialization
    void Start () {
        if (GM.isActive == true){
            Destroy(gameObject, 20f);
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (GM.isActive == true)
        {

            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }
}
