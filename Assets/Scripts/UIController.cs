using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
[SerializeField]
    private GameObject Panel;
[SerializeField]
private GameObject icon;
[SerializeField]
private Color colorused;
[SerializeField]
private Text youwin;
[SerializeField]
private GameObject restartButton;
public int prizes;
   public void SetKnifes(int index){
for(int i=0;i<index;i++){

    Instantiate(icon,Panel.transform);
}}

public int IconIndexToChange=0;


public void Decrementor(){

    Panel.transform.GetChild(IconIndexToChange++)
    .GetComponent<Image>().color = colorused;
}


public void Destroyer(){

Destroy(icon.gameObject);
}


   }


