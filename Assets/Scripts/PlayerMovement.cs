using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int facing = 1;
    public Rigidbody2D myRigidBody2D;
    private float horizontalMovement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        float flipX = Input.GetAxisRaw("Horizontal");
        if (flipX != 0)
        {
            FlipPlayer(flipX);
        }
    }

    private void FixedUpdate()
    {
        myRigidBody2D.velocity = new Vector2(horizontalMovement * moveSpeed, myRigidBody2D.velocity.y);
    }

    public void FlipPlayer(float x)
    {
        transform.localScale = new Vector2(x, transform.localScale.y);
        facing = (int)x;
    }
}
