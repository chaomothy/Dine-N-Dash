using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pattyControl : MonoBehaviour
{
    
    public Transform cheeseObj;
    public Transform baconObj;

    public string placePatty = "n";

    void Update()
    {
    
        if((placePatty == "y") && (GameManager.placeCheese == "n") && (GameManager.placeBacon == "n") && (GameManager.bunChosen == "y"))
        {
        
            GetComponent<Transform>().position = GameManager.selectedBun;
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + 0.349f, transform.position.z);
        
        }
    
    }
    
    void OnMouseDown()
    {
    
        if(GameManager.placeCheese == "y")
        {
        
            Instantiate(cheeseObj, new Vector3(transform.position.x, transform.position.y + 0.128f, transform.position.z), cheeseObj.rotation);
            GameManager.placeCheese = "n";

        }

        if(GameManager.placeBacon == "y")
        {
        
            Instantiate(baconObj, new Vector3(transform.position.x, transform.position.y + 0.228f, transform.position.z - 0.4f), baconObj.rotation);
            Instantiate(baconObj, new Vector3(transform.position.x, transform.position.y + 0.228f, transform.position.z + 0.4f), baconObj.rotation);
            
        
        }


        if((placePatty == "n") && (GameManager.placeCheese == "n") && (GameManager.placeBacon == "n") && (GameManager.bunChosen == "n"))
        {
        
            placePatty = "y";
            GameManager.anyPattyChosen = "y";

        }
        
        
    }

}
