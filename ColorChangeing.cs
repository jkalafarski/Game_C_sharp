using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeing : MonoBehaviour {
	Renderer rend;

	bool startTimer = true;
   
   
    public Material[] mat;
	void Start ()
    {
		rend = GetComponent<Renderer> ();
	}

	void Update ()
    { 
	    StartCoroutine (changeColor ());
		startTimer = false;			
	}

    private IEnumerator changeColor()
    {
        throw new NotImplementedException();
    }

    IEnumerator changeColor(Material rock)
    {
		while (startTimer)
        {
			yield return new WaitForSeconds (5);
            //rend.material.color = Color.white;
            rend.sharedMaterial = rock;

        }
	}
	public void RedBoxStepped()
    {
		//rend.material.color = new Color32 (78, 38, 38, 255);
		//Debug.Log ("Color");
	}
	//komunikacji miedzy skryptami
	//Dodaj tutaj SceneYouLost
	//Dodaj zmienne przechowujace ilosc kroków - jako public int kroki iterowane przy kazdym wykonanym kroku po this.trans...
	//Do pozycji END dodaj wywołanie ScenyGodJob ( liczba krokow , ptaszek V , ilość prób przejscia levelu )
	//ARM do redukcji rozmiaru GRY
	//Kolory obgadaj z kimś - textury tez moga posłużyć
	//Dodaj obslugę listków spadających w tle ? Tak for fun
	//Blokada Leveli ? If Liczba punktów >= X Unclock access to Scene 20-30 itd. 
	//Stworz intro wejsciowe  - nazwa gry i znikające literki w losowej kolejnosci 
	//Poczytaj jak zmienjszyć rozmiar gry 
	//Poczytaj jak zmniejszyc konsumpcje CPU
	//Zastanów się czy nie lepiej napisać tą gre w 2D 
	//Spróbuj sprawnić skrpyt dotyku żeby nie głupiał - wartość distance
	//Liczba iteracji - czy jest ok ? 
	//Może ogarnij sobie jakąś lekturę ? 
	//CZAS CI SIE KOŃCZY
	//Nie siedz za długo przy jednej rzeczy... 
	//Powodzenia!
}

