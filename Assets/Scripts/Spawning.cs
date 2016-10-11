using UnityEngine;

using System.Collections;

public class Spawning : MonoBehaviour
{
	public GameObject spawnObject;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	private int ObjsInScene;
	public int maxObj;


	void Start()
	{
		InvokeRepeating("Spawn", spawnTime, spawnTime);


	}

	void Update(){
		GameObject[] collectableObjs = GameObject.FindGameObjectsWithTag ("Obst");
		ObjsInScene = collectableObjs.Length;
	}


	void Spawn()
	{
		if (ObjsInScene < maxObj) {
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		


			Instantiate (spawnObject, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		}
	}
}