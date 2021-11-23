using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    public Queue<string> sentenses;

    void Start(){
        sentenses = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartDialogue(DialogueTwo dialogue){
        nameText.text = dialogue.name;
        sentenses.Clear();
        foreach (string sentense in dialogue.strings){
            sentenses.Enqueue(sentense);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if (sentenses.Count == 0){
            EndDialogue();
            return;
        }

        string sentence = sentenses.Dequeue();
        Debug.Log(sentence);
        dialogueText.text = sentence;
    }

    void EndDialogue(){
        Debug.Log("End of Conversation.");
    }

}
