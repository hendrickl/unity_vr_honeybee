using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    [SerializeField] InputActionReference _menuAction; // The InputActionReference to enable and listen for.
    [SerializeField] GameObject _menu;

    private void Start()
    {
        _menuAction.action.Enable();

        // Subscribe to the performed event of the menu action.
        _menuAction.action.performed += DisplayMenu;
    }

    private void DisplayMenu(InputAction.CallbackContext obj)
    {
        if (_menu.activeSelf)
        {
            _menu.SetActive(false);
        }
        else
        {
            _menu.SetActive(true);
        }
    }
}
