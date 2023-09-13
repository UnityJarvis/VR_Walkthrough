using UnityEngine;

public class QuestButtonsHighlighter : MonoBehaviour
{
    public Material questDefault,highlighter;
    [Header("Left Controller")]
    public MeshRenderer xButton,yButton,l_Thumbstick,l_Trigger,l_Grip;
    [Header("Right Controller")]
    public MeshRenderer aButton,bButton,r_Thumbstick,r_Trigger,r_Grip;
    [Header("Oculus Specific")]
    public MeshRenderer oculusBtn;
    [Header("Debug")]
    public MeshRenderer cubee;

    public TMPro.TMP_Text buttonPressText;

    public void MaterialSwitcher(MeshRenderer ButtonReference, Color hilightedColour ){ButtonReference.material = highlighter; highlighter.color = hilightedColour;}
    public void MaterialResetter(MeshRenderer ButtonReference){ButtonReference.material = questDefault;}

    void Update()
    {
        if(BNG.InputBridge.Instance.LeftTrigger > 0){MaterialSwitcher(cubee,Color.red);buttonPressText.text = "LeftTrigger";}
        else if(BNG.InputBridge.Instance.RightTrigger > 0){MaterialSwitcher(cubee,Color.red);buttonPressText.text = "RightTrigger";}
        else if(BNG.InputBridge.Instance.AButtonDown){MaterialSwitcher(cubee,Color.blue);buttonPressText.text = "A Button";}
        else if(BNG.InputBridge.Instance.BButtonDown){MaterialSwitcher(cubee,Color.blue);buttonPressText.text = "B Button";}
        else if(BNG.InputBridge.Instance.XButtonDown){MaterialSwitcher(cubee,Color.blue);buttonPressText.text = "X Button";}
        else if(BNG.InputBridge.Instance.YButtonDown){MaterialSwitcher(cubee,Color.blue);buttonPressText.text = "Y Button";}
        else if(BNG.InputBridge.Instance.LeftGrip > 0){MaterialSwitcher(cubee,Color.green);buttonPressText.text = "Left Grip";}
        else if(BNG.InputBridge.Instance.RightGrip > 0){MaterialSwitcher(cubee,Color.green);buttonPressText.text = "Right Grip";}
        else if(BNG.InputBridge.Instance.LeftThumbstickAxis.magnitude != 0){MaterialSwitcher(cubee,Color.yellow);buttonPressText.text = "LeftThumbstickAxis";}
        else if(BNG.InputBridge.Instance.RightThumbstickAxis.magnitude != 0){MaterialSwitcher(cubee,Color.yellow);buttonPressText.text = "RightThumbstickAxis";}

        else{MaterialResetter(cubee); buttonPressText.text = "NO PRESS";}

        
    }
}
