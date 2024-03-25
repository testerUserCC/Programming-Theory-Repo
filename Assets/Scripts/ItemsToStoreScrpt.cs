using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.IO;
using UnityEngine;

public class ItemsToStoreScrpt : MonoBehaviour
{
    public static ItemsToStoreScrpt Instance;
    //To display the name on
    public TextMeshProUGUI nameKeeper;
    //the string to save the name temporarily 
    public string playerName;
    // check if the instance is there
    private void Awake()
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
    // this save the player name during session
    public void SavePlayerName(string pName)
    {
        playerName = pName;
    }
}