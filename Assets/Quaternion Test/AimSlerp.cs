using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimSlerp : MonoBehaviour
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
        //Store The dir Of target
        Quaternion targetRotation = Quaternion.LookRotation(dirToFace);
        //Smother Rotate the Pointer to target
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation,Time.deltaTime);
    }
}
