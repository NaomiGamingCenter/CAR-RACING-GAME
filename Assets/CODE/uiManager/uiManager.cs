using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class uiManager : MonoBehaviour
{     
     [SerializeField] private Button[] buttons;
     
     [SerializeField] bool gameOver;
     
    // Start is called before the first frame update
   void Start()
    {
       //ui = FindObjectOfType<uiManager>();
       gameOver = false;
       
       //scoreText.text = "Score:" + score; 
    }

    // Update is called once per frame
    
    
    
    public void gameOverActivate(){
        gameOver = true;
        foreach(Button button in buttons){
            button.gameObject.SetActive(true);
        }
    }
    
   
   
    
    
}