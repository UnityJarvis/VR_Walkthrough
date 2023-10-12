using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    int i = 0;
    public ChibiDialogueAudio chibiDialogueAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if(i == 0)
        if (collision.collider.tag == "PokeBall")
        {
            chibiDialogueAudio.dialogueIndex = 12;
            i = 1;
        }
    }
}
