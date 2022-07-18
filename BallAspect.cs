using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallAspect : MonoBehaviour
{
  int click=1;
  public Button bottone;
   public Material Material1;
    public Material Material2;
     public Material Material3;
      public Material Material4;
   public GameObject Object;
    void Start()
    {

       Button btn=bottone.GetComponent<Button>();
       btn.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   void TaskOnClick(){
switch (click)
{
  case 1: Object.GetComponent<MeshRenderer> ().material = Material1;
  click++;
  break;
  case 2: Object.GetComponent<MeshRenderer> ().material = Material2;
  click++;
  break;
  case 3: Object.GetComponent<MeshRenderer> ().material = Material3;
  click++;
  break;
  case 4: Object.GetComponent<MeshRenderer> ().material = Material4;
  click=1;
  break;

}
     
    Debug.Log("Hai premuto bottone");

    }
}
