using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
    public class Pool{

public string tag;
public GameObject prefab;
public int size;

    }
public class SceneControl : MonoBehaviour
{
      public Rigidbody knife;
      public Rigidbody board;
      
      [SerializeField]
      private int knifecount;
   
    public List<Pool> objectpool;
    public Dictionary<string,Queue<GameObject>> pooldic;
    
public void Awake(){

    
}
    // Start is called before the first frame update
    void Start()
    {
        
        pooldic = new Dictionary<string,Queue<GameObject>>();

  
  foreach(Pool pool in objectpool){

      Queue<GameObject> objects = new Queue<GameObject>();

  for(int i = 0;i<pool.size;i++){

      GameObject obj= Instantiate(pool.prefab);
      obj.SetActive(false);
      objects.Enqueue(obj);
      }
 pooldic.Add(pool.tag,objects);
  }

  
    }

    // Update is called once per frame
 void KnifeCount(){
     if(KnifeManager.knifenum==0){
        
         Debug.Log("Step up!");
     }

 }
}