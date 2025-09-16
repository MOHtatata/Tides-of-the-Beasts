using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    private GameObject _obj;
    public void StartDialogue()
    {
        _obj.transform.position = new Vector2( 0, Mathf.Lerp(transform.position.y, -415, 0));
    }
    public void EndDialogue()
    {
        _obj.transform.position = new Vector2(0, Mathf.Lerp(transform.position.y, -665, 0));
    }
    public void SpeakingAnimation(Animator anim)
    {
        anim.SetTrigger("isSpeaking");
    }
    public void SpeakingComplete(Animator anim)
    {
        anim.SetTrigger("isStopSpeaking");
    }
}
