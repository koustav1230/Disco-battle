using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerTwoController : MonoBehaviour
{

    public static bool isBallTouched_2;
    public static bool ispressed_2;
    public TMP_Text ScoreUpdater_2;
    public static int score_2;

    public static bool isBallTouched3;
    public static bool ispressed3;

    public ParticleSystem ps;
    public ParticleSystem ps2;
    public ParticleSystem miss2;
    public audiomanager manager;

    
    void Start()
    {
        isBallTouched_2 = false;
        isBallTouched3 = false;
        ispressed_2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -Time.deltaTime * 10);

        ScoreUpdater_2.text = score_2.ToString();
        if (isBallTouched_2 && Input.GetKeyDown(KeyCode.O))
        {
            manager.explossion();
            ps.Play();
            ispressed_2 = true;
            score_2++;
            
        }
        if (isBallTouched3 && Input.GetKeyDown(KeyCode.P))
        {
            manager.explossion();
            ps2.Play();
            ispressed3 = true;
            score_2++;

        }
        if(border.miss2)
        {
            if(score_2 > 0)
            {
                score_2--;
            }
            miss2.Play();
            border.miss2 = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball2")
        {
            isBallTouched_2 = true;
        }
        if (collision.gameObject.tag == "ball3")
        {
            
            isBallTouched3 = true;
        }
    }
}
