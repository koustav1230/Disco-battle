using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandlerS : MonoBehaviour
{
    public static float ballspeed;
    public static float balltime;
    void Start()
    {
        ballspeed = 3;
        balltime = 0;
    }


    void Update()
    {
        balltime += Time.deltaTime;

        if (balltime >= 10)
        {
            ballspeed += 0.4f;
            balltime = 0;
        }
        float speed = Time.deltaTime * ballspeed;
        transform.Translate(0, -speed, 0);
        if(transform.position.y <= -6 || PlayerTwoController.ispressed_2)
        {
            gameObject.SetActive(false);
            PlayerTwoController.ispressed_2 = false;
            PlayerTwoController.isBallTouched_2 = false;
        }

    }


}
