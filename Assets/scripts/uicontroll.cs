using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class uicontroll : MonoBehaviour
{

    public Valuestore values;
    public GameObject Panlen1;
    public GameObject Panlen2;
    string GetScore;
    string GetTime;
    public TMP_InputField score;

    public AudioSource source;
    public AudioClip clip;

    public GameObject Targeterror;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void play()
    {
        Panlen1.SetActive(false);
        Panlen2.SetActive(true);
    }

    public void ok()
    {
        GetScore = score.text;

        values.Maxscore=Convert.ToInt32(GetScore);

        Targeterror.SetActive(false);
        if (values.Maxscore >= 60)
        {
            Panlen1.SetActive(false);
            Panlen2.SetActive(false);
            SceneManager.LoadScene(1);
        }
        if (values.Maxscore < 60)
        {
            Targeterror.SetActive(true);
            values.Maxscore = 0;
        }

    }

    public void clicksound()
    {
        source.PlayOneShot(clip);
    }

}
