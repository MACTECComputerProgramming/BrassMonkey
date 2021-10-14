using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    public float sideSpeed = 10;

    float horizontalInput;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * sideSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
