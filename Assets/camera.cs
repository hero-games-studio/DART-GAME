using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField]
private Animator an;
 private bool isP = false;
    // Start is called before the first frame update
    void Start()
    {
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if( !isP){
       GetComponent<Animator>().enabled= true;
        
            isP=true;
          }
    }
}
