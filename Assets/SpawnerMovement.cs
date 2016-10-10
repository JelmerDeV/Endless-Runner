using UnityEngine;
using System.Collections;

public class SpawnerMovement : MonoBehaviour {
	private float _spawnerSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_spawnerSpeed = GameObject.Find("Player").GetComponent<playerMovement_>().speed;
		transform.Translate(Vector3.forward * Time.deltaTime * _spawnerSpeed);
	}
}
