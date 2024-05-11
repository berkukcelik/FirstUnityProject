using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   
   
        // PreFabs klasoru olusturduk o klasore dosyalarimizi koyduk bunlari bir diziye atadik
    public GameObject[] animalPrefabs;
    private float spawnPosX = 10.0f;
    private float spawnPosZ = 20.0f;
    void Start()
    {
        // Bir Fonksiyonu surekli olarak dondurme ("isim",baslama suresi,delay miktari)
        InvokeRepeating("SpawnAnimal",2,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        }
   

    void SpawnAnimal()
    {
            //random indexte random spawn pozisyonda cogaltma metodunu kullandik
            int animalIndex = Random.Range(0,animalPrefabs.Length); 
            Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX,spawnPosX),0,spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos ,animalPrefabs[animalIndex].transform.rotation);
    }







}
