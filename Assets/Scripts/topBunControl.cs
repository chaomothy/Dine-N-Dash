using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topBunControl : MonoBehaviour
{

    void OnMouseDown()
    {
    
        GetComponent<Transform>().position = new Vector3(-1.94f, -1.18f, 4.08f);

    }


}
