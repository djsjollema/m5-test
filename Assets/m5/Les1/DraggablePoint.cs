using UnityEngine;
using UnityEngine.InputSystem;

public class DraggablePoint : MonoBehaviour
{
    [SerializeField] InputActionReference pointAction;
    [SerializeField] InputActionReference pressAction;
    private bool isDragging = false;
    void Start()
    {

    }

    private void OnEnable()
    {
        pointAction.action.Enable();
        pressAction.action.Enable();

        pressAction.action.started += OnPress;
        pressAction.action.canceled += OnRelease;

    }

    private void OnDisable()
    {
        pressAction.action.started -= OnPress;
        pressAction.action.canceled -= OnRelease;

        pointAction.action.Disable();
        pressAction.action.Disable();
    }

    void Update()
    {
        if (!isDragging)
        {
            return;
        }

        Vector2 screenPos = pointAction.action.ReadValue<Vector2>();
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(screenPos.x, screenPos.y, 0));
        worldPos.z = 0;
        transform.position = worldPos;

    }

    private void OnPress(InputAction.CallbackContext context)
    {
        Vector2 screenPos = pointAction.action.ReadValue<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(screenPos.x, screenPos.y, 0));

        Collider2D hit = Physics2D.OverlapPoint(worldPos);

        if(hit != null && hit.gameObject == gameObject)
        {
            isDragging = true;
        }
    }

    private void OnRelease(InputAction.CallbackContext context)
    {
        isDragging = false;
    }
}
