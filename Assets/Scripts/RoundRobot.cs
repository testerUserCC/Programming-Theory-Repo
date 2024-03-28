public class RoundRobot : RobotsScrpt
{
    protected bool resFire = true;
    protected bool resMelee = false;
    protected bool resEnergy = false;

    override public void GetName(string ChosenRobostr)
    {
        EffectedRobo = this.gameObject.name;
        Hitted(ChosenRobostr, resFire, resMelee, resEnergy);
    }
}
