using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burgerCrate : MonoBehaviour
{
    
    public Transform burgerPattyObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    
        Debug.Log("Click.");
        Instantiate(burgerPattyObj, new Vector3(3.066f, -2.728f, -0.772f), burgerPattyObj.rotation);
    
    }
}
