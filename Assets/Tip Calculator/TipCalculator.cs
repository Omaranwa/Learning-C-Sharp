using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    // A Variable For bill
    public float mainBill = 40;
    // A Variable For Tip
    public float mainTip = 20.0f;
    // A Variable For Total Amount
    
    // Start is called before the first frame update
    void Start()
    {
        float tipAmount = mainBill * (mainTip / 100) ;
        Debug.Log("Your Bill Is " + mainBill + " and there is a tip of " + mainTip + "%" + " and The Total Mony is " + (tipAmount + mainBill));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
