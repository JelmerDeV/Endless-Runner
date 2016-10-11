using UnityEngine;
using System.Collections;

public class SpawnerMovement : MonoBehaviour {
	private float _spawnerSpeed;

	void Start () {
		
	}
	

	void Update () {
		_spawnerSpeed = GameObject.Find("Player").GetComponent<playerMovement_>().speed;
		transform.Translate(Vector3.forward * Time.deltaTime * _spawnerSpeed);
	}
}
