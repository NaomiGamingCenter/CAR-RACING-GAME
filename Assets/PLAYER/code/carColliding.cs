//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Zenject;
    public class carColliding : MonoBehaviour
    {  
        
    [Zenject.Inject] [SerializeField] private uiManager ui;
    void OnCollisionEnter2D(Collision2D coll)
    {   
        
        if(coll.gameObject.tag == "dodgecar")
        {
           Destroy (gameObject);
           ui.gameOverActivate();
           
        }
    }
    }