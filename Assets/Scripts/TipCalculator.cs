using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //Bill is 40
    //Tip is 20% or based on user input
    //Calculate total amount

    public float billAmount = 40.0f;
    public float tipAmount;
    public float totalTip;
    public float totalAmount;

    // Start is called before the first frame update
    void Start()
    {

        tipAmount = tipAmount / 100;
        totalTip = billAmount * tipAmount;
        totalAmount = billAmount + totalTip;

        //Your bill is: and your tip amount is: so you owe: totalAmount
        Debug.Log("Your bill is: $" + billAmount + " and your tip amount is: $" + totalTip + " so you owe: $" + totalAmount);
    }

}
