using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] Material orange;

    [SerializeField] Material blue;

    [SerializeField] Material red;






    public void SetOrange()
    {
        GetComponent<Renderer>().material = orange;
    }

    public void SetBlue()
    {
        GetComponent<Renderer>().material = blue;
    }

    public void SetRed()
    {
        GetComponent<Renderer>().material = red;
    }


}
