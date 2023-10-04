using UnityEngine;
using UnityEngine.UI;

public class FlowManagerNew : MonoBehaviour
{
    public TMPro.TMP_Text stepsText;
    public QuestButtonsHighlighter qt;

    [Space(20)]
    [Header("Balloon and Confetti")]
    public GameObject balloon;
    public GameObject confetti;

    #region Controllers UI Button References

    [Space(20)]
    [Header("Controllers UI Button Highlighter References", order = 0)]
    [Header("UI Left Controller", order = 1)]
    public Image leftThumbstick;
    public Image x,y,leftGrip,leftTrigger;

    [Space(20)]
    [Header("UI Right Controller",order = 1)]
    public Image rightThumbstick;
    public Image a,b,rightGrip,rightTrigger;

    #endregion

    void Start()
    {
        balloon.SetActive(false);
        confetti.SetActive(false);
    }
    void Update()
    {
        
        IndexSetter();
    }

    void BalloonAndConfetti()
    {
        if(BNG.InputBridge.Instance.AButtonDown || BNG.InputBridge.Instance.XButtonDown)
        {
            balloon.SetActive(true);
            balloon.GetComponent<SkinnedMeshRenderer>().material.color = new Color(Random.Range(0,255),Random.Range(0,255),Random.Range(0,255));
            confetti.SetActive(false);
        }
        if(BNG.InputBridge.Instance.BButtonDown || BNG.InputBridge.Instance.YButtonDown)
        {
            balloon.SetActive(false);
            confetti.SetActive(true);
        }
    }
    void IndexSetter()
    {
        switch(GameManager.instance.index)
        {
            case 0:
                ImageColourResetter();
                break;
            // For Button A and X
            case 1:
                ImageColourResetter();
                a.color = GameManager.instance.color;
                x.color = GameManager.instance.color;
                BalloonAndConfetti();
                if(BNG.InputBridge.Instance.AButtonDown || BNG.InputBridge.Instance.XButtonDown){GameManager.instance.index = 2;}
                break;
            // For Button B and Y
            case 2:
                ImageColourResetter();
                b.color = GameManager.instance.color;
                y.color = GameManager.instance.color;
                BalloonAndConfetti();
                if(BNG.InputBridge.Instance.BButtonDown || BNG.InputBridge.Instance.YButtonDown){GameManager.instance.index = 3;}
                break;
            // For Right Joystick
            case 3:
                ImageColourResetter();
                rightThumbstick.GetComponentInParent<Image>().color = GameManager.instance.color;
                if(BNG.InputBridge.Instance.RightThumbstickAxis.magnitude != 0){GameManager.instance.index = 4;}
                break;
            // For Left Joystick
            case 4:
                ImageColourResetter();
                leftThumbstick.GetComponentInParent<Image>().color = GameManager.instance.color;
                if(BNG.InputBridge.Instance.LeftThumbstickAxis.magnitude != 0){GameManager.instance.index = 5;}
                break;
            // Right Trigger
            case 5:
                ImageColourResetter();
                rightTrigger.color = GameManager.instance.color;
                if(BNG.InputBridge.Instance.RightTrigger > 0){GameManager.instance.index = 6;}
                break;
            // Left Trigger
            case 6:
                ImageColourResetter();
                leftTrigger.color = GameManager.instance.color;
                if(BNG.InputBridge.Instance.LeftTrigger > 0){GameManager.instance.index = 7;}
                break;
            // Right Grip
            case 7:
                ImageColourResetter();
                rightGrip.color = GameManager.instance.color;
                if(BNG.InputBridge.Instance.RightGrip > 0){GameManager.instance.index = 8;}
                break;
            // Left Grip
            case 8:
                ImageColourResetter();
                leftGrip.color = GameManager.instance.color;
                if(BNG.InputBridge.Instance.LeftGrip > 0){GameManager.instance.index = 0; }
                break;
            default:
                print("Invalid Index Value");
                break;
        }
    }
    void ImageColourResetter()
    {
        a.color = Color.white;
        b.color = Color.white;
        x.color = Color.white;
        y.color = Color.white;
        leftTrigger.color = Color.white;
        leftGrip.color = Color.white;
        leftThumbstick.color = Color.white;
        rightTrigger.color = Color.white;
        rightGrip.color = Color.white;
        rightThumbstick.color = Color.white;
    }

}
