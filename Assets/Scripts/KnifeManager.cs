using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeManager : MonoBehaviour
{

    public static int knifenum;
  
    Text knifetest;
    // Start is called before the first frame update
    void Start()
    {
        knifetest = GetComponent<Text>();
        knifenum = 10;
   
    }
    public void numReset(){

        knifenum = 10;
    }

    // Update is called once per frame
    void Update()
    {
        knifetest.text = "KNIVES : " + knifenum;
       KnifeCount();
    }

     public void KnifeCount(){
     if(knifenum==0){
         
         Debug.Log("Step up!");

     }

 }
}

