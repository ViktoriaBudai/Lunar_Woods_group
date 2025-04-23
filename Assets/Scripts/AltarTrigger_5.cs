using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class AltarTrigger_5 : MonoBehaviour
{
    public GameObject winScreen; // Reference to the win screen UI

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<ThirdPersonController>().HasItem)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        // Show win screen
        winScreen.SetActive(true);
    }
}
