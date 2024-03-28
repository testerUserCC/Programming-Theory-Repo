using UnityEngine;

public class RobotManager : MonoBehaviour
{
    public string roboName;
    public void MyRobotName()
    {
        ItemsToStoreScrpt.Instance.FillRoboName(roboName);
    }
}
