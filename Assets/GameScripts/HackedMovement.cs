using UnityEngine;
using System.Collections;

public class HackedMovement : MonoBehaviour {
	private Vector3 position;
	// Use this for initialization
	void Start () {
		position = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			position.x = position.x+1;
		}
		if (Input.GetKey (KeyCode.W)) {
			position.z = position.z-1;
		}
		if (Input.GetKey (KeyCode.S)) {
			position.z = position.z+1;
		}
		if (Input.GetKey (KeyCode.D)) {
			position.x = position.x-1;
		}
		if (Input.GetKey (KeyCode.Space)) {
			position.y = position.y+1;
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			position.y = position.y-1;
		}
		this.gameObject.transform.position = position;
	}
}

