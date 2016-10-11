using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {


    public GameObject tilePrefab;
    public float time = 1f;
    Vector3 forward = new Vector3(0, 0, 113.6f);

	
    void Timer()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 2f;
            Spawn();
        }
    }


    void Spawn()
    {
        Instantiate(tilePrefab, this.transform.position, Quaternion.identity);
        this.transform.position += forward;
    }


	void Update ()
    {
        Timer();
        //Debug.Log(time);
        // 113.6 IS DE AFSTAND TUSSEN DE TILES>>>>>>>>
        // 96.9 EERSTE Z WAARDE EERSTE TILE NA DE ORGINELE
	}
}
