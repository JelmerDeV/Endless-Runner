using UnityEngine;
using System.Collections;

public class Despawn : MonoBehaviour {
	private float despawnTime = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		despawnTime -= Time.deltaTime;
		//Debug.Log (despawnTime);

		if (despawnTime < 1) {
			Destroy (gameObject, 0f);
		}
	}
}
