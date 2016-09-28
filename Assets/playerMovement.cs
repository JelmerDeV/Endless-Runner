using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public float speed = 1;
	private float maxSpeed = 30;
	public float speedL = 0;
	public float speedR = 0;
	public float maxSpeedLR = 5;

	void Awake()
	{

	}


	void Update () {

		if (Input.GetKey ("space")) {
			speed = 7;
		}
		if (speed < maxSpeed) {
			speed += 0.02f;
		}
		if (speedL < 0) {
			speedL = 0;
		}
		if (speedR < 0) {
			speedR = 0;
		}
		//Debug.Log (speedL);
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
		transform.Translate(Vector3.left * Time.deltaTime * speedL);
		transform.Translate(Vector3.right * Time.deltaTime * speedR);

		moveLeft ();
		moveRight ();


	}
		


	void moveLeft() {

		if(Input.GetKey("left") && speedL < maxSpeedLR) {
			//speedR = 1;
			speedL += 0.3f;
	    }
		if (!Input.GetKey ("left") && speedL > 0) {
			
			slowL();
		}

   }
	void moveRight() {

		if(Input.GetKey("right") && speedR < maxSpeedLR) {
			//speedL = 1;
			speedR += 0.3f;
		}
		if (!Input.GetKey ("right") && speedR > 0) {

			slowR();
		}

	}

	void slowL(){
		if (speedL > 0) {
			speedL -= 0.4f;
		}
	}
	void slowR(){
		if (speedR > 0) {
			speedR -= 0.4f;
		}
	}

	void OnCollision(Collider other)
	{
		if (other.tag == "Obst") {
			//Destroy (gameObject, 0f);
			Debug.Log("hit");
			speed = 8;
		}
			
	}
}