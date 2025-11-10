using UnityEngine;
using UnityEngine.InputSystem;

public class disappearing : MonoBehaviour
{
   // [SerializeField]
    [Tooltip("The button for the dragon to disappear.")]
    public InputAction toggleAction = new InputAction(type: InputActionType.Button);

    private Renderer objectRenderer;

    void OnEnable()
    {
        // Enable the toggle action and subscribe to the performed event
        //toggleAction.Enable();
        //toggleAction.performed += OnToggleVisibility;
        toggleAction.AddBinding("<Pointer>/press"); 
        toggleAction.Enable();
        toggleAction.performed += OnToggleVisibility;
    }

    void OnDisable()
    {
        // Unsubscribe from the performed event and disable the toggle action
        toggleAction.performed -= OnToggleVisibility;
        toggleAction.Disable();
    }

    void Start()
    {
        // Get the Renderer component
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("Renderer component is missing!");
        }
    }

    private void OnToggleVisibility(InputAction.CallbackContext context)
    {
        // Toggle the visibility of the object
        if (objectRenderer != null)
        {
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }
}
