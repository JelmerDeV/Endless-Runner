using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreCount : MonoBehaviour {

    public Text score;
    public playerMovement_ player;
    public menuScriptInGame pause;
    public float countScore = 0;


	
	void Start () {
        score = score.GetComponent<Text>();
        player = player.GetComponent<playerMovement_>();
        pause = pause.GetComponent<menuScriptInGame>();
	}
	
	
	void Update () {

        if (!player.hit && !pause.inGameMenu.enabled) 
        {
            countScore += player.speed;
            score.text = ("Meters: " + Mathf.Floor(countScore / 100) + "M");
        }
	}
}
