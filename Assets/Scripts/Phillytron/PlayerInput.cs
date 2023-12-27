using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Phillytron
{
    [CreateAssetMenu(fileName = "PlayerInput", menuName = "Phillytron/PlayerInput")]
    public class PlayerInput : ScriptableObject
    {
        //up on the joystick
        public KeyCode up;

        //down on the joystick
        public KeyCode down;

        //left on the joystick
        public KeyCode left;

        //right on the joystick
        public KeyCode right;
        
        public KeyCode blueButton;
        public KeyCode purpleButton;
        public KeyCode greenButton;
    }
}