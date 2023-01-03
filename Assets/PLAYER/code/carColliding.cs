//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Zenject;
    public class carColliding : MonoBehaviour
    {  
        
    [Zenject.Inject] [SerializeField] private uiManager ui;
    [Zenject.Inject] [SerializeField] private Score gamescore; 
    
    
    void OnCollisionEnter2D(Collision2D coll)
      {    
        if(coll.gameObject.tag == "dodgecar") //zenject dodgecar
        {
          
           Destroy(gameObject);
           ui.gameOverActivate();
           gamescore.gameIsOver();
        
        }
       
       }
    }