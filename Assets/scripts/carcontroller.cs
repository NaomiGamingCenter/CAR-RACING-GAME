using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;


     
     public class carcontroller : MonoBehaviour

  {  [SerializeField] private float carSpeed;
     //[SerializeField] private float minPosition = 8.4f;
     //[SerializeField] private float maxPosition = 7.7f;

     
     Vector3 position; 
     [Zenject.Inject] [SerializeField] private uiManager ui;
    private carInput carInputValue;

     // Start is called before the first frame update
    void Awake()
    {
      position = transform.position;
      carInputValue = GetComponent<carInput>();

    }

    // Update is called once per frame
    void Update()
    {
       //position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
       //position.x = Mathf.Clamp (position.x, -8.4f, 7.7f);

       //transform.position = position;
       float carleftright = carInputValue.Movement;
       position += Vector3.right * carleftright * Time.deltaTime  * carSpeed;
       position.x = Mathf.Clamp (position.x, -8.4f, 7.7f);
       transform.position = position;

    }
     
    void OnCollisionEnter2D(Collision2D coll)
    {   
        
        if(coll.gameObject.tag == "dodgecar")
        {
           Destroy(gameObject);
           ui.gameOverActivate();
           //SceneManager.LoadScene("GameOver");
        }
    }
}
   

