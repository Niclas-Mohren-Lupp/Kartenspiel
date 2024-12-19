using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Card_Select : MonoBehaviour
{
    public const int Max_Karten = 51;
    public List<int> Zeiten_dict = new List<int>(new int[Max_Karten]);
    void Start()
    {
        Debug.Log(string.Join(", ", Zeiten_dict));
        int Random_Karte = Wahrscheinlichkeitsalgorythmus(Zeiten_dict);
        hochzeahlen(Random_Karte, Zeiten_dict);
    }

    void Update()
    {

    }

    Dictionary<int, float> berechne_Wahrscheinlichkeit(List<int> Zeiten_dict)
    {
        float k = 0.1f;

        Dictionary<int, float> Gewichtungen = Zeiten_dict
            .Select((value, key) => new { key, value = Mathf.Exp(k * value) })
            .ToDictionary(x => x.key, x => x.value);

        float summe_gewichtungen = Gewichtungen.Values.Sum();

        Dictionary<int, float> Wahrscheinlichkeiten = Gewichtungen
            .ToDictionary(x => x.Key, x => x.Value / summe_gewichtungen);

        return Wahrscheinlichkeiten;
    }

    int Wahrscheinlichkeitsalgorythmus(List<int> Zeiten_dict)
    {
        List<int> List_Karten = Zeiten_dict.Select((value, index) => index).ToList();
        Dictionary<int, float> Wahrscheinlichkeiten = berechne_Wahrscheinlichkeit(Zeiten_dict);
        int Random_Karte = List_Karten.OrderBy(x => UnityEngine.Random.value).First();
        Debug.Log(Random_Karte);
        return Random_Karte;
    }

    void hochzealen(Random_Karte, Zeiten_dict)
    {
        Zeiten_dict[Random_Karte] = 1;

        for key in Zeiten_dict:
        {
            if key != Random_Karte:
            {
                Zeiten_dict[key] += 1;
            }
            else:
            {
                Zeiten_dict[key] = 0;
            }
        }
    }
}