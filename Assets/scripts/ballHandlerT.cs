using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballHandlerT : MonoBehaviour
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
        
        if (this.transform.position.y <= -6 || PlayerTwoController.ispressed3)
        {
            gameObject.SetActive(false);
            PlayerTwoController.ispressed3 = false;
            PlayerTwoController.isBallTouched3 = false;
        }
    }
}
