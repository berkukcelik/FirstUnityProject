using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ileri yonde speed hizinda gider
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
