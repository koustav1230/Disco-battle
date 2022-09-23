using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour
{

    public static bool miss;
    public static bool miss2;
    void Start()
    {
        miss = false;
        miss2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "ball")
        {
            miss = true;
        }
        if (collision.tag == "ball4")
        {
            miss = true;
        }
        if(collision.tag == "ball2")
        {
            miss2 = true;
        }
        if (collision.tag == "ball3")
        {
            miss2 = true;
        }
    }
}
