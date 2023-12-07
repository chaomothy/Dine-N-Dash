using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baconCrate : MonoBehaviour
{
    public Transform baconObj;


    void OnMouseDown()
    {
    
        GameManager.placeBacon = "y";
    
    }
}
