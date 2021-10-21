using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeLean2 : MonoBehaviour
{
    public Quaternion targetRotation;
    public float smooth;
    public GameObject myObject;
    public float angle;

    private void Update()
    {

        //Rotation to Left
        if (Input.GetAxis("Horizontal") <= -0.1 )
        {
            targetRotation = Quaternion.AngleAxis(75f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Right");
        }
        else
        {
            angle = myObject.transform.rotation.eulerAngles.z;
            targetRotation = Quaternion.AngleAxis(-angle, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
        }
    }
}
