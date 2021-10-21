using UnityEngine;

public class BikeLean : MonoBehaviour
{
    public Quaternion targetRotation;
    public float smooth;
    public GameObject myObject;
    public float angle;

   
    private void Update()
    {
       //Rotation to Left
        if (Input.GetAxis("Horizontal") <= -0.1 && myObject.transform.rotation.eulerAngles.z <= 20)
        {
            targetRotation = Quaternion.AngleAxis(75f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Right");
        }
        
        //Rotation to Right
        if (Input.GetAxis("Horizontal") >= 0.1 && myObject.transform.rotation.eulerAngles.z >= -20)
        {
            targetRotation = Quaternion.AngleAxis(-75f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Left");
        }
        else
        {
            angle = myObject.transform.rotation.eulerAngles.z;
            targetRotation = Quaternion.AngleAxis(-angle, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
        }
        
        
        ////Rotation to Right
        //if (Input.GetAxis("Horizontal") >= 0.1 && myObject.transform.rotation.eulerAngles.z >= -20)
        //{
        //    targetRotation = Quaternion.AngleAxis(-75f, transform.forward) * transform.rotation;
        //    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
        //    Debug.Log("Turning Left");
        //}
        ////Rotation to Left
        //if (Input.GetAxis("Horizontal") <= -0.1 && myObject.transform.rotation.eulerAngles.z <= 20)
        //{
        //    targetRotation = Quaternion.AngleAxis(75f, transform.forward) * transform.rotation;
        //    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
        //    Debug.Log("Turning Right");
        //}
        //else
        //{
        //    angle = myObject.transform.rotation.eulerAngles.z;
        //    targetRotation = Quaternion.AngleAxis(-angle, transform.forward) * transform.rotation;
        //    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
        //}

    }
}
