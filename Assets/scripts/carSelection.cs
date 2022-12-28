using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carSelection : MonoBehaviour
{   private GameObject[] carList;
    private int index;  
    // Start is called before the first frame update
    private void Start()
    {   index = PlayerPrefs.GetInt("CarSelected");
        carList = new GameObject[transform.childCount];
        //fill array with our models
        for (int i = 0; i < transform.childCount; i++)
            carList[i] = transform.GetChild(i).gameObject;

        //toggle off their renderer
        foreach (GameObject go in carList)
            go.SetActive(false);

        //toggle on selected character
        if (carList[index])
           carList[index].SetActive(true);
    }
    public void previousButton()
    {
        //togggle off the current model

       carList[index].SetActive(false);

       index--; //index -=1; index - 1;

       if (index < 0)
          index = carList.Length - 1; 
        
         //toggle on the new model
       carList[index].SetActive(true);
    }
    public void nextButton()
    {
        //togggle off the current model

       carList[index].SetActive(false);

       index++; //index -=1; index - 1;

       if (index == carList.Length)
          index = 0; 

         //toggle on the new model
       carList[index].SetActive(true);
    }
    public void confirmCar()
    {
      PlayerPrefs.SetInt("CarSelected", index);  
      SceneManager.LoadScene("level 1");
    }
}
