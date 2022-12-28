using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMotor
{
    private readonly IcarInput carInput;
    private readonly Transform transformToMove;
    private readonly carSettings carsettings;

    private float CarSpeed;
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
    }

    /*public void Update(){
        transform.position = position;
    }*/
    
}
