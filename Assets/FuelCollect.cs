using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCollect : MonoBehaviour
{
    //when object hit this object (aka fuel) 
    private void OnTriggerEnter(Collider other) {
        //tag = Player | if collide with object with player tag
        if (other.tag == "Player")
        {
            //destory this game object
            Destroy(this.gameObject);
        }
    }
}
