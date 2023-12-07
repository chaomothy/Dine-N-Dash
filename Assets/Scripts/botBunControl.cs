using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botBunControl : MonoBehaviour
{
    
    void OnMouseDown()
    {
    
        if(GameManager.anyPattyChosen == "y")
        {
        
            GameManager.selectedBun = transform.position;
            GameManager.bunChosen = "y";
        
        }
    
    }

}
