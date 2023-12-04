using UnityEngine;

public class ColliderToggle : MonoBehaviour
{
    public GameObject objectToToggle; // Assign the GameObject to be toggled in the Inspector

    private void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch is on UI element (optional)
            if (touch.phase == TouchPhase.Began && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            {
                ToggleCollider();
            }
        }
    }

    private void ToggleCollider()
    {
        // Check if the object to toggle is not null
        if (objectToToggle != null)
        {
            // Toggle the Box Collider component
            Collider collider = objectToToggle.GetComponent<Collider>();

            if (collider != null)
            {
                collider.enabled = !collider.enabled;
            }
            else
            {
                Debug.LogError("The specified GameObject does not have a Collider component.");
            }
        }
        else
        {
            Debug.LogError("Please assign the GameObject to be toggled in the Inspector.");
        }
    }
}