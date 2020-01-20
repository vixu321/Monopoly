using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pole : MonoBehaviour
{

    public GameObject poleUI;
    public Property property;
    public static string propertyName;
    public static int clickedPole;


    void Awake(){
        propertyName = property.name;
    }
    void OnMouseDown(){
        if(poleUI.activeInHierarchy == false){
            if(GM.poleTag=="TravelCorner"){
            
            }
            else{
            poleUI.SetActive(true);
            }
            clickedPole = this.property.pole;
            poleUIScript.nazwa = this.property.pole.ToString();
        }
    }
}
