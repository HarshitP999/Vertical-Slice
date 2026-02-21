public class StateMachine
{
    public PlayerController controller;

    public PlayerBase currentState;

    public void Initialize(PlayerController controller)
    {
        this.controller = controller;
        currentState = new IdleState();
        currentState.EnterState(controller);

    }
    public void Update()
    {
        currentState.UpdateState();

    }

    public void FixUpdateState()
    {

        currentState.FixedUpdateState();
    }

    public void changeState(PlayerBase newState)
    {
        currentState.ExitState();
        currentState = newState;
        currentState.EnterState(controller);

    }

}
