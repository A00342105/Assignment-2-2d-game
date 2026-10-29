using UnityEngine;
using UnityEngine.InputSystem;

public class interactiondetector : MonoBehaviour
{

    private IInteractable interactablerange = null;
    public GameObject interaction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interaction.SetActive(false);
    }

    public void Oninteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            interactablerange?.interact();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteractable interactable) && interactable.caninteract())
        {
            interactablerange = interactable;
            interaction.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteractable interactable) && interactable == interactablerange)
        {
            interactablerange = null;
            interaction.SetActive(false);
        }
    }
}
