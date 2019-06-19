using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wheelcontroller : MonoBehaviour
{
    [SerializeField]
    private int randomValue;
    [SerializeField]
    private float timeInterval;
    [SerializeField]
    private bool coroutineallow;
    [SerializeField]
    private int FINALANGLE;
    [SerializeField]
    private Text angletext;
    // Start is called before the first frame update
    void Start()
    {
        coroutineallow = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began && coroutineallow)
        StartCoroutine(Spin());

    }
    private IEnumerator Spin(){


        coroutineallow = false;
        randomValue = Random.Range(20,30);
        timeInterval = 0.1f;
        for ( int i = 0; i< randomValue; i++){

        transform.Rotate(0,0,22.5f);
        if(i > Mathf.RoundToInt(randomValue * 0.5f))
        timeInterval = 0.2f;
        if(i> Mathf.RoundToInt(randomValue * 0.85f))
        timeInterval = 0.4f;
        yield return new WaitForSeconds(timeInterval);
        if(Mathf.RoundToInt(transform.eulerAngles.z) % 45 !=0)
        transform.Rotate(0,0,22.5f);
        FINALANGLE = Mathf.RoundToInt(transform.eulerAngles.z);
        switch(FINALANGLE){
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
}
