using TMPro;
using UnityEngine;

public class ItemsToStoreScrpt : MonoBehaviour
{
    public static ItemsToStoreScrpt Instance;   // Create an Instance to ItemsToStoreScrpt
    public TextMeshProUGUI roboNameKeeper;
    public TextMeshProUGUI nameKeeper;          // To use it to display the name on
    public string playerName;                   // The string to save the name temporarily 
    public string roboName;                   // The string to save the name temporarily 
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

    public void SavePlayerName(string pName)    // This save the player name during session
    {
        playerName = pName;
    }
    public void FillTheName()                   // Set playerName input to the TextMeshProUGUI named HeaderTxt
    {
        nameKeeper = GameObject.Find("Canvas").transform.Find("HeaderTxt").GetComponent<TextMeshProUGUI>();
        nameKeeper.SetText($"{playerName}. Choose");
    }
    public void FillRoboName(string rName)
    {
        roboNameKeeper = GameObject.Find("Canvas").transform.Find("ChosedText").GetComponent<TextMeshProUGUI>();
        roboNameKeeper.SetText($"you Chose {rName} Robot");
        roboName = rName;
        GameObject[] allObjects = Object.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            // Check if the GameObject has a RobotsScript component
            if (obj.GetComponent<RobotsScrpt>() != null)
            {
                // Get all child scripts of type RobotsScript
                RobotsScrpt[] childScripts = obj.GetComponentsInChildren<RobotsScrpt>();

                // If there are any child scripts, print the name of the GameObject
                if (childScripts.Length > 0)
                {
                    Debug.Log("GameObject " + obj.name + " has a child script of RobotsScript");
                }
                foreach (RobotsScrpt script in childScripts)
                {
                    script.GetName(rName);
                }
            }
        }        
    }
}