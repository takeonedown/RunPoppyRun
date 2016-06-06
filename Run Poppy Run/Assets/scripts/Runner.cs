using UnityEngine;

public class Runner : MonoBehaviour {

	void Update () {
		transform.Translate(10f * Time.deltaTime, 0f, 0f);
	}
}
