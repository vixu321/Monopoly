using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class rzutWynik : MonoBehaviour {

	private Text tekst;
	
	void Awake () {
		tekst = GetComponent<Text>();

	}
	

	void Update () {

		tekst.text = GM.wynik.ToString();
	}
}
