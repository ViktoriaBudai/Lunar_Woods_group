using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public Animator characterAnimator;

    [SerializeField] private List<dialogueString> dialogueStrings = new List<dialogueString>();
    [SerializeField] private Transform NPCTransform;

    private bool hasSpoken = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !hasSpoken)
        {
            other.gameObject.GetComponent<DialogueManager>().DialogueStart(dialogueStrings, NPCTransform);
            hasSpoken = true;

            // Play idle animation
            characterAnimator.SetBool("IsInDialog", true);
            Debug.Log("OnTriggerEnter called");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasSpoken = false;
            Debug.Log("OnTriggerExit called");

            // Set boolean parameter to exit idle animation
            characterAnimator.SetBool("IsInDialog", false);
        }
    }


}

[System.Serializable]

public class dialogueString
{
    //Represent the text that the NPC says
    public string text;
    //Represent if the line is the final line for the conversation
    public bool isEnd;

    [Header("Branch")]
    public bool isQuestion;
    public string answerOption1;
    public string answerOption2;
    public int option1IndexJump;
    public int option2IndexJump;

    [Header("Triggered Events")]
    public UnityEvent startDialogueEvent;
    public UnityEvent endDialogueEvent;
}
