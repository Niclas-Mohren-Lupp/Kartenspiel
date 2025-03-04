using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static int MaxKarten = 13;
    public List<int> Zeiten_dict = new List<int>(new int[MaxKarten]);
    public Button CardSelectButton;
    public int Karte;
    public int AlteKarte;
    public bool KartenDa = false;
}