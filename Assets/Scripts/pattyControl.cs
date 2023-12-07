using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pattyControl : MonoBehaviour
{
    
    public Transform cheeseObj;
    public Transform baconObj;
    public Transform steamObj;

    public string placePatty = "n";

    public Material rawPatty;
    public Material cookedPatty;
    public Material burntPatty;

    public float cookingTime = 0f;


    void Start()
    {

        Instantiate(steamObj, transform.position, steamObj.rotation);
        GetComponent<MeshRenderer>().material = rawPatty;

    }
    void Update()
    {
    
        cookingTime += Time.deltaTime;

        if((cookingTime > 5f && cookingTime < 10f) && (placePatty != "LOCKED"))
        {
        
            GetComponent<MeshRenderer>().material = cookedPatty;

        }else if((cookingTime > 10f) && (placePatty != "LOCKED"))
        {
        
            GetComponent<MeshRenderer>().material = burntPatty;

        }

        
    
        if((placePatty == "y") && (GameManager.placeCheese == "n") && (GameManager.placeBacon == "n") && (GameManager.bunChosen == "y"))
        {
        
            GetComponent<Transform>().position = GameManager.selectedBun;
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + 0.349f, transform.position.z);

            GameManager.destroySteam = "y";
            placePatty = "LOCKED";
        
        }

        if(GameManager.isTrashClicked == "y")
        {
        
            Destroy(gameObject);
            GameManager.isTrashClicked = "n";
            GameManager.destroySteam = "y";
        
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
            GameManager.placeBacon = "n";
            
        
        }


        if((placePatty == "n") && (GameManager.placeCheese == "n") && (GameManager.placeBacon == "n") && (GameManager.bunChosen == "n"))
        {
        
            placePatty = "y";
            GameManager.anyPattyChosen = "y";

        }
        
        
    }

}
