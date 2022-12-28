using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{   // public void GameObject[] SpawnedCars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     }
    void OnCollisionEnter2D  (Collision2D col){
        if(col.gameObject.tag == "dodgecar"){

         Destroy(col.gameObject);
        }
     }

        
    
}
