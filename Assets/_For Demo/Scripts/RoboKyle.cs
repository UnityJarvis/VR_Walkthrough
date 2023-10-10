using UnityEngine;
public class RoboKyle : MonoBehaviour
{
    public Texture2D[] emojis;
    public Renderer faceRender;
    public Material faceMaterial;
    public Animator animator;

    private void Start()
    {
        faceMaterial = faceRender.material;
    }
    public void AnimateRobo(string animName)
    {
        animator.Play(animName);
    }
    public void SetEmoji(Texture2D emoji)
    {
        faceMaterial.SetTexture("_BaseMap", emoji);
    }

    public enum RoboState
    {
        idle, talk, move
    }
    public RoboState roboState;


    private void Update()
    {
        switch (roboState)
        {
            case RoboState.idle:
                AnimateRobo("idle");
                SetEmoji(emojis[0]);
                break;
            case RoboState.talk:
                AnimateRobo("talk");
                SetEmoji(emojis[1]);
                break;
            case RoboState.move:
                AnimateRobo("move");
                SetEmoji(emojis[2]);
                break;
            default:
                break;
        }
    }
}