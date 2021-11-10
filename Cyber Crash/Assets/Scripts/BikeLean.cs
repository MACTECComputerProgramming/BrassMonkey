using UnityEngine;

public class BikeLean : MonoBehaviour
{
    public Quaternion targetRotation;
    public float smooth;
    public GameObject myObject;
    public float angle;
    //public Quaternion left
   
    private void Update()
    {
        //float rotation = Quaternion.Angle(transform.rotation, )
        //Rotation to Left
        if (Input.GetAxis("Horizontal") <= -0.1)
        {
            targetRotation = Quaternion.AngleAxis(75f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Right");
        }

        //Rotation to Right
        if (Input.GetAxis("Horizontal") >= 0.1)
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
        
        
       
    }
}
