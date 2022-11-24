using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class testTimelineEvent : MonoBehaviour
{
    public float[] decklist;
    private float tempGO; 
    
    void Start()
    {
        Shuffle();
    }

    public void Shuffle()
    {
        for (int i = 0; i < decklist.Length; i++)
        {
            int rnd = Random.Range(0, decklist.Length);
            tempGO = decklist[rnd];
            decklist[rnd] = decklist[i];
            decklist[i] = tempGO;
        }
    }

    public void timeEventTest()
    {
        //
        Debug.Log("HOLA");
    }
}
