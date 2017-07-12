using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint2 : MonoBehaviour {

    public GameObject bgmoving;

    public float colddown = 6f;

    float nextSpawn;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

       // Instantiate(bgmoving, transform.position, transform.rotation);
       // Debug.Log("+2");

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + colddown;

            if (GM.isActive == true)
            {
                Instantiate(bgmoving, transform.position, transform.rotation);
            }
            //Debug.Log("+2");

        }
    }
}
