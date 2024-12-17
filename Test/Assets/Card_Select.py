import random
import math
Max_Karten = 51
Zeiten_dict = {i: 0 for i in range(1, Max_Karten + 1)}

def berechne_Wahrscheinlichkeit(zeiten_dict):
    #ChatGPT
    k = 0.1

# Schritt 1: Berechne die Gewichtungen (w(x) = e^(k * Zeiten_dict[key]))
    Gewichtungen = {key: math.exp(k * value) for key, value in Zeiten_dict.items()}

# Schritt 2: Berechne die Summe der Gewichtungen
    summe_gewichtungen = sum(Gewichtungen.values())

# Schritt 3: Normalisiere die Gewichtungen, um Wahrscheinlichkeiten zu erhalten
    Wahrscheinlichkeiten = {key: gewicht / summe_gewichtungen for key, gewicht in Gewichtungen.items()}

    return Wahrscheinlichkeiten

def Wahrscheinlichkeitsalgorythmus(zeiten_dict):
    List_Karten = list(zeiten_dict.keys())
    Wahrscheinlichkeit = berechne_Wahrscheinlichkeit(zeiten_dict)
    Random_Karte = random.choices(List_Karten, weights = Wahrscheinlichkeit, k=1) [0]
    print(Random_Karte)
    return Random_Karte

def hochzealen(Random_Karte, Zeiten_dict):
    Zeiten_dict[Random_Karte] = 1

    for key in Zeiten_dict:
        if key != Random_Karte:
            if Zeiten_dict[key] < 51:
                Zeiten_dict[key] += 1
        
            else:
                Zeiten_dict[key] = 0



Random_Karte = Wahrscheinlichkeitsalgorythmus(Zeiten_dict)
hochzealen(Random_Karte, Zeiten_dict)