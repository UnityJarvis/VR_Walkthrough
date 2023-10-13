using UnityEngine;
using System.Collections;

public enum dialogueNames
{
    welcome = 0,topics = 1,controller = 2,familiar = 3,highlight = 4,balloonspawn = 5,ballonpop = 6,
    rotate = 7,table = 8,monitor = 9,basketball = 10,monsterball = 11,welldone = 12
}
public class ChibiDialogueAudio : MonoBehaviour
{
    public Sounds roboAudiosScribtableObject;
    public dialogueNames dialogue;
    public bool toPlay = true ;

    public int dialogueIndex = -1;
    public FlowManagerNew flowmanagerN;

    bool incrementCheck;
    private void Start()
    {
        StartCoroutine(DelaySound());
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            toPlay = true;
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            dialogueIndex++;
            toPlay = true;
        }
        //if(!SoundManager.instance.audioSource.isPlaying && dialogueIndex < 5)
        //{

        //    dialogueIndex++;
        //    toPlay = true;
        //}

        DialogueSwitchCases();
    }

    public void DialogueSwitchCases()
    {
        switch (dialogueIndex)
        {
            case 0:
              //  TriggerChibiDialogue("welcome");
                break;
            case 1:
             //   TriggerChibiDialogue("topics");
                break;
            case 2:
               // TriggerChibiDialogue("controller");
               // flowmanagerN.playerControllersLeft.SetActive(true);
              //  flowmanagerN.playerControllersRight.SetActive(true);
              //  flowmanagerN.questCanvasUi.SetActive(true);
                break;
            case 3:
                //TriggerChibiDialogue("familiar");
                incrementCheck = true;
                break;
            case 4:
               // TriggerChibiDialogue("highlight");
              //  if (incrementCheck) { GameManager.instance.index++; incrementCheck = false; }
                break;
            case 5:
                TriggerChibiDialogue("balloonspawn");

                break;
            case 6:
                TriggerChibiDialogue("ballonpop");
                break;
            case 7:
                TriggerChibiDialogue("rotate");
                break;
            case 8:
                TriggerChibiDialogue("table");
                break;
            case 9:
                TriggerChibiDialogue("monitor");
                break;
            case 10:
                TriggerChibiDialogue("basketball");
                break;
            case 11:
                TriggerChibiDialogue("monsterball");
                break;
            case 12:
                TriggerChibiDialogue("welldone");
                break;
            default:

                break;
        }
    }

    public void TriggerChibiDialogue(string dialoGueNames)
    {
        if (toPlay)
            StartCoroutine(PlayDialogue(dialoGueNames));
    }

    IEnumerator PlayDialogue(string dialoGueNames)
    {
        toPlay = false;
        SoundManager.instance.PlayAudio(roboAudiosScribtableObject.GetClip(dialoGueNames));
        yield return new WaitForSeconds(5);
        StopAllCoroutines();
    }

    IEnumerator DelaySound()
    {
        SoundManager.instance.PlayAudio(roboAudiosScribtableObject.GetClip("welcome"));
        yield return new WaitForSeconds(5f);
        SoundManager.instance.PlayAudio(roboAudiosScribtableObject.GetClip("topics"));
        yield return new WaitForSeconds(5f);
        SoundManager.instance.PlayAudio(roboAudiosScribtableObject.GetClip("controller"));
        flowmanagerN.playerControllersLeft.SetActive(true);
        flowmanagerN.playerControllersRight.SetActive(true);
        flowmanagerN.questCanvasUi.SetActive(true);
        yield return new WaitForSeconds(5f);
        SoundManager.instance.PlayAudio(roboAudiosScribtableObject.GetClip("familiar"));
        incrementCheck = true;
        yield return new WaitForSeconds(5f);
        SoundManager.instance.PlayAudio(roboAudiosScribtableObject.GetClip("highlight"));
        yield return new WaitForSeconds(2f);
        if (incrementCheck) { GameManager.instance.index++; incrementCheck = false; }
        dialogueIndex = 5;
        toPlay = true;

    }
}