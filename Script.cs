using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    int count=0;
    bool test=false;
   void Start(){
      if(test==true){
   count++;
}
Debug.Log("Var"+count.ToString());
      
   }
    // Start is called before the first frame update
    void Update(){
    float y=transform.position.y;

    if(y<16){
      test=true;
    }
   
 

    }

    void LateUpdate () {

}

  

 }

//}
