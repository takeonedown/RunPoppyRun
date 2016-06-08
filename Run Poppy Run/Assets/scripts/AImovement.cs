using UnityEngine;
using System.Collections;

public class AImovement : MonoBehaviour {
	public float Speed;
	
	void Start () {
		
	}
	
	
	void Update () {
		transform.Translate(Speed * Time.deltaTime, 0f, 0f);
	}

}