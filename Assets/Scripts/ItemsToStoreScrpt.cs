using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.IO;
using UnityEngine;

public class ItemsToStoreScrpt : MonoBehaviour
{
    public static ItemsToStoreScrpt Instance;   // Create an Instance to ItemsToStoreScrpt
    public TextMeshProUGUI nameKeeper;          // To use it to display the name on
    public string playerName;                   // The string to save the name temporarily 
    private void Awake()                        // Check if the instance is there
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string ThePlayerName;
    }
    public void SavePlayerName(string pName)    // This save the player name during session
    {
        playerName = pName;
    }
    public void FillTheName()                   // Set playerName input to the TextMeshProUGUI named HeaderTxt
    {
        nameKeeper = GameObject.Find("Canvas").transform.Find("HeaderTxt").GetComponent<TextMeshProUGUI>();
        nameKeeper.SetText($"{playerName}. Choose");
    }
}