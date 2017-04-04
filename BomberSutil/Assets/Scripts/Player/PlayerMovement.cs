using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rigidBody;
    private Animator animator;
    private float moveX;
    private float moveY;

    //Movements Animation
    private bool moveUp;
    private bool moveDown;
    private bool moveLeft;
    private bool moveRight;

    private const string playerMoveUp = "Player_Move_Up";
    private const string playerMoveDown = "Player_Move_Down";
    private const string playerMoveLeft = "Player_Move_Left";
    private const string playerMoveRight = "Player_Move_Right";

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ControlsMovement();
        ControlAnimation();
    }

    void ControlsMovement()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        

        rigidBody.velocity = new Vector2(moveX * speed, moveY * speed);
    }

    void ControlAnimation()
    {
        moveUp = moveY > 0;
        moveDown = moveY < 0;
        moveRight = moveX > 0;
        moveLeft = moveX < 0;

        animator.SetBool(playerMoveUp, moveUp);
        animator.SetBool(playerMoveDown, moveDown);
        animator.SetBool(playerMoveLeft, moveLeft);
        animator.SetBool(playerMoveRight, moveRight);

        //Video7 tempo 26:45
    }

}
