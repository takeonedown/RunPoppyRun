using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed)
		
		GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
	
	}
}
