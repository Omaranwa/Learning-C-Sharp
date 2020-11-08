using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //If user presed space key
       //show a massage

       if (Input.GetKeyDown(KeyCode.Space))
       {
           Debug.Log("Key has been pressed");
       }

       //if E key helded down
       //show a massege
       if (Input.GetKey(KeyCode.E))
       {
           Debug.Log("E key");
       }

       //if F key is lifted up
       //show a massege
       if (Input.GetKeyUp(KeyCode.F))
       {
           Debug.Log("f key is lefted up");
       }
    }
}
