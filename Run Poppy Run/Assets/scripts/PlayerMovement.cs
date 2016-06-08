using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float MovementSpeed;
	
	void Start () {
		
	}
	
	
	void Update () {
		transform.Translate(MovementSpeed * Time.deltaTime, 0f, 0f);
	}

}