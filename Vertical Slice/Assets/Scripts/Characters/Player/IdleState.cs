using NUnit.Framework.Interfaces;
using UnityEngine;

public class IdleState : PlayerBase
{
 

    public PlayerController player;


    public override void EnterState(PlayerController controller)
    {
        this.player = controller;


    }


    public override void UpdateState()
    {



    }
    public override void FixedUpdateState()
    {
        //  if (player.GetMovementInput().magnitude == 0)
        {
            player.rb.linearVelocity = Vector3.zero;


        }

        //   if (player.GetMovementInput().magnitude > 0)
        {
            player.stateMachine.changeState(new RunState());

        }
    }
    public override void ExitState() { }




}



