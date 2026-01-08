using UnityEngine;

public class Interazione : MonoBehaviour
{
    public float interactionDistance = 3.0f;
    public LayerMask interactLayers;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            MovimentoPorte door = hit.collider.GetComponentInParent<MovimentoPorte>();
            if (door != null)
            {
                door.ToggleDoor();
                Debug.Log("porta portata");
            }
        }
    }
}