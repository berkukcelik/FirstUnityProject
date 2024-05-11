using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float horizontalInput;
      public float speed = 10.0f;  
     public float border = 10.0f;
     public GameObject projectilePrefab;
    void Start()
    {
        
    }

    
    void Update()
    {
       if(transform.position.x < -border ){
               // belirledigimiz sinir disina gitmeye calisirsa durur ayni konuma tekrar atanir
            transform.position = new Vector3(-border,transform.position.y,transform.position.z);
       }
       if(transform.position.x > border){
        transform.position = new Vector3(border,transform.position.y,transform.position.z);
       }
          // sag sol tuslaini atadik ve karakteri o yonlerde hareket ettirdik
       horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
          //space tusuna basilinca objeyi cogalttik  (cogaltilacak obje--nerden cogaltilacagi--ve yonu)
     if(Input.GetKeyDown(KeyCode.Space)){

          
          Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.rotation); // cogaltilacak obje, nerden cogaltilacak, hangi yonde cogaltilacak
     }
    
    
    }
}
