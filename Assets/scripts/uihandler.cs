using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class uihandler : MonoBehaviour
{
    public Valuestore values;
    public GameObject Maingame;

    public float Timecount;
    public GameObject uis;
    public GameObject ui2;
    public GameObject Player1;
    public GameObject Player2;

    public TMP_Text Countdowntext;

    public bool isrest;


    
    void Start()
    {
        
        isrest =true;
        Timecount = 3f;
    }

    void Update()
    {
        Countdowntimer();
        Decider();

            
 
    }

    private void Decider()
    {
        if (PlayeroneCotroller.score >= values.Maxscore && PlayerTwoController.score_2 <= values.Maxscore)
        {
            Maingame.SetActive(false);
            uis.SetActive(true);
            Player1.SetActive(true);
            Player2.SetActive(false);
        }
        if (PlayeroneCotroller.score <= values.Maxscore && PlayerTwoController.score_2 >= values.Maxscore)
        {
            Maingame.SetActive(false);
            uis.SetActive(true);
            Player1.SetActive(false);
            Player2.SetActive(true);
        }
        if (PlayeroneCotroller.score == values.Maxscore && PlayerTwoController.score_2 == values.Maxscore)
        {
            Maingame.SetActive(false);
            uis.SetActive(true);
            Debug.Log("Playertwowins");
        }
    }

    private void Countdowntimer()
    {
        Timecount -= Time.deltaTime;
        Countdowntext.text = Timecount.ToString("f0");
        if (Timecount >= 0)
        {
         
            ui2.SetActive(true);
            Maingame.SetActive(false);
        }
        if (Timecount < 0)
        {
            ui2.SetActive(false);
            Maingame.SetActive(true);
            Timecount = 0;
        }
        if (!isrest)
        {
            Timecount = 3;
            isrest = true;
        }
    }

    public void exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Tryagaing()
    {
        isrest = false;
        PlayeroneCotroller.score = 0;
        PlayerTwoController.score_2 = 0;

        BallHandler.ballspeed = 3f;
        BallHandler.balltime = 0f;
        

        ballHandlerF.ballspeed = 3;
        ballHandlerF.balltime = 0;
        

        ballHandlerT.ballspeed = 3;
        ballHandlerT.balltime = 0;

        BallHandlerS.ballspeed = 3;
        BallHandlerS.balltime = 0;

        SceneManager.LoadScene(1);

        //ui2.SetActive(true);
        //uis.SetActive(false);
    }
}
