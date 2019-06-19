using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
 public Text textsc;
    // Start is called before the first frame update
    void Start()
    {
        textsc=GetComponent<Text>();
        score=0;
    }

    // Update is called once per frame
    void Update()
    {
        textsc.text= "SCORE : " + score;
    }
}
