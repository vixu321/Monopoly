using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class PoleUINazwa : MonoBehaviour
{
	private Text tekst;
	
	void Awake () {
		tekst = GetComponent<Text>();

	}
	

	void Update () {

		tekst.text = poleUIScript.nazwa;
	}
}