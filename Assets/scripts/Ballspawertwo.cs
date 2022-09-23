using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballspawertwo : MonoBehaviour
{
    public float BallspawingTime;
    public GameObject Holder;
    public GameObject holdr2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rand = Random.Range(0.2f, 0.9f);

        BallspawingTime -= Time.deltaTime;
        if (BallspawingTime <= 0)
        {
            if (Objectpooling.instance != null)
            {
                GameObject Temp = ObjectPooltwo.instance.GetBeamObject();
                Temp.transform.position = transform.position;
                Temp.SetActive(true);

                GameObject Temp_2 = ObjectPooltwo.instance.GetBeamObject_2();
                Temp_2.transform.position = transform.position;
                Temp_2.SetActive(true);

                Temp.transform.parent = Holder.transform;
                Temp_2.transform.parent = holdr2.transform;

            }
            BallspawingTime = rand;
        }
    }
}
