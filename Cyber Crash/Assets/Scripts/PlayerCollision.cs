
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;     //A referecne to our PlayerMovement Script
    


    //This function runs when we hit another object
    //We get information about th ecollision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        //We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;   //Disabled the players movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}













