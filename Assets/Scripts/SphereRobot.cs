public class SphereRobot : RobotsScrpt
{
    protected bool resFire = false;
    protected bool resMelee = false;
    protected bool resEnergy = true;
    override public void GetName(string ChosenRobostr)
    {
        EffectedRobo = this.gameObject.name;
        Hitted(ChosenRobostr, resFire, resMelee, resEnergy);
    }
}
