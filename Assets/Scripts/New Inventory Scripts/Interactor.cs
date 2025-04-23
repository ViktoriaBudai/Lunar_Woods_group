using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public interface IInteractable
{
    void Interact();

}

public class Interactor : MonoBehaviour
{

    public Transform InteractorSource;
    public float InteractRange;
    public LayerMask interactableLayer;

    // create a list to store interactable object
    private List<IInteractable> inventory = new List<IInteractable>();


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckInteracte();
        }

    }

    private void CheckInteracte()
    {
        // Start a new interaction

        Collider[] colliders = Physics.OverlapSphere(InteractorSource.position, InteractRange, interactableLayer);
        foreach (Collider collider in colliders)
        {

            if (collider.TryGetComponent<IInteractable>(out var interctObj))
            {
                // check if the interctable object is within the specified range
                float distance = Vector3.Distance(InteractorSource.position, collider.transform.position);
                if (distance <= InteractRange && !inventory.Contains(interctObj))
                {
                    interctObj.Interact();
                    inventory.Add(interctObj);
                }
            }
        }
    }

}
