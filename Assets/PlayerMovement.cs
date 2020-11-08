using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get left and right axis from input manger along with keyboard keys
        float horizontalinput = Input.GetAxis("Horizontal");
        //get up and down axis from input manger along with keyboard keys
        float verticalInput = Input.GetAxis("Vertical");

        //move the object left or right multiplied in speed
        transform.Translate(new Vector3(horizontalinput,0,0) * _speed * Time.deltaTime);
        //move the object up or down multiplied in speed
        transform.Translate(new Vector3(0,verticalInput,0) * _speed * Time.deltaTime);
    }
}
