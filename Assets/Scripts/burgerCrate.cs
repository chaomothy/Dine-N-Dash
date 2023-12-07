using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burgerCrate : MonoBehaviour
{
    
    public Transform burgerPattyObj;


    void OnMouseDown()
    {
    
        Instantiate(burgerPattyObj, new Vector3(3.066f, -2.728f, -0.772f), burgerPattyObj.rotation);
    
    }
}
