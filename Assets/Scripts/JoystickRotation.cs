using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickRotation : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    [SerializeField] float speed = 1f;
    public float rotateVertical;
    public float rotateHorizontal;




    private void FixedUpdate()
    {

        rotateVertical = joystick.Vertical * -speed;
        rotateHorizontal = joystick.Horizontal * -speed;

       
            transform.Rotate(rotateHorizontal, 0, rotateVertical);


        Vector3 currentRotation = transform.rotation.eulerAngles;

        currentRotation.x = ClampAngle(currentRotation.x, -10, 10);
        currentRotation.z = ClampAngle(currentRotation.z, -10, 10);


        transform.rotation = Quaternion.Euler(currentRotation);



    }

    public static float ClampAngle(float current, float min, float max)
    {
        float dtAngle = Mathf.Abs(((min - max) + 180) % 360 - 180);
        float hdtAngle = dtAngle * 0.5f;
        float midAngle = min + hdtAngle;

        float offset = Mathf.Abs(Mathf.DeltaAngle(current, midAngle)) - hdtAngle;
        if (offset > 0)
            current = Mathf.MoveTowardsAngle(current, midAngle, offset);
        return current;
    }

}


//if (Mathf.Abs(transform.rotation.x) < 10 && Mathf.Abs(transform.rotation.z) < 10)
//{
  //  transform.Rotate(rotateVertical, 0, rotateHorizontal);
//}