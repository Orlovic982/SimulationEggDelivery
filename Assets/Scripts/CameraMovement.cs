using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] Transform player;




    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(player.position.x +1, player.position.y +3, player.position.z+9);


    }
}
