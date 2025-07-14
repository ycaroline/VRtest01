using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject welcomePanel;
    public GameObject introPanel; // später noch hinzufügen
    public GameObject mainScenePanel; // später noch hinzufügen

    public void OnIntroClicked()
    {
        welcomePanel.SetActive(false);
        introPanel.SetActive(true); // vorausgesetzt du baust das später
    }

    public void OnSkipIntroClicked()
    {
        welcomePanel.SetActive(false);
        mainScenePanel.SetActive(true); // vorausgesetzt du baust das später
    }
}
