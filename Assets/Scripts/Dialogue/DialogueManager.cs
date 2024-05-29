using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueNametext, dialogueSentenceText;
    public Queue<string> sentencesQueue = new Queue<string>();

    public void startDialogue(Dialogue dialogue){
        dialogueNametext.text = dialogue.dialogueName;
        sentencesQueue.Clear();
        foreach(string sentence in dialogue.sentences){
            sentencesQueue.Enqueue(sentence);
        }
        displayNextSentence();
    }

    public void displayNextSentence(){
        if(sentencesQueue.Count == 0){
            EndDialogue();
            return;
        }
        string sentence = sentencesQueue.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public IEnumerator TypeSentence(string text){
        dialogueSentenceText.text = "";
        foreach(char c in text.ToCharArray()){
            dialogueSentenceText.text += c;
            yield return new WaitForFixedUpdate();
        }
    }

    public void EndDialogue(){
        dialogueSentenceText.text = "dialogue Ended";
    }
}
