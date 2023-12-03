using UnityEngine;

public class ToggleColliderOnButtonClick : MonoBehaviour
{
    public GameObject objectToToggle; // Public variable to set in the Unity Editor
    private BoxCollider boxCollider;

    private void Start()
    {
        if (objectToToggle == null)
        {
            Debug.LogError("Please assign a GameObject to the 'Object To Toggle' field in the Unity Editor.");
            return;
        }

        // Assuming the BoxCollider is attached to the specified GameObject.
        boxCollider = objectToToggle.GetComponent<BoxCollider>();

        // Make sure boxCollider is not null, and disable it initially.
        if (boxCollider != null)
        {
            boxCollider.enabled = false;
        }
        else
        {
            Debug.LogError("BoxCollider not found on the specified GameObject.");
        }
    }

    private void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch phase is Began
            if (touch.phase == TouchPhase.Began)
            {
                // Toggle the box collider
                ToggleBoxCollider();
            }
        }
    }

    private void ToggleBoxCollider()
    {
        // Toggle the state of the box collider
        if (boxCollider != null)
        {
            boxCollider.enabled = !boxCollider.enabled;

            // Print the current state to the console (optional)
            Debug.Log("Box Collider Enabled: " + boxCollider.enabled);
        }
        else
        {
            Debug.LogError("BoxCollider not found on the specified GameObject.");
        }
    }
}