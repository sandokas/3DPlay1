using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {
	public GameObject ObjectToInstantiate;
	public GameObject positionAndRotationTransform;
	public bool isRandomRotation = false;
	private Vector3 position;
	private Quaternion rotation;
	// Use this for initialization
	void Start () {
		position = positionAndRotationTransform.transform.position;
		rotation = positionAndRotationTransform.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.T)) {
			isRandomRotation = !isRandomRotation;
		}
		if (isRandomRotation) {
			rotation = Random.rotation;
		}
		if (Input.GetKey(KeyCode.F)) {
			Instantiate (ObjectToInstantiate, position, rotation);
		}
	}
}
