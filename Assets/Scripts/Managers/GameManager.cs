using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region GAMEMANAGER Instance
    public static GameManager instance;
    
    void Awake()
    {
        instance = this;
    }
    #endregion

    public Canvas mainCanvas;
    
}
