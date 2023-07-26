public delegate void MovementDelegate(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarring,
    ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolTop, bool isUsingToolDown,
    bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolTop, bool isLiftingToolDown,
    bool isPickingRight, bool isPickingLeft, bool isPickingTop, bool isPickingDown,
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolTop, bool isSwingingToolDown,
    bool idleUp, bool idleDown, bool idleLeft, bool idleRight);

public static class EventHandler
{
    //Movement Event

    public static event MovementDelegate MovementEvent;

    //Movement Event Call For Publishers

    public static void CallMovementEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarring,
    ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolTop, bool isUsingToolDown,
    bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolTop, bool isLiftingToolDown,
    bool isPickingRight, bool isPickingLeft, bool isPickingTop, bool isPickingDown,
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolTop, bool isSwingingToolDown,
    bool idleUp, bool idleDown, bool idleLeft, bool idleRight)
    {
        if (MovementEvent != null)
        {
            MovementEvent(inputX, inputY, isWalking, isRunning, isIdle, isCarring,
                toolEffect,
                isUsingToolRight, isUsingToolLeft, isUsingToolTop, isUsingToolDown,
                isLiftingToolRight, isLiftingToolLeft, isLiftingToolTop, isLiftingToolDown,
                isPickingRight, isPickingLeft, isPickingTop, isPickingDown,
                isSwingingToolRight, isSwingingToolLeft, isSwingingToolTop, isSwingingToolDown,
                idleUp, idleDown, idleLeft, idleRight);
        }
    }
}