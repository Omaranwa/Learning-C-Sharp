using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    //ref to frecutred Cube
    public GameObject frecutredCube;
    //ref to Explosion
    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if user Hit Space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Add The Explosion Effect
            Instantiate(explosionEffect,transform.position,Quaternion.identity);
            //Add the frecutred Cube Insted and define it to fracutredGameObject
            GameObject fracutredGameObject = Instantiate(frecutredCube, transform.position, Quaternion.identity);
            //get an arry of all rigedbodys in childs of object
            Rigidbody[] allregedbodys = fracutredGameObject.GetComponentsInChildren<Rigidbody>();
            //Check if there is any riged body
            if (allregedbodys.Length > 0)
            {
                //loop for each pice has rigedbody to add force
                foreach (var body in allregedbodys)
                {

                    body.AddExplosionForce(500,transform.position,1);
                }
            }
            //Destroy this game object
            Destroy(this.gameObject);
        }
    }
}
