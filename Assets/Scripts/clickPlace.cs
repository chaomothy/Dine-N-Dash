using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickPlace : MonoBehaviour
{
    
    public Transform cloneObj;
    public int foodValue;
    

    private void OnMouseDown()
    {
    
            if(gameObject.name == "Bottom Bun")
            {
        
                Instantiate(cloneObj, new Vector3(GameManager.plateXpos, 1f, 4.8f), cloneObj.rotation);

            }

            if(gameObject.name == "Top Bun")
            {
        
                Instantiate(cloneObj, new Vector3(GameManager.plateXpos, 1f, 4.8f), cloneObj.rotation);

            }

            if(gameObject.name == "Cheese")
            {
        
                Instantiate(cloneObj, new Vector3(GameManager.plateXpos, 1f, 4.8f), cloneObj.rotation);

            }

            if(gameObject.name == "Bacon")
            {
        
                Instantiate(cloneObj, new Vector3(GameManager.plateXpos, 1f, 4.8f), cloneObj.rotation);

            }
        
        
        GameManager.plateValue[GameManager.plateNum] += foodValue;
        Debug.Log(GameManager.plateValue[GameManager.plateNum] + " " + GameManager.orderValue[GameManager.plateNum]);

    }
}
