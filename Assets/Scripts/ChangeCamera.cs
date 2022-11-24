using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] Camera cam1;

    [SerializeField] Camera cam2;




    public void SwitchCamera(int camNumber)
    {

        DeactivateAll();

        if (camNumber == 1) {
            cam1.enabled = true;

        }else if(camNumber == 2)
        {
            cam2.enabled = true;
        }
    

    }

    private void DeactivateAll()
    {
        cam1.enabled = false;

        cam2.enabled = false;

  
    }
}
