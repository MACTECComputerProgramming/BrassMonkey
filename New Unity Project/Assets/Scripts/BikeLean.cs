using UnityEngine;

public class BikeLean : MonoBehaviour
{



    void BikeLean()
    {
        bool isPlayerTurning = false;


        if (Input.GetKey("a"))
        {

            isPlayerTurning = true;
            targetRotation = Quaternion.AngleAxis(15f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Left");

        }
        else if (Input.GetKey("d"))
        {

            isPlayerTurning = true;
            targetRotation = Quaternion.AngleAxis(-15f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
            Debug.Log("Turning Right");
        }
        else // level bike if not turning
        {

            targetRotation = Quaternion.AngleAxis(0f, transform.forward) * transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smooth * Time.deltaTime);

        }
    }
}
