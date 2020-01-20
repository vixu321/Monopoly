using UnityEngine;
using UnityEngine.UI;

public class poleUIScript : MonoBehaviour
{

    public static string nazwa;

    void Awake()
    {
        
    }


    public void closeWindow(){
        
        this.gameObject.SetActive(false);
        
    }
}
