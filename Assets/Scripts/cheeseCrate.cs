using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseCrate : MonoBehaviour
{
    public Transform burgerCheeseObj;


    void OnMouseDown()
    {
    
        GameManager.placeCheese = "y";
    
    }

    
}
