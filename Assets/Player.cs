using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static int money;
	public static int[] kupionePole;		//przetrzymywany jest numer pola na ktorej jest dzialka
	public static int[] poziomDomu; 		//na miejscu pola jest poziom domu		
	public int startingMoney;
	public static int iloscPol = 0;

	void Start(){
		money = startingMoney;

	}

	void Update(){
		if(money <=0){
			money = 0;
			Bankructwo();
		}
			}


	public void Bankructwo(){
		Debug.Log("Gracz musial zbankrutowac");
		Destroy(gameObject);
		Destroy(GameObject.FindGameObjectWithTag("Player"));
	}


}
