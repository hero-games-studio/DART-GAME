using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ProjectileThrow : MonoBehaviour {
 
 public Vector3 startpos = new Vector3(2.9f,6.6f,-117.9f);
    
  // public Vector3 adjustposition = new Vector3(0.05f,0.05f,0.05f);
  public Vector3 throwforce;
   public int scoreVal = 1;
   public int knifeVal=1;
    //public Vector3 childposition = new Vector3(498,150,-1200);
  
    private int instantpos=1;
    private bool isActive = true;
    private bool isCollide = false;

    //for controlling physics
   public Rigidbody rb;
   public GameObject board;
   public GameObject knife;


   

       //the collider attached to Knife
    public MeshCollider knifeCollider;
    
    private void Awake()
    {
       // knife=GetComponent<GameObject>();
        rb = GetComponent<Rigidbody>();
        knifeCollider = GetComponent<MeshCollider>();
        board = GameObject.FindWithTag("Board");
        knife=GameObject.Find("Knife");
      
        

      
      // knife.transform.position = startpos;
 
   

 }
 void Instantiater(){
    

    
        for (int i=0;i<1;i++){
        
         
          Instantiate(rb,startpos,transform.rotation);

    
   



 }}
    void FixedUpdate () {
            ObjectRenewal();
            numReset();
        if(Input.GetMouseButtonDown(0)){

            rb.AddForce(throwforce,ForceMode.Impulse);
        }

   
 
   
  

 }
 private void OnCollisionStay(Collision knifeCollider){
   
  rb.constraints = RigidbodyConstraints.FreezeAll;
  rb.isKinematic=true;
rb.transform.Rotate(175*Time.deltaTime,0,0);

//Debug.Log("Collision ok");
 




 }
    private void OnCollisionEnter(Collision knifeCollider)
    {
    
 if (!isActive)
            return;
 
        //if the knife happens to be active (1st collision), deactivate it
        isActive = false;

   
 if(knifeCollider.gameObject.name == "100"){ 
    Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+99;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();

 }
 if(knifeCollider.gameObject.name == "200"){ 
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+199;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();

 }
 if(knifeCollider.gameObject.name == "300"){ 
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();

 }
 if(knifeCollider.gameObject.name=="400"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="500"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+499;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="600"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+599;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="700"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+699;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="850"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+849;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="1000"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+999;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="150"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal + 149;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="1500"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+1499;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="20"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+19;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="350"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+349;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }if(knifeCollider.gameObject.name=="450"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+449;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="100000"){
        Debug.Log(knifeCollider.gameObject.name);
        ScoreManager.score +=scoreVal+99999;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }
 if(knifeCollider.gameObject.name=="0"){
        Debug.Log(knifeCollider.gameObject.name);
       GameController.Instance.Gameover.setText();
       Time.timeScale = 0.001f;
        KnifeManager.knifenum-=knifeVal;
        GetComponent<ParticleSystem>().Play();
        GameController.Instance.UIControl.Decrementor();
     
 }


    


  if(!isCollide){
  Instantiater();
  isCollide=true;


}
 transform.SetParent(knifeCollider.collider.transform);






    } 
    public void ObjectRenewal(){
       if(KnifeManager.knifenum==0){
   //Destroy(gameObject);
  // Destroy(board);
         }
         
    
}
   public void numReset(){
if(KnifeManager.knifenum==0){
        KnifeManager.knifenum = 10;
       SceneManager.LoadScene("beta21");
       DontDestroyOnLoad(GameController.Instance.UIControl);
    }

}
}


