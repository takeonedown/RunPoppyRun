using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float MovementSpeed;
	public float JumpHeight;
	
	private Rigidbody2D mainCharacter;
	
	void Start () {
		mainCharacter = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		mainCharacter.velocity = new Vector2(MovementSpeed, mainCharacter.velocity.y);

		if(Input.GetMouseButtonDown(0))
		{
			mainCharacter.velocity = new Vector2 (mainCharacter.velocity.x, JumpHeight);
		}
}