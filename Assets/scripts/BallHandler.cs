using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public static float ballspeed;
    public static float balltime;

    void Start()
    {
        ballspeed = 3f;
        balltime = 0f;
    }


    void Update()
    {


        balltime += Time.deltaTime;

        if (balltime >= 10f)
        {
            ballspeed += 0.4f;
            balltime = 0f;
        }

        Debug.Log(ballspeed);
        float speed = Time.deltaTime * ballspeed;
        transform.Translate(0f, speed, 0f);
        if(this.transform.position.y >= 6f || PlayeroneCotroller.ispressed)
        {
            gameObject.SetActive(false);
            PlayeroneCotroller.ispressed = false;
            PlayeroneCotroller.isBallTouched = false;
           
        }
    }

}
