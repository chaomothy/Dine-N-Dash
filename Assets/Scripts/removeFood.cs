using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeFood : MonoBehaviour
{

    void Update()
    {
    
        if ((GameManager.emptyPlateNow > transform.position.x - .4f) && (GameManager.emptyPlateNow < transform.position.x + .4f))
        {
        
            Destroy(gameObject);

        }

    }

}
