using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction = destintion - source
        //calculate the direction to source 
        Vector3 dirToFace = _target.position - transform.position;
        //make the pointer aim at Target
        transform.rotation = Quaternion.LookRotation(dirToFace);
    }
}
