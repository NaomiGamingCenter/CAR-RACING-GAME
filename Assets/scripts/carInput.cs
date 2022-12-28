using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carInput : MonoBehaviour
{
    // Start is called before the first frame update
    public float Movement { get;  set; }

    // Update is called once per frame
    void Update()
    {
        Movement = Input.GetAxis("Horizontal");
    }
}
