using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHands : MonoBehaviour
{
    // * * *
    // Variables related to input actions anbd animation
    [SerializeField] private InputActionProperty _pinchAction;
    [SerializeField] private InputActionReference _gripAction;
    [SerializeField] private Animator _animator;

    private void Update()
    {
        // Allow to read the controllers value 
        float triggerVal = _pinchAction.action.ReadValue<float>();
        float gripVal = _gripAction.action.ReadValue<float>();

        // We set the values for the animator
        _animator.SetFloat("Trigger", triggerVal);
        _animator.SetFloat("Grip", gripVal);
    }
}
