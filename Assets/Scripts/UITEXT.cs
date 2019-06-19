
using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine.UI;
 
public class UITEXT : MonoBehaviour {

 

    [SerializeField]
    private Text text;
   public int scoreVal = 1;
   public int knifeVal=1;
   

       //the collider attached to Knife
    public MeshCollider knifeCollider;
 
    private void Awake()
    {
      
        knifeCollider = GetComponent<MeshCollider>();
       text = GetComponent<Text>();
      
    }

    private void OnCollisionEnter(Collision knifeCollider)
    {
    



   
 switch(knifeCollider.gameObject.tag)
 {


    case "100":
    text.text="You win 100";
    ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
     case "200":
        text.text="You win 200";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
      case "300":
      text.text="You win 300";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
      case "Gameover":
      text.text="Gameover";
       
       Time.timeScale = 0;
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "400":
      text.text="You win 400";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "500":
      text.text="You win 500";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "600":
      text.text="You win 600";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "700":
      text.text="You win 700";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "850":
      text.text="You win 850";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "1000":
      text.text="You win 1000";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "150":
      text.text="You win 150";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "1500":
      text.text="You win 1500";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "20":
      text.text="You win 20";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "350":
      text.text="You win 350";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "450":
      text.text="You win 450";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "100000":
      text.text="You win 100000";
     ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
           case "0":
           text.text = "You win 0";
            ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
          break;
default:
ScoreManager.score +=scoreVal;
         KnifeManager.knifenum-=knifeVal;
         GetComponent<ParticleSystem>().Play();
          GameController.Instance.UIControl.Decrementor();
      break;
 }

      





    } 
   
}
