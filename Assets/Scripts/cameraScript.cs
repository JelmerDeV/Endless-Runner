using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

    Vector3 move = new Vector3(0, 0, 0.1f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += move;
	}
}
