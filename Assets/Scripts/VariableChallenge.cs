using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableChallenge : MonoBehaviour
{
    //create a var to store your name
    //create a var to store your age
    //create a var to store your speed
    //create a health var
    //create a score var
    //var to check if all keys were collected
    //var for ammo count

    public string myName = "Rob";
    public int myAge = 38;
    public float speed = 5f;
    public int playerHealth = 100;
    public int score = 0;
    public int ammo = 5;
    public bool keysGot = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My Name is: " + myName);
        Debug.Log("My Age is: " + myAge);
        Debug.Log("My Current Speed is: " + speed);
        Debug.Log("My Health is: " + playerHealth);
        Debug.Log("My Score is: " + score);
        Debug.Log("Current Ammo is: " + ammo);
        Debug.Log("Do I have the keys? " + keysGot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
