using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOARD: MonoBehaviour
{
    private GameObject bd;
    public Rigidbody rigidbody;
    public MeshCollider meshcoll;
    
   
    

    

        
   
  
   
    
    
    


    void Start()
    {
        bd=GameObject.FindWithTag("Board");
        rigidbody = GetComponent<Rigidbody>();
        meshcoll = GetComponent<MeshCollider>();
     
       
 
      
    }
     


 

    void FixedUpdate()
    {
      bd.transform.Rotate(0,0.8f,0);
 
    
     }
   


    
    
    }
        
       



