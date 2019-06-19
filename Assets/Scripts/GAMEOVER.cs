using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAMEOVER : MonoBehaviour
{

 public Text gameOvertext;
    // Start is called before the first frame update
    void Start()
    {
        //gameOvertext=GetComponent<Text>();
        
    }

    // Update is called once per frame
 public void setText(){
gameOvertext.gameObject.SetActive(true);
 }   
}
