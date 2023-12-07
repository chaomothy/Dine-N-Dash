using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class servePlate : MonoBehaviour
{
    
    private void OnMouseDown()
    {
    
        if(GameManager.orderValue == GameManager.plateValue)
        {
        
            Debug.Log("Correct order!");
        
        }
    
    }    

}
