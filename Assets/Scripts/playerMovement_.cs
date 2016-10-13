using UnityEngine;
using System.Collections;

public class playerMovement_ : MonoBehaviour
{
    public float speed;
    private float maxSpeed = 50;
    public float speedL = 0;
    public float speedR = 0;
    public float maxSpeedLR = 5;
    private int angle;
    private bool Left = false;
    private bool Right = false;
    public bool hit = false;
    public menuScriptInGame pause;

    void Start()
    {
        pause = pause.GetComponent<menuScriptInGame>();
    }


    void Update()
    {

        if (Right)
        {
            transform.Rotate(Vector3.up * 40 * Time.deltaTime);
        }
        else if (Left)
        {
            transform.Rotate(Vector3.up * -40 * Time.deltaTime);
        }


        if (speed < maxSpeed && !pause.inGameMenu.enabled && !hit)
        {
            speed += 0.02f;
            Debug.Log(speed);
        }
        if (speedL < 0)
        {
            speedL = 0;
        }
        if (speedR < 0)
        {
            speedR = 0;
        }
        //Debug.Log (speedL);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.left * Time.deltaTime * speedL);
        transform.Translate(Vector3.right * Time.deltaTime * speedR);

        moveLeft();
        moveRight();


    }



    void moveLeft()
    {
        if (!Right && !Left)
        {
            if (Input.GetKey("left") && speedL < maxSpeedLR)
            {
                //speedR = 1;
                speedL += 0.3f;
            }
            if (!Input.GetKey("left") && speedL > 0)
            {

                slowL();
            }

        }
    }
    void moveRight()
    {

        if (Input.GetKey("right") && speedR < maxSpeedLR)
        {
            //speedL = 1;
            speedR += 0.3f;
        }
        if (!Input.GetKey("right") && speedR > 0)
        {

            slowR();
        }

    }

    void slowL()
    {
        if (speedL > 0)
        {
            speedL -= 0.4f;
        }
    }

    void turnLeft()
    {
        Left = true;
    }

    void slowR()
    {
        if (speedR > 0)
        {
            speedR -= 0.4f;
        }
    }

    void turnRight()
    {
        Right = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obst")
        {
            angle = Random.Range(0, 2);
            hit = true;
            switch (angle)
            {
                case 0:
                    turnLeft();
                    break;
                case 1:
                    turnRight();
                    break;
            }
            Time.timeScale = 0.4f;
        }
    }
}