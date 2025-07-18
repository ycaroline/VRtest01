using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MenueScene"); // ← Name der Zielszene!
    }
}
