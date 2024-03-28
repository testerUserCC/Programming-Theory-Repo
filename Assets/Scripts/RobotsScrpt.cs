using TMPro;
using UnityEngine;

public class RobotsScrpt : MonoBehaviour
{
    public string EffectedRobo;
    public TextMeshProUGUI EffectedroboName;

    public void RoboClkChek()
    {
        
        if (ItemsToStoreScrpt.Instance.roboName != null)
        {
            EffectedRobo = ItemsToStoreScrpt.Instance.roboName;
            GetName(EffectedRobo);
        }
    }
    public virtual void GetName(string ChosenRobostr)
    {

    }

    public virtual void Hitted(string ATRobo, bool resFire,bool resMelee, bool resEnergy)
    {
        if ((ATRobo == "Fire") && resFire)
        {
            Isdead(ATRobo);
        }
        else if ((ATRobo == "Melee") && resMelee)
        {
            Isdead(ATRobo);
        }
        else if ((ATRobo == "Energy") && resEnergy)
        {
            Isdead(ATRobo);
        }
        else
        {
            IsAlive(ATRobo);
        }
    }
    public virtual void Isdead(string ATRoboDamage)
    {
        this.gameObject.SetActive(false);
        EffectedroboName = GameObject.Find("Canvas").transform.Find($"{EffectedRobo}Txt").GetComponent<TextMeshProUGUI>();
        EffectedroboName.SetText($"Hit by {ATRoboDamage} Robot");
    }
    public virtual void IsAlive(string ATRoboBlocked)
    {
        this.gameObject.SetActive(true);
        EffectedroboName = GameObject.Find("Canvas").transform.Find($"{EffectedRobo}Txt").GetComponent<TextMeshProUGUI>();
        EffectedroboName.SetText($"Resistance to {ATRoboBlocked}");
    }
}
