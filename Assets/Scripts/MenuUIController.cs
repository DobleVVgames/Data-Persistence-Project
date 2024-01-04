using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIController : MonoBehaviour
{
    public TMP_InputField nameOfPlayer;

    public static MenuUIController Instance;

    void Awake()
    {
        

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(nameOfPlayer);
                    
    }


    public void StarButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {        

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }

    

}


