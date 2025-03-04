using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public class Card_Select : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Skript 1 Start");
        SaveData saveData = gameObject.GetComponent<SaveData>();
        saveData.CardSelectButton.onClick.AddListener(() => SkriptStart(saveData));
    }

    void SkriptStart(SaveData saveData)
    {
        Debug.Log("Skript Start");
        saveData.Karte = Wahrscheinlichkeitsalgorythmus(saveData);
        hochzeahlen(saveData);
    }

    int Wahrscheinlichkeitsalgorythmus(SaveData saveData)
    {
        List<int> List_Karten = saveData.Zeiten_dict.Select((value, index) => index).ToList();
        Dictionary<int, float> Wahrscheinlichkeiten = berechne_Wahrscheinlichkeit(saveData);
        float randomValue = UnityEngine.Random.value;
        float cumulative = 0.0f;
        int Karte = List_Karten[0];

        foreach (var item in Wahrscheinlichkeiten)
        {
            cumulative += item.Value;
            if (randomValue < cumulative)
            {
                saveData.Karte = item.Key;
                break;
            }
        }
        Debug.Log("Karte: " + saveData.Karte);
        return saveData.Karte;
    }

    Dictionary<int, float> berechne_Wahrscheinlichkeit(SaveData saveData)
    {
        float k = 0.1f;

        Dictionary<int, float> Gewichtungen = saveData.Zeiten_dict
            .Select((value, key) => new { key, value = Mathf.Exp(k * value) })
            .ToDictionary(x => x.key, x => x.value);

        float summe_gewichtungen = Gewichtungen.Values.Sum();

        Dictionary<int, float> Wahrscheinlichkeiten = Gewichtungen
            .ToDictionary(x => x.Key, x => x.Value / summe_gewichtungen);

        Debug.Log(string.Join(", ", saveData.Zeiten_dict));
        return Wahrscheinlichkeiten;
    }


    void hochzeahlen(SaveData saveData)
    {
        for (int key = 0; key < saveData.Zeiten_dict.Count; key++)
        {
            if (key != saveData.Karte)
            {
                saveData.Zeiten_dict[key] += 1;
            }

            else
            {
                saveData.Zeiten_dict[key] = 0;
            }
        }
        Debug.Log(string.Join(", ", saveData.Zeiten_dict));
    }
}