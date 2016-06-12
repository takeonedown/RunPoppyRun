using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float jump = 10;
	bool nojump = false;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) ) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 
			(GetComponent<Rigidbody2D>().velocity.x, jump);
		}
	}
	
	void onTriggerEnter2D() {
		nojump = true;
	}
	void onTriggerExit2D() {
		nojump = false;
	}
	
}
