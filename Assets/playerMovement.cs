using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public float speed = 5;
	public float speedL = 0;
	public float speedR = 0;
	public float maxSpeed = 5;

	void Awake()
	{

	}


	void Update () {
		//Debug.Log (speedL);
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
		transform.Translate(Vector3.left * Time.deltaTime * speedL);
		transform.Translate(Vector3.right * Time.deltaTime * speedR);

		moveLeft ();
		moveRight ();


	}
		


	void moveLeft() {

		if(Input.GetKey("left") && speedL < maxSpeed) {
			//speedR = 1;
			speedL += 0.3f;
	    }
		if (!Input.GetKey ("left") && speedL > 0) {
			
			slowL();
		}

   }
	void moveRight() {

		if(Input.GetKey("right") && speedR < maxSpeed) {
			//speedL = 1;
			speedR += 0.3f;
		}
		if (!Input.GetKey ("right") && speedR > 0) {

			slowR();
		}

	}

	void slowL(){
		if (speedL > 0) {
			speedL -= 0.5f;
		}
	}
	void slowR(){
		if (speedR > 0) {
			speedR -= 0.5f;
		}
	}

}