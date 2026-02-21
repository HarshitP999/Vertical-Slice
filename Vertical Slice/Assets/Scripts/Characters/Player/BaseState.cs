

public abstract class PlayerBase
{
    public abstract void EnterState(PlayerController controller);
    public abstract void UpdateState();
    public abstract void FixedUpdateState();
    public abstract void ExitState();

}
