using UnityEngine;

public class DissolveManager : MonoBehaviour
{
    public static DissolveManager instance;
    private void Awake() { instance = this; }

    public float value;
    public void Dissolve(Material[] render)
    {
        value += 0.002f;
        foreach (Material mat in render)
        {
            mat.SetFloat("_Dissolve", value);
        }
    }

    public void UnDissolve(Material[] render)
    {
        value -= 0.002f;
        foreach (Material mat in render)
        {
            mat.SetFloat("_Dissolve", value);
        }
    }

    public void ResetDissolve(Material[] render)
    {
        foreach (Material mat in render)
        {
            mat.SetFloat("_Dissolve", 0);
        }
    }

   
}