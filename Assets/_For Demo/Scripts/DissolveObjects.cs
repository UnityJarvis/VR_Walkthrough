using UnityEngine;

public class DissolveObjects : MonoBehaviour
{
    public Renderer[] render;
    public Material[] mat;
    private void Start()
    {
        render = GetComponentsInChildren<Renderer>();

        mat = new Material[render.Length];
        for (int i = 0; i < render.Length; i++)
        {
            mat[i] = render[i].material;
        }
        DissolveManager.instance.ResetDissolve(mat);
    }
    private void Update()
    {
        DissolveUI();
        if (Input.GetKey(KeyCode.H))
        {
            DissolveManager.instance.Dissolve(mat);
        }
        if (Input.GetKey(KeyCode.J))
        {
            DissolveManager.instance.UnDissolve(mat);
        }
    }

    public GameObject monitorCanvas;
    public void DissolveUI()
    {
        if (monitorCanvas != null)
        {
            if (mat[1].GetFloat("_Dissolve") > 0.5f)
            {
                monitorCanvas.SetActive(false);
            }
            if (mat[1].GetFloat("_Dissolve") < 0.4f)
            {
                monitorCanvas.SetActive(true);
            }
        }
    }
}