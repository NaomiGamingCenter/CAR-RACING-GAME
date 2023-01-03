using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{    [SerializeField] private Text scoreText;
     [SerializeField] private int score;
     //[Zenject.Inject] [SerializeField] private uiManager ui;

     bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
       score = 0;
       gameOver = false;
       InvokeRepeating("scoreUpdate", 1.0f ,0.5f); 
    }

    // Update is called once per frame
   void Update()
    {  
      
      scoreText.text = "Score:" + score;
    
      
    }
  void scoreUpdate(){

      if (!gameOver){
        score += 1;
      }
  }
  public void gameIsOver(){
    gameOver = true;
   
 }
   
}
