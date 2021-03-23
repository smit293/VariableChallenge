using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //every item has a name
    //every item has a description
    //every item has an image icon
    //every item has an attack strength

    public string itemName = "A sword ";
    public string itemDescription = " a weapon for stabbing and cutting bad guys! ";
    public Sprite itemImage;
    public float attackStr = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(itemImage + "You have found: " + itemName + itemDescription + "the attack strength is: " + attackStr);
    }

}
