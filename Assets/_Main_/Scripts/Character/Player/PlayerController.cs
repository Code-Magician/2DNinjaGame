using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Player
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovementStateMachine movementStateMachine;

        private void Start()
        {
            movementStateMachine = new PlayerMovementStateMachine(this);
        }

        private void Update()
        {
            movementStateMachine.HandleInput();
            movementStateMachine.Update();
        }

        private void LateUpdate()
        {
            movementStateMachine.PhysicsUpdate();
        }

        public void OnMovementStateAnimationEnterEvent()
        {
            movementStateMachine.OnAnimationEnterEvent();
        }

        public void OnMovementStateAnimationTransitionEvent()
        {
            movementStateMachine.OnAnimationTransitionEvent();
        }

        public void OnMovementStateAnimationExitEvent()
        {
            movementStateMachine.OnAnimationExitEvent();
        }
    }
}
