using UnityEngine;

public class Player : MonoBehaviour {
public float JumpSpeed = 10.0f;
	
	void Jump() {
		rigidbody2D.AddForce(Vector3.up * JumpSpeed);
	
	}
	
	void Update () {
		transform.Translate(10f * Time.deltaTime, 0f, 0f);
		if (Input.GetButton(GetMouseButtonDown(0)
			Jump();

	}


}
