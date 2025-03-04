using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public Button MenüButton;
    public Button HomeButton;


    void Start()
    {
        MenüButton.onClick.AddListener(OpenMenü);
        HomeButton.onClick.AddListener(OpenHome);
    }

    void OpenMenü()
    {
        Debug.Log("MenüButton clicked");
        SceneManager.LoadScene(0);
    }

    void OpenHome()
    {
        Debug.Log("MenüButton clicked");
        SceneManager.LoadScene(2);
    }
}