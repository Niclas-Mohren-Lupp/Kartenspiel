using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public int Max_Karten;
    public List<int> Zeiten_dicts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Zeiten_dicts = new List<int>(new int[51]);
        for (int i = 0; i <= Max_Karten; ++i)
        {
            Zeiten_dicts.Add(0);
        }

        foreach (int zahl in Zeiten_dicts)
        {
            Debug.Log(zahl);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
