using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.GenericStateMachine;

namespace Game.Player
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public PlayerController controller;

        public PlayerMovementStateMachine(PlayerController _controller)
        {
            controller = _controller;
        }
    }
}
