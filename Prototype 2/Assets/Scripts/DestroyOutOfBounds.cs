using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   
    // z ekseninde ki sinirlarimiz
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // eger sinirlarimizdan daha buyuk&kucuk deger alirsa objeyi yok et
        if(transform.position.z > 30)    {
            Destroy(gameObject);
        }
        else if(transform.position.z < -10){
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    
    
    }
}
