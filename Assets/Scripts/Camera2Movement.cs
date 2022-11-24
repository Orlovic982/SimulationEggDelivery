using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Movement : MonoBehaviour
{
    [SerializeField] Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {


        transform.position = new Vector3(player.position.x -4, player.position.y + 5, player.position.z );


    }

  
}
