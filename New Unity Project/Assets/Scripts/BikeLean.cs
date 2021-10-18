using UnityEngine;

public class BikeLean : MonoBehaviour
{

    public Quaternion targetRotation;
    public float smooth;
    public GameObject myObject;
    public float angle;

    private void Update()
    {
        if (Input.GetAxis("Horizontal") >= 0.1 )
        {
            targetRotation = Quaternion.AngleAxis(-100f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Left");
        }
        else if (Input.GetAxis("Horizontal") <= -0.1 && transform.rotation.z <= 60)
        {
            targetRotation = Quaternion.AngleAxis(100f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Right");
        }
        else // level bike if not turning
        {
            angle = myObject.transform.rotation.eulerAngles.z;
            targetRotation = Quaternion.AngleAxis(-angle, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
        }

    }
}