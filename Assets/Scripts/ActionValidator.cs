using UnityEngine;
[System.Serializable]
public class ControllerInputs
{
    public bool AButton,BButton;
    public float triggerValue,gripValue;
    public Vector2 joystickValue;
}

public class ActionValidator : MonoBehaviour
{
    public ControllerInputs Left,Right;
    void Update()
    {
        CheckAnyActionPerformed();
    }

    void CheckAnyActionPerformed()  
    {
        Left.AButton = BNG.InputBridge.Instance.AButton; 
        Left.BButton = BNG.InputBridge.Instance.BButton;
        Left.triggerValue = BNG.InputBridge.Instance.LeftTrigger;
        Left.gripValue = BNG.InputBridge.Instance.LeftGrip;
        Left.joystickValue = BNG.InputBridge.Instance.LeftThumbstickAxis;

        Right.AButton = BNG.InputBridge.Instance.XButton;
        Right.BButton = BNG.InputBridge.Instance.YButton;
        Right.triggerValue = BNG.InputBridge.Instance.RightTrigger;
        Right.gripValue = BNG.InputBridge.Instance.RightGrip;
        Right.joystickValue = BNG.InputBridge.Instance.RightThumbstickAxis;
    }
}