public class BoxRobot : RobotsScrpt
{
     protected bool resFire = false;
     protected bool resMelee = true;
     protected bool resEnergy = false;
    override public void GetName(string ChosenRobostr)
    {
        EffectedRobo = this.gameObject.name;
        Hitted(ChosenRobostr, resFire, resMelee, resEnergy);
    }
}
