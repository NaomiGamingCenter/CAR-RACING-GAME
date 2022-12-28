using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : IcarInput
{
    // Start is called before the first frame update
    public void ReadInput()
    {
      carsideMovement = Input.GetAxis("Horizontal");  
    }

    // Update is called once per frame
    public float carsideMovement { get; private set; }
}
