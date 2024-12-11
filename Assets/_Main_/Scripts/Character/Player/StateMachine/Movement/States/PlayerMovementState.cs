using Game.GenericStateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Player
{
    public class PlayerMovementState : IState
    {
        protected PlayerMovementStateMachine stateMachine;

        public PlayerMovementState(PlayerMovementStateMachine _stateMachine)
        {
            stateMachine = _stateMachine;
        }

        #region IState Methods
        public void Enter()
        {
            throw new System.NotImplementedException();
        }

        public void Exit()
        {
            throw new System.NotImplementedException();
        }

        public void PhysicsUpdate()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void HandleInput()
        {
            throw new System.NotImplementedException();
        }

        public void OnAnimationEnterEvent()
        {
            throw new System.NotImplementedException();
        }

        public void OnAnimationExitEvent()
        {
            throw new System.NotImplementedException();
        }

        public void OnAnimationTransitionEvent()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
