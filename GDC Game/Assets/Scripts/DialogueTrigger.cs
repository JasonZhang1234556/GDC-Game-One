using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueTwo dialogue;

    public void TriggerDialogue(){
        FindObjectOfType<Dialogue>().StartDialogue(dialogue);
    }
    
}
