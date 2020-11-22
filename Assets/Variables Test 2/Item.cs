using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    // Has A Name
    public string itemName;
    // Has A Description
    public string itemDescription;
    // Has A Price
    public float itemPrice;
    // Has An Icon
    public Sprite itemicon;
    // Has An Level
    public string itemLevel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Item Name: " + itemName);
        Debug.Log("Item Description: " + itemDescription);
        Debug.Log("item Price: " + itemPrice);
        Debug.Log("Item level: " + itemLevel);
    }
}
