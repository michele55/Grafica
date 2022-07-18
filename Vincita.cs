using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vincita : MonoBehaviour
{
  
public Text Text;
public GameObject testo;
public GameObject Mattonella;
    void Awake(){
 




}
    // Start is called before the first frame update
     void OnCollisionEnter(Collision collision){
        Text.text = "Hai Vinto!!!";
        testo.GetComponent<Text>().text="Hai Vinto";
        Debug.Log("Vincita");
     }
}
