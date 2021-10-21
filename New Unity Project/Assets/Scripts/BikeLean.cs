using UnityEngine;

public class BikeLean : MonoBehaviour
{
    public Quaternion targetRotation;
    public float smooth;
    public GameObject myObject;
    public float angle;

   
    private void Update()
    {
        if (myObject.transform.rotation.eulerAngles.x >= -20 || myObject.transform.rotation.eulerAngles.x <= 20)
        {
            Debug.Log("Good");

        }
        else if (myObject.transform.rotation.eulerAngles.x <= -20 || myObject.transform.rotation.eulerAngles.x >= 20)
        {
            Debug.Log("Bad");
        }

        //Rotation to Right
        if (Input.GetAxis("Horizontal") >= 0.1)
        {
            targetRotation = Quaternion.AngleAxis(-75f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Left");
        }
        //Rotation to Left
        else if (Input.GetAxis("Horizontal") <= -0.1)
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
