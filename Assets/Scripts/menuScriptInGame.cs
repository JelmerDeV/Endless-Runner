using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScriptInGame : MonoBehaviour {

    public Canvas inGameMenu;
    public Button pressYes;
    public Button pressNo;
   // public Button pressHome;
    public bool keyPress = false;


	// Use this for initialization
	void Start () {

        pressYes = pressYes.GetComponent<Button>();
        pressNo = pressNo.GetComponent<Button>();
        inGameMenu = inGameMenu.GetComponent<Canvas>();
        inGameMenu.enabled = false;
        pressYes.enabled = false;
        pressNo.enabled = false;
        

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)&& !keyPress)
        {
            Time.timeScale = 0f;
            pressYes.enabled = true;
            pressNo.enabled = true;
            inGameMenu.enabled = true;
            keyPress = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && keyPress)
        {
            Time.timeScale = 1f;
            pressYes.enabled = false;
            pressNo.enabled = false;
            inGameMenu.enabled = false;
            keyPress = false;
        }


    }
    /*public void onHomeClick()
    {
        //pressHome.enabled = false;
        Time.timeScale = 0f;
        pressYes.enabled = true;
        pressNo.enabled = true;
        inGameMenu.enabled = true;
    }*/
    public void onPlayClick()
    {
       // pressHome.enabled = true;
        Time.timeScale = 1f;
        pressYes.enabled = false;
        pressNo.enabled = false;
        inGameMenu.enabled = false;
    }
    public void onQuitClick()
    {
        Application.Quit();
    }

}
