using UnityEngine;

public class RunState : PlayerBase
{
    public PlayerController player;

    public override void EnterState(PlayerController controller)
    {

        this.player = controller;

    }

    public override void UpdateState()
    {


        if (!player.isMoving)
        {
            player.stateMachine.changeState(new IdleState());
        }


    }
    public override void FixedUpdateState()
    {


        {
            Debug.Log("Moving Key running");
            //   MovePlayer();
        }

        {
            //  if (player.GetMovementInput().magnitude <= 0)

            {
                Debug.Log("Moving Key idl");

                player.isMoving = false;
                player.stateMachine.changeState(new IdleState());
            }
        }
    }
    public override void ExitState()
    {


    }

    /*  private void MovePlayer()
      {

          Vector2 moveAmt = player.GetMovementInput();

          Vector3 moveDirection = new Vector3(moveAmt.x, 0, moveAmt.y);
          player.rb.linearVelocity = moveDirection * player.MoveSpeed;

          if (moveDirection != Vector3.zero)
          {
              player.isMoving = true;

              Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
              player.transform.rotation = Quaternion.Slerp(player.transform.rotation, targetRotation, player.RotateSpeed * Time.deltaTime);
          }

      }*/
}
