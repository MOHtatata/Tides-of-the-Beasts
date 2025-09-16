using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPlayButtonClick()
    {
        AudioManager.Play(AudioClipName.ButtonClick);
        SceneManager.LoadScene("SampleScene");
    }
}
