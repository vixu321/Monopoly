using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class MoneyText : MonoBehaviour {

	private Text tekst;
	
	void Awake () {
		tekst = GetComponent<Text>();

	}
	

	void Update () {

		tekst.text = Player.money.ToString();
	}
}
