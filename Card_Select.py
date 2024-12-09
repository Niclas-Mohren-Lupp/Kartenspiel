import random
Max_Karten = 51
Zeiten_dict = {i: 0 for i in range(1, Max_Karten + 1)}

def Wahrscheinlichkeitsalgorythmus():
    List_Karten = list(range(1, Max_Karten + 1))
    Wahrscheinlichkeit = [0.0196078431] * Max_Karten
    summe = sum(Wahrscheinlichkeit)
    Karte = random.choices(List_Karten, Wahrscheinlichkeit, k=1) [0]
    return Karte

def Karteziehen():
    Random_Karte = Wahrscheinlichkeitsalgorythmus()
    return Random_Karte

def hochzealen(i):
    global Zeiten_dict
    Nummer = i + 1
    Zeiten_dict[Nummer] = 1

    for key in Zeiten_dict:
        if Zeiten_dict[key] >= 1:
            Zeiten_dict[key] += 1
        if Zeiten_dict[key] > 51:
            Zeiten_dict[key] = 0


for _ in range (1, 1000):
    Random_Karte = Karteziehen()
    hochzealen(Random_Karte)
print(Zeiten_dict)