import random
Max_Karten = 51

def Wahrscheinlichkeitsmechanismus():
    List_Karten = list(range(1, Max_Karten + 1))
    Wahrscheinlichkeit = [0.0196078431] * Max_Karten
    summe = sum(Wahrscheinlichkeit)
    Karte = random.choices(List_Karten, Wahrscheinlichkeit, k=1) [0]
    return Karte

def Karteziehen():
    def Variable_erstellen():
        counter =+ 1
        if counter == Max_Karten:
            counter = 0
        Random_Karte = Wahrscheinlichkeitsmechanismus()
        variable_name = f"Variable_{counter}"
        return {variable_name: Random_Karte}

    ergebnis = Variable_erstellen()
    Karten_dict = {}
    Karten_dict.update(ergebnis)
    print(Karten_dict)

Karteziehen()