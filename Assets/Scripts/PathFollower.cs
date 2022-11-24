using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PathCreation;

public class PathFollower : MonoBehaviour
{

    [SerializeField] PathCreator pathCreator;
    [SerializeField] float speed=10f;
    [SerializeField] float distanceTravelled;



   
    void Update()
    {

        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);


    }
}
