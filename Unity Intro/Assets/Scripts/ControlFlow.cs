using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public bool flag;
    // Start is called before the first frame update
    void Start()
    {
        if (flag)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn't set");
        }

        for (int i = 0; i <= 10; i++)
        {
            int result = (int)Mathf.Pow(2, i);
            Debug.Log($"The {i} power of 2 is {result}");
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}