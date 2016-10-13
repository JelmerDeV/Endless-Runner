using UnityEngine;
using System.Collections;

public class obstMovement : MonoBehaviour {
	private float speed = 0.2f;
	// Use this for initialization
	void Start () {
		transform.Rotate(Vector3.right * 90);
		transform.Rotate(Vector3.up * 180);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * speed);
	}
}
