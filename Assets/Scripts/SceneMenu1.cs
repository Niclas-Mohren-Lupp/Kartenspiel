using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMenu1 : MonoBehaviour
{
    public Button MenüButton;

    void Start()
    {
        MenüButton.onClick.AddListener(OpenMenü);
    }

    void OpenMenü()
    {
        Debug.Log("MenüButton clicked");
        SceneManager.LoadScene(0);
    }
}