using CharContr.FinalCharacterController;
using UnityEngine;
using UnityEngine.InputSystem;


namespace CharContr.FinalCharacterController
{
    [DefaultExecutionOrder(-2)]
    public class PlayerLocomotionInput : MonoBehaviour, InputSystem_Actions.IPlayerActions
    {
        public InputSystem_Actions InputActions { get; private set; }
        public Vector2 MovementInput { get; private set; }
        public Vector2 LookInput { get; private set; }

        private void OnEnable()
        {
            InputActions = new InputSystem_Actions();
            InputActions.Enable();

            InputActions.Player.Enable();
            InputActions.Player.SetCallbacks(this);
        }

        private void OnDisable()
        {
            InputActions.Player.Disable();
            InputActions.Player.RemoveCallbacks(this);
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            MovementInput = context.ReadValue<Vector2>();
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            LookInput = context.ReadValue<Vector2>();
        }
    }
}

