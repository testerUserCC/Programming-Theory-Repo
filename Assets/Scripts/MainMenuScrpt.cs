using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScrpt : MonoBehaviour
{
    public TMP_InputField inputname;
    public string playerName;
    public void StartNew()
    {
        playerName = inputname.text;
        ItemsToStoreScrpt.Instance.SavePlayerName(playerName);
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
