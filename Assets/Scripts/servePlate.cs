using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class servePlate : MonoBehaviour
{
    
    public int thisPlate;

    private void OnMouseDown()
    {
    
        if(GameManager.orderValue[GameManager.plateNum] == GameManager.plateValue[GameManager.plateNum])
        {
        
            Debug.Log("Correct! | Time spent: " + GameManager.orderTimer[GameManager.plateNum]);
        
        }

        GameManager.emptyPlateNow = transform.position.x;
        StartCoroutine(plateReset());
    
    }    

    IEnumerator plateReset()
    {
    
        yield return new WaitForSeconds(.5f);
        GameManager.emptyPlateNow = -1;
        GameManager.totalCash += GameManager.orderTimer[thisPlate] * .10f;

    }

}
