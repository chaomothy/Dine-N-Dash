using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickPlace : MonoBehaviour
{
    
    public Transform cloneObj;
    public int foodValue;
    private string isPlaced = "n";


    private void OnMouseDown()
    {
    
            if(gameObject.name == "Bottom Bun")
            {
        
                Instantiate(cloneObj, new Vector3(-6.5f, 1f, 4.8f), cloneObj.rotation);

            }

            if(gameObject.name == "Top Bun")
            {
        
                Instantiate(cloneObj, new Vector3(-6.5f, 1f, 4.8f), cloneObj.rotation);

            }

            if(gameObject.name == "Cheese")
            {
        
                Instantiate(cloneObj, new Vector3(-6.5f, 1f, 4.8f), cloneObj.rotation);

            }

            if(gameObject.name == "Bacon")
            {
        
                Instantiate(cloneObj, new Vector3(-6.5f, 1f, 4.8f), cloneObj.rotation);

            }
        
        
        GameManager.plateValue += foodValue;
        Debug.Log(GameManager.plateValue + " " + GameManager.orderValue);

    }
}
