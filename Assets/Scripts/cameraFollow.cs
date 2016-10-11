using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour
{

	public GameObject cameraTarget; 
	public GameObject player; 

	public float smoothTime = 0.1f;    
	public bool cameraFollowX = true; 
	public bool cameraFollowY = true; 
	public bool cameraFollowZ = true;
	public bool cameraFollowHeight = true; // camera follow CameraTarget object height
	public float cameraHeight = 0f; // height of camera adjustable
	public Vector2 velocity; // speed of camera movement

	private Transform thisTransform; // camera Transform

	// Use this for initialization
	void Start()
	{
		thisTransform = transform;
	}

	// Update is called once per frame
	void Update()
	{
		if (cameraFollowX)
		{
			thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.x, cameraTarget.transform.position.x, 
				ref velocity.x, smoothTime), thisTransform.position.y, thisTransform.position.z);
		}
		if (cameraFollowY)
		{
			//thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.x, cameraTarget.transform.position.x, 
			//ref velocity.x, smoothTime), thisTransform.position.y, thisTransform.position.z);
		}
		if (!cameraFollowX & cameraFollowHeight)
		{
		}
	}
}