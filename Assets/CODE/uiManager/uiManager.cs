using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;


public class uiManager : MonoBehaviour
{    [Zenject.Inject] [SerializeField] private Score gamescore; 
     [SerializeField] private Button[] buttons;
     
     public void gameOverActivate(){
       // gamescore.gameIsOver();
        foreach(Button button in buttons){
            button.gameObject.SetActive(true);
        }
    }
    
   
   
    
    
}