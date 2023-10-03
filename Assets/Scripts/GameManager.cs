using UnityEngine;
public class GameManager : MonoBehaviour
{
    #region GAMEMANAGER Instance
    public static GameManager instance; void Awake() { instance = this; }
    #endregion

    public int index;
    public bool noButtonDown;
    public Material questDefault, highlighter;
    public Color color;

    public void MaterialSwitcher(MeshRenderer ButtonReference, Color hilightedColour)
    {
        ButtonReference.material = highlighter; highlighter.color = hilightedColour;
    }
    public void MaterialResetter(MeshRenderer ButtonReference) { ButtonReference.material = questDefault; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            foreach (MeshRenderer item in ButtonsMesh.instance.handControllerMesh)
            {
                MaterialResetter(item);
            }
            index++;
        }
        switch (index)
        {
            // For Button A and X
            case 1:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[0], color);
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[5], color);
                break;
            // For Button B and Y
            case 2:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[1], color);
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[6], color);
                break;
            // For Right Joystick
            case 3:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[4], color);
                break;
            // For Left Joystick
            case 4:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[9], color);
                break;
            // Right Trigger
            case 5:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[2], color);
                break;
            // Left Trigger
            case 6:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[7], color);
                break;
            // Right Grip
            case 7:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[3], color);
                break;
            // Left Grip
            case 8:
                MaterialSwitcher(ButtonsMesh.instance.handControllerMesh[8], color);
                break;

            default:

                break;
        }
    }

    public void ValidatteMyClick(string buttonName)
    {
        print(buttonName);
    }

    public void SetIndex(int indexValue)
    {
        index = indexValue;
    }

}