using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiInput : IcarInput
{
    // Start is called before the first frame update
    public void ReadInput()
    {
        carsideMovement = Random.Range( -1f, 1f);
    }

    // Update is called once per frame
   
        public float carsideMovement { get; private set; }
    
}
