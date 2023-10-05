using UnityEngine;

public class BasketballController : MonoBehaviour
{
    public ParticleSystem confetti;
    TMPro.TextMeshPro scoreText;
    int score;
    void Start()
    {
        scoreText = GetComponentInChildren<TMPro.TextMeshPro>();
    }
    void OnTriggerExit(Collider col)
    {
        if(col.name == "Ball")
        {
            confetti.Play();
            score++;
            scoreText.text = "Score : " + score.ToString();
        }
    }
}
