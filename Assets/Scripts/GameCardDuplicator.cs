using System.Collections.Generic;
using UnityEngine;

public class GameCardDuplicator : MonoBehaviour
{
    public GameObject GameCard;
    private List<GameObject> createdCards = new List<GameObject>();

    void Start()
    {
        Debug.Log("Skript 2 Start");
        SaveData saveData = gameObject.GetComponent<SaveData>();

        if (saveData != null)
        {
            Debug.Log("Karte CardSelect: " + saveData.Karte);
            System.Threading.Thread.Sleep(1000);
            saveData.CardSelectButton.onClick.AddListener(() => ShowCards(saveData));
        }
    }


    void ShowCards(SaveData saveData)
    {
        for (int i = 0; i != SaveData.MaxKarten; i++)
        {
            GameObject newCard = createdCards.Find(card => card.name == $"Karte {i + 1}");
            if (saveData.AlteKarte == 0)
            {
                Debug.Log("Alte Karte == Null");
            }
            else
            {
                GameObject AlteKarte = createdCards.Find(card => card.name == $"Karte {saveData.AlteKarte + 1}");
                AlteKarte.SetActive(false);
            }

            if (i + 1 == saveData.Karte)
            {
                newCard.SetActive(true);
                Debug.Log("Show Card; " + newCard + "Karte: " + saveData.Karte);
                saveData.AlteKarte = saveData.Karte;
            }

            if (saveData.Karte == 0)
            {
                Debug.Log("Karte nicht gefunden:" + saveData.Karte);
            }
        }
    }
}