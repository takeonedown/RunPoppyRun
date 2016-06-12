using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

	public float speed;
	public Renderer rend;
	
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * speed;
		rend.material.mainTextureOffset = new Vector2(offset, 0);
	
	}
}
