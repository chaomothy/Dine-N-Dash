using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunCrate : MonoBehaviour
{
    

    public Transform bottomBunObj;
    public Transform topBunObj;


    void OnMouseDown()
    {
    
        Instantiate(bottomBunObj, new Vector3(-1.94f, -2.121f, 4.08f), bottomBunObj.rotation);
        Instantiate(topBunObj, new Vector3(-7.028f, -1.983f, 4.93f), topBunObj.rotation);
    
    }


}
