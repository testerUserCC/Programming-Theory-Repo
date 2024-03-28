using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneScrpt : MonoBehaviour
{

    void Start()
    {
        ItemsToStoreScrpt.Instance.FillTheName();   // Call the method FillTheName
    }

    public void BackToMM()                          // To get back to Main menu when activeted
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()                          // To get back to Main menu when activeted
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()                              // To exit the application when activeted
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}