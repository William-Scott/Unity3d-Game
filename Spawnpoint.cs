﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {

    public GameObject colum;

    public float colddown = 3f;

    float nextSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > nextSpawn) {

            nextSpawn = Time.time + colddown;

            Vector3 spawnP = transform.position;

            spawnP.y += Random.Range(3f, -3f);

            if (GM.isActive == true)
            {
                Instantiate(colum, spawnP, transform.rotation);
            }

        }


    }
}
