using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colum : MonoBehaviour {

    public float speed=2f;

	// Use this for initialization
	void Start () {
        if (GM.isActive == true){
            Destroy(gameObject, 15f);
        }
		
	}

    // Update is called once per frame
    void Update() {
        if (GM.isActive == true){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            GM.score += 1;
           Debug.Log(GM.score);
        }
    }
        


}