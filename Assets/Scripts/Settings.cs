using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Button DreizigFPSButton;
    public Button SechzigFPSButton;
    public Button HunderzwanzigFPSButton;
    public Button ZweihundertvierzigFPSButton;
    public Button UnendlichFPSButton;
    void Start()
    {

        DreizigFPSButton.onClick.AddListener(() => DreizigFPS());
        SechzigFPSButton.onClick.AddListener(() => SechzigFPS());
        HunderzwanzigFPSButton.onClick.AddListener(() => HunderzwanzigFPS());
        ZweihundertvierzigFPSButton.onClick.AddListener(() => ZweihundertvierzigFPS());
        UnendlichFPSButton.onClick.AddListener(() => UnendlichFPS());
    }

    void DreizigFPS()
    {
        Save(30);
    }

    void SechzigFPS()
    {
        Save(60);
    }

    void HunderzwanzigFPS()
    {
        Save(120);
    }

    void ZweihundertvierzigFPS()
    {
        Save(240);
    }

    void UnendlichFPS()
    {
        Save(-1);
    }

    void Save(int FPS)
    {
        Application.targetFrameRate = FPS;
        PlayerPrefs.SetInt("FrameRate", FPS);
        PlayerPrefs.Save();
        Debug.Log(FPS + " FPS");
    }
}