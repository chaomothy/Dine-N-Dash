using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookMove : MonoBehaviour
{
    
    private int foodValue = 0;
    private MeshRenderer meatMat;
    private string stillCooking = "y";

    public Material cookedPatty;
    

    void Start()
    {
    
        StartCoroutine(cookTimer());
    
    }

    private void OnMouseDown()
    {
    
        if(stillCooking == "y")
        {
        
            GetComponent<Transform>().position = new Vector3(-6.5f, -0.1f, 4.8f);
            GameManager.plateValue += foodValue;
            stillCooking = "n";
        
        }
        

    }

    IEnumerator cookTimer()
    {
    
        yield return new WaitForSeconds(3);
        foodValue = 1000;

        if (stillCooking == "y")
        {
        
            GetComponent<MeshRenderer>().material = cookedPatty;
        
        }
    
    }
}
