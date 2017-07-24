using UnityEngine;
using System.Collections;

public class CameraContoller : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called after everything is done in a frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
