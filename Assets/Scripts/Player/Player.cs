<<<<<<< HEAD
using UnityEngine;
=======
﻿using UnityEngine;
>>>>>>> 7aaee31bfe8a1577a5cbd0c95c9089742280b095
using UnityEngine.Windows;
using UnityEngine.XR;

public class Player : SingletonMonobehavior<Player>
{
    private float xInput;
    private float yInput;
    private bool isCarring = false;
    private bool isIdle;
    private bool isLiftingToolRight;
    private bool isLiftingToolLeft;
    private bool isLiftingToolUp;
    private bool isLiftingToolDown;
    private bool isRunning;
    private bool isUsingToolRight;
    private bool isUsingToolLeft;
    private bool isUsingToolUp;
    private bool isUsingToolDown;
    private bool isSwingingToolRight;
    private bool isSwingingToolLeft;
    private bool isSwingingToolUp;
    private bool isSwingingToolDown;
    private bool isWalking;
    private bool isPickingRight;
    private bool isPickingLeft;
    private bool isPickingUp;
    private bool isPickingDown;
    private ToolEffect toolEffect = ToolEffect.none;

    private Rigidbody2D rigidBody2D;

    private Direction playerDirection;

    private float movementSpeed;

    private bool _playerInputIsDisable = false;
    public bool PlayerInputIsDisable { get => _playerInputIsDisable; set => _playerInputIsDisable = value; }

    protected override void Awake()
    {
        base.Awake();

        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        #region Player Input

        ResetAnimationTriggers();

        PlayerMovementInput();
        PlayerWalkInput();
        EventHandler.CallMovementEvent(xInput, yInput, isWalking, isRunning, isIdle, isCarring,
                toolEffect,
                isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown,
                isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown,
                isPickingRight, isPickingLeft, isPickingUp, isPickingDown,
                isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown,
                false, false, false, false);

        #endregion
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

<<<<<<< HEAD
=======
    // Movement rigidBody2D
>>>>>>> 7aaee31bfe8a1577a5cbd0c95c9089742280b095
    private void PlayerMovement()
    {
        Vector2 move = new Vector2(xInput * movementSpeed * Time.deltaTime, yInput * movementSpeed * Time.deltaTime);
        rigidBody2D.MovePosition(rigidBody2D.position + move);
    }

<<<<<<< HEAD
=======
    // Reset animation when movement, ví dụ sau khi SetAnimationParameters trong MovementAnimationController hoạt động
    //Nếu không reset thì các hành động đã được bật trigger trước đó sẽ không tắt, sẽ dẫn đến lỗi
>>>>>>> 7aaee31bfe8a1577a5cbd0c95c9089742280b095
    private void ResetAnimationTriggers()
    {
        isPickingRight = false;
        isPickingLeft = false;
        isPickingUp = false;
        isPickingDown = false;
        isUsingToolRight = false;
        isUsingToolLeft = false;
        isUsingToolUp = false;
        isUsingToolDown = false;
        isLiftingToolRight = false;
        isLiftingToolUp = false;
        isLiftingToolLeft = false;
        isLiftingToolDown = false;
        isSwingingToolRight = false;
        isSwingingToolLeft = false;
        isSwingingToolUp = false;
        isSwingingToolDown = false;
        toolEffect = ToolEffect.none;
    }

    private void PlayerMovementInput()
    {
        xInput = UnityEngine.Input.GetAxisRaw("Horizontal");
        yInput = UnityEngine.Input.GetAxisRaw("Vertical");

        if (yInput != 0 && xInput != 0)
        {
            xInput = xInput * 0.71f;
            yInput = yInput * 0.71f;
        }

        if (xInput != 0 || yInput != 0)
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;

            // Capture player direction for save game
            if (xInput < 0)
            {
                playerDirection = Direction.left;
            }
            else if (xInput > 0)
            {
                playerDirection = Direction.right;
            }
            else if(yInput < 0)
            {
                playerDirection = Direction.down;
            }
            else
            {
                playerDirection = Direction.up;
            }
        }
        else if(xInput == 0 && yInput == 0)
        {
            isRunning = false;
            isWalking = false;
            isIdle = true;
        }
    }

    private void PlayerWalkInput()
    {
        if (UnityEngine.Input.GetKey(KeyCode.LeftShift) || UnityEngine.Input.GetKey(KeyCode.RightShift))
        {
            isRunning = false;
            isWalking = true;
            isIdle = false;
            movementSpeed = Settings.walkingSpeed;
        }
        else
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;
        }
    }
}
