using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*        Examples of Variables            */
    //A Variable For Name
    public string myName = "Omar";
    //A Variable For Age (Int)
    public int age = 24;
    //A Variable For Speed (float)
    public float speed = 0f;
    //A Variable For Score
    public float score = 0f;
    //A Variable To Check If all Coins are Collected
    public bool areAllCoinsCollected = false;
    //A Variable For ammo Count (int or float)
    public int ammo = 60;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My Name Is " + myName);
        Debug.Log("My age Is " + age);
        Debug.Log("My Speed Right Now Is " + speed + " KM/H");
        Debug.Log("I Have A Score of " + score);
        Debug.Log("Have I Collected All The Coins? " + "The Answer Is: " + areAllCoinsCollected);
        Debug.Log("My ammo Is " + ammo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
