using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //position ref
    public Vector3 newPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        //Get Object position and set it "newPosition"
        transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
