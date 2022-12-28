using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPlayer : MonoBehaviour
{
    
     [SerializeField]private carSettings carsettings;

    private IcarInput carInput;
    private carMotor carmotor;
    // Start is called before the first frame update
    private void Awake()
    {
        carInput = carsettings.UseAi ? new  AiInput() as IcarInput: new playerController();
        carmotor = new carMotor(carInput, transform, carsettings);


    }

    // Update is called once per frame
    private void Update()
    {
       carInput.ReadInput();
       carmotor.Tick();

    }
    
}
