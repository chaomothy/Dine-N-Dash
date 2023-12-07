using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamControl : MonoBehaviour
{
   
    void Update()
    {
        
        if(GameManager.destroySteam == "y")
        {
        
            Destroy(gameObject);
            GameManager.destroySteam = "n";
        
        }

    }

}
