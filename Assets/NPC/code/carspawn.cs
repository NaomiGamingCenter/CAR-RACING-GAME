using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawn : MonoBehaviour
{   
    //[Zenject.Inject] public ndcar enemyCars; 
    public GameObject [] cars;
    public float maxPosition = 8.0f;
    public float delayTimer =100f;
    float timer;
    int carNo;

    // Start is called before the first frame update
    void Start()
    {
      timer = delayTimer;    
    }

    // Update is called once per frame
    void Update()
    {   timer -= Time.deltaTime;
        if (timer <= 0)
        { 
            Vector4 carPos = new Vector4 ( Random.Range(-8.0f,8.0f),transform.position.y, transform.position.z);
            carNo = Random.Range(0, 5);
            


            Instantiate (cars[carNo], carPos, transform.rotation); 
            

             timer = delayTimer;
          
        }
       
    }
}
