using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Car/Settings", fileName = "Cardata")]
public class carSettings : ScriptableObject
{   
   [SerializeField]private float carSpeed = 5f;
   [SerializeField]private bool useAi = false;

    public float CarSpeed{ get {return carSpeed;} }
    public bool UseAi { get {return useAi;} }
}
