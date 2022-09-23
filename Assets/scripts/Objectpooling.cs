using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpooling : MonoBehaviour
{
    public static Objectpooling instance;
    public List<GameObject> pooledbeam = new List<GameObject>();
    public int NumberOfBeams = 2;
    [SerializeField] GameObject Beam;


    public List<GameObject> pooledbeam_2 = new List<GameObject>();
    public int NumberOfBeams_2 = 2;
    [SerializeField] GameObject Beam_2;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        for(int i = 0; i < NumberOfBeams; i++)
        {
            GameObject TempBeam = Instantiate(Beam);
            TempBeam.SetActive(false);
            pooledbeam.Add(TempBeam);
        }

        for (int i = 0; i < NumberOfBeams_2; i++)
        {
            GameObject TempBeam = Instantiate(Beam_2);
            TempBeam.SetActive(false);
            pooledbeam_2.Add(TempBeam);
        }

    }

 
   public GameObject GetBeamObject()
    {
        for(int i =0; i < pooledbeam.Count ; i++)
        {
            if (!pooledbeam[i].activeInHierarchy)
            {

                return pooledbeam[i];

            }
        }

        return null;
    }
    public GameObject GetBeamObject_2()
    {
        for (int i = 0; i < pooledbeam_2.Count; i++)
        {
            if (!pooledbeam_2[i].activeInHierarchy)
            {

                return pooledbeam_2[i];

            }
        }

        return null;
    }


}


