using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static int[] orderValue = {12011, 12021, 10011, 11111};
    public static int[] plateValue = {0, 0, 0, 0};
    public static float[] orderTimer = {150, 150, 150, 150};
    
    public static int plateNum = 0;
    public static float plateXpos = -6.65f;

    public Transform plateSelector;


    public MeshRenderer[] currentPic;
    public Texture[] orderPics;

    public static float emptyPlateNow = -1;
    public static float totalCash = 0;


    void Start()
    {
    
        for (int rep = 0; rep < 4; rep += 1)
        {
        
            if (orderValue[rep] == 10011)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[0];

            if (orderValue[rep] == 10111)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[1];

            if (orderValue[rep] == 11001)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[2];

            if (orderValue[rep] == 11011)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[3];

            if (orderValue[rep] == 11111)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[4];

            if (orderValue[rep] == 12011)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[5];

            if (orderValue[rep] == 12021)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[6];

            if (orderValue[rep] == 12022)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[7];

            if (orderValue[rep] == 12111)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[8];

            if (orderValue[rep] == 12122)
            currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[9];

        
        }

    }

    void Update()
    {
    
        if(Input.GetKeyDown("tab"))
        {
        
            plateNum += 1;
            plateXpos += 4.14f;

            if (plateNum > 3)
            {
            
                plateNum = 0;
                plateXpos = -6.65f;

            }
        }

        orderTimer[0] -= Time.deltaTime;
        orderTimer[1] -= Time.deltaTime;
        orderTimer[2] -= Time.deltaTime;
        orderTimer[3] -= Time.deltaTime;

        plateSelector.transform.position = new Vector3(plateXpos, -2.84f, 4.94f);

    }

}
