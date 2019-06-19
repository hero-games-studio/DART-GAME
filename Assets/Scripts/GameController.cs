using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(UIController))]
public class GameController : MonoBehaviour
{

public static GameController Instance {get;private set;}

[SerializeField]
private int count;

//[Header("Knife Spawning")]
//private Vector3 spawnpos;
//[SerializeField]
//private GameObject knife;


public UIController UIControl{get;private set;}
public GAMEOVER Gameover{get;private set;}

private void Awake(){

    Instance = this;
    UIControl = GetComponent<UIController>();
    Gameover = GetComponent<GAMEOVER>();
}
private void Start(){
  
    UIControl.SetKnifes(count);
   // spawnknife();
}
   
   
    
        
     /*   switch(FINALANGLE){
            case 0:
            angletext.text = "You win 200";
            break;
            case 45:
            angletext.text = "You win 100";
            break;
            case 90:
            angletext.text = "You win 500";
            break;
            case 135:
            angletext.text = "You win 1000";
            break;
            case 180:
            angletext.text = "You win 1500";
            break;
            case 225:
            angletext.text = "You win 1750";
            break;
            case 270:
            angletext.text = "You win 2000";
            break;
            case 315:
            angletext.text = "Game OVER";
            break;
            case 360:
            angletext.text = "You win 3550";
            break;
        }
          coroutineallow = true;
        }
    }
//public void OnHit(){

   // if(count>0){{
       // spawnknife();
   // }
   // else
   //Gameover();
   // }
//}

//private void SpawnKnife(){

   // count--;
   // Instantiate(knife,spawnpos,Quaternion.identity);

//}

//public void GameOver(bool win){


//}
 */
}
