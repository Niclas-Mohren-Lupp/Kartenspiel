using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneEinstellungen : MonoBehaviour
{
    public Button SettingsButton;

    void Start()
    {
        if (SettingsButton != null)
        {
            SettingsButton.onClick.AddListener(OpenSettings);
        }
        else
        {
            Debug.LogError("SettingsButton not found on this GameObject.");
        }
    }

    void OpenSettings()
    {
        Debug.Log("SettingsButton clicked");
        SceneManager.LoadScene(1);
    }
}
