using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;
    public Queue<TestCharacter> characters;
    public Queue<Animator> animations;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (TestCharacter character in dialogue.characters)
        {
            characters.Enqueue(character);
        }
        foreach (Animator animation in dialogue.animations)
        {
            animations.Enqueue(animation);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        TestCharacter previosCharacter = characters.Peek();
        if (sentences.Count == 0)
        {
            EndDialogue(previosCharacter);
        }
        TestCharacter character = characters.Dequeue();
        Animator animation = animations.Dequeue();
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence, character, animation));
    }
    public IEnumerator TypeSentence(string sentence, TestCharacter character, Animator animation)
    {
        character.StartDialogue();
        character.SpeakingAnimation(animation);
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.06f);
        }
        character.SpeakingComplete(animation);
    }
    public void EndSentenceAnimation()
    {

    }
    public void EndDialogue(TestCharacter character)
    {
        character.EndDialogue();
    }
}

