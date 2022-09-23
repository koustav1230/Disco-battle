using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayeroneCotroller : MonoBehaviour
{
    public static bool isBallTouched;
    public static bool ispressed;

    public static bool isBallTouched4;
    public static bool ispressed4;

    public TMP_Text ScoreUpdater;
    public static int score;

    public audiomanager manager;

    public ParticleSystem ps;
    public ParticleSystem ps2;
    public ParticleSystem miss;


    void Start()
    {
        isBallTouched = false;
        ispressed = false;
    }

    void Update()
    {

        transform.Rotate(0,0,Time.deltaTime*10);

        ScoreUpdater.text = score.ToString();
        if (isBallTouched && Input.GetKeyDown(KeyCode.Q))
        {
            ps.Play();
            manager.explossion();
            ispressed = true;
            score++;
            
        }
        if (isBallTouched4 && Input.GetKeyDown(KeyCode.E))
        {
            ps2.Play();
            manager.explossion();
            ispressed4 = true;
            score++;
        }

        if(border.miss)
        {
            if (score > 0)
            {
                score--;
            }
            miss.Play();
            border.miss = false;    
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            isBallTouched = true;
        }
        if (collision.gameObject.tag == "ball4")
        {
            isBallTouched4 = true;
        }
    }
}
