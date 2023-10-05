using UnityEngine;

public class RoboKyle : MonoBehaviour
{
    public Animator animator;
    public void AnimationControlling(string animName)
    {
        animator.Play(animName);
    }
}