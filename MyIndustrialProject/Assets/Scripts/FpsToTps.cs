using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsToTps : MonoBehaviour
{
    public Camera FpsCam;
    public Camera TpsCam;
    public bool isFps;
    



    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isFps = !isFps;
            CheckCamera();
        }
       

    }

    void CheckCamera() 
    {
        if (isFps)
        {
            FpsCam.enabled = true;
            TpsCam.enabled = false;
        }
        else
        {
            FpsCam.enabled = false;
            TpsCam.enabled = true;

        }

    }
   

    
}
