using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Property")]
public class Property : ScriptableObject
{
    public int pole;
    public int cenaKupna;
    public int[] cenaUlepszenia;
    public int[] wartosciPoziomow;
    public float procentCenyWkroczenia;
    public float procentCenySprzedazy;
    public float procentCenyOdkupienia;

}
