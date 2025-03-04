using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMenü : MonoBehaviour
{
    public Button GameButton;

    void Start()
    {
        if (GameButton != null)
        {
            GameButton.onClick.AddListener(OpenGame);
        }
        else
        {
            Debug.LogError("GameButton not found on this GameObject.");
        }
    }

    void OpenGame()
    {
        Debug.Log("GameButton clicked");
        SceneManager.LoadScene(0);
    }
}