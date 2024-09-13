using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public bool isSet;
    // Start is called before the first frame update
    void Start()
    {
        if (isSet)
        {
            Debug.Log("It happens to be true");
        }
        
        Debug.Log("Hello, World!");  
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}