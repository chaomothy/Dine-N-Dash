using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatControl : MonoBehaviour
{
    
    public Transform cloneObj;
    

    private void OnMouseDown()
    {
    
        if (gameObject.name == "Patty")
        {
        
            Instantiate(cloneObj, new Vector3(-6.668f, -1.984f, -0.321f), cloneObj.rotation);

        }

    }
}
