using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMotor
{
    private readonly IcarInput carInput;
    private readonly Transform transformToMove;
    private readonly carSettings carsettings;
    //[SerializeField] private float maxposition = 8.4f;

    private float CarSpeed;
    Vector3 position;
    /*public void Awake(){
        position = transform.position;
    }*/

    public carMotor(IcarInput carInput, Transform transformToMove, carSettings carsettings){
        this.carInput = carInput;
        this.transformToMove = transformToMove;
        this.carsettings = carsettings;
        
    } 

    public void Tick(){
     transformToMove.position += Vector3.right * carInput.carsideMovement * Time.deltaTime * carsettings.CarSpeed;
      //Mathf.Clamp (transformToMove.position, -8.4f, 7.7f);
     

    }

    public void Update(){
        transformToMove.position = position;
    }
    
}
