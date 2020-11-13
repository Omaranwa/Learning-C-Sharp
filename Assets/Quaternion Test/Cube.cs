using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //WithOut rotation
            //Instantiate(_cube,Vector3.zero,Quaternion.identity);
            //With rotation
            Instantiate(_cube,Vector3.zero,Quaternion.Euler(0,35,0));
        }
    }
}
