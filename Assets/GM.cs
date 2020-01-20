using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

	public static int wynik;
	public GameObject playerModel;
	public GameObject[] pola;
	public int ogolnyWynik;
	public GameObject property;
	public int[] kosztDzialki;
	public int[] kosztUlepszenia;
	private int poziomDzialki;
	private GameObject propertyModel;
	public int nagrodaZaPrzejscie;
	public float podatek;
	public GameObject islandGUI;
	private int liczbaProb;
	private GameObject buttons;

	public Property[] propertyData;
	public static string poleTag;
	



	void Update(){
		if(pola[ogolnyWynik-1].gameObject.tag=="LowEnd"){
			poziomDzialki = 1;
		}else if(pola[ogolnyWynik-1].gameObject.tag=="Middle"){
			poziomDzialki = 2;
		}else if(pola[ogolnyWynik-1].gameObject.tag=="HighEnd"){
			poziomDzialki = 3;
		}else if(pola[ogolnyWynik-1].gameObject.tag=="Event"){
			poziomDzialki = 4;
		}
	Debug.Log(Pole.clickedPole);
	}

	public void Rzut(){

		int pierwszy = Random.Range(1, 6);
		int drugi = Random.Range(1, 6);
		int liczbaDoubli = 0;

		wynik = pierwszy + drugi;
		ogolnyWynik += wynik;
		if(ogolnyWynik > 32){
			if(ogolnyWynik >=32){
				Player.money += nagrodaZaPrzejscie;}
			ogolnyWynik -= 32;
		}
		

		if(pierwszy == drugi){
			liczbaDoubli += 1;
		}

		if(liczbaDoubli == 3){
			ogolnyWynik = 8;
			liczbaDoubli = 0;
		}
		


		buttons = GameObject.FindGameObjectWithTag("Buttons");
		poleTag = pola[ogolnyWynik-1].gameObject.tag;
		
		
		if(poleTag=="Tax"){
			float i = Player.money * podatek;
			Player.money -= Mathf.RoundToInt(i);
		}else if(poleTag=="IslandCorner"){
			islandGUI.SetActive(true);
			buttons.SetActive(false);
		}else if(poleTag=="TravelCorner"){
			if(Player.money > 50){
				Player.money -= 50;
				ogolnyWynik = Pole.clickedPole;
			}


		
		}
		
		GameObject child = pola[ogolnyWynik-1].transform.Find("Cube").gameObject;						
		Transform player = GameObject.Find("Player").transform;		
		GameObject activePlayer = GameObject.FindGameObjectWithTag("Player");
		Destroy(activePlayer);
		Instantiate(playerModel, child.transform.position, child.transform.rotation);



		propertyModel = pola[ogolnyWynik-1].transform.Find("Property").transform.Find("Cube").gameObject;
		

	}

	public void buyProperty(){


			
		GameObject property = pola[ogolnyWynik-1].transform.Find("Property").gameObject;

			if(property.activeInHierarchy == false){
				int afterPurchaseMoney = Player.money -= kosztDzialki[poziomDzialki];
				switch(poziomDzialki){
					case 1: 
						if(afterPurchaseMoney > 0){
						Player.money = afterPurchaseMoney;
						propertyModel.GetComponent<Renderer>().material.color = Color.red;
						property.SetActive(true);
						assignProperty(ogolnyWynik-1, poziomDzialki);
						}
					break;
					case 2: 
						if(afterPurchaseMoney > 0){
						Player.money = afterPurchaseMoney;
						propertyModel.GetComponent<Renderer>().material.color = Color.yellow;
						property.SetActive(true);
						assignProperty(ogolnyWynik-1, poziomDzialki);
						}
					break;
					case 3: 
						if(afterPurchaseMoney > 0){
						Player.money = afterPurchaseMoney;
						propertyModel.GetComponent<Renderer>().material.color = Color.blue;
						property.SetActive(true);
						assignProperty(ogolnyWynik-1, poziomDzialki);
						}

					break;
					case 4: 
						int szansa = Random.Range(1,3);
						if(szansa==1)
							Player.money += 200;
						
					break;
				}
			}
			else{
				Debug.Log("This property is already owned");
			}
	}

	public void ulepszMiasto(){

			GameObject property = pola[ogolnyWynik-1].transform.Find("Property").gameObject;
			 
			if(property.activeInHierarchy == true){
				if(pola[ogolnyWynik-1].gameObject.tag !="HighEnd"){
						
					if(pola[ogolnyWynik-1].gameObject.tag=="LowEnd"){
							int afterUpgradeMoney = Player.money -= kosztUlepszenia[0];
							Player.money = afterUpgradeMoney;
							pola[ogolnyWynik-1].gameObject.tag = "Middle";
							propertyModel.GetComponent<Renderer>().material.color = Color.yellow;
					}
					else if(pola[ogolnyWynik-1].gameObject.tag=="Middle"){
							int afterUpgradeMoney = Player.money -= kosztUlepszenia[1];
							Player.money = afterUpgradeMoney;
							pola[ogolnyWynik-1].gameObject.tag = "HighEnd";
							propertyModel.GetComponent<Renderer>().material.color = Color.blue;

					}
			}
			}
	}

		
	public void assignProperty(int pole, int poziom){
		Player.iloscPol += 1;
		Player.kupionePole[Player.iloscPol] = pole;
		Player.poziomDomu[pole] = poziom;


	}

	public void zaplacIsland(){
		Player.money -= 200;
		islandGUI.SetActive(false);
		
		buttons.SetActive(true);
	}

	public void rzutIsland(){
		int pierwszy = Random.Range(1, 6);
		int drugi = Random.Range(1, 6);
		


		if(pierwszy == drugi){
			buttons.SetActive(true);
			islandGUI.SetActive(false);
		}else{
			liczbaProb +=1;
		}

		if(liczbaProb==3){
			buttons.SetActive(true);
			islandGUI.SetActive(false);}
		}

		

			
	}


