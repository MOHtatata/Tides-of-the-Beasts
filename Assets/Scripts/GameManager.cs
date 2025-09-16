using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : IntEventInvoker
{
    [SerializeField]
    GameObject enemySpawner;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject[] islands;
    [SerializeField]
    GameObject tutorial;
    [SerializeField]
    GameObject endGamePanel;
    [SerializeField]
    GameObject winGamePanel;

    public Sprite[] tutorialSprites;
    public Image image;
    public int tutorialCount;

    [TextArea(2, 10)]
    public string[] sentences;
    public TextMeshProUGUI text;
    public TextMeshProUGUI countText;

    int t;

    public void Start()
    {
        EventManager.AddListener(EventName.QuestDoneEvent, QuestDoneEventHandler);

        EventManager.AddListener(EventName.EndGameEvent, EndGameEventHandler);

        unityEvents.Add(EventName.MobileInputEvent, new MobileInputEvent());
        EventManager.AddInvoker(EventName.MobileInputEvent, this);

        unityEvents.Add(EventName.CameraTargetEvent, new CameraTargetEvent());
        EventManager.AddInvoker(EventName.CameraTargetEvent, this);

        Tutorial();
    }
    public void QuestDoneEventHandler(int value)
    {
        GameObject obj = Instantiate(enemySpawner) as GameObject;
        obj.transform.position = new Vector3(0, 0, 0);

        Vector2 position = islands[value].transform.position;

        GameObject tempIsland = Instantiate(islands[value]) as GameObject;
        BoxCollider2D collider = tempIsland.GetComponent<BoxCollider2D>();
        float x = collider.size.x / 2;
        float y = collider.size.y;
        Destroy(tempIsland);

        GameObject playerObj = Instantiate(player) as GameObject;
        playerObj.transform.position = new Vector2(position.x, position.y + y);
        unityEvents[EventName.CameraTargetEvent].Invoke(t);
    }
    public void NextButton()
    {
        AudioManager.Play(AudioClipName.ButtonClick);
        if (tutorialCount >= 9)
            StartingGame();
        else
            Tutorial();
    }
    public void Tutorial()
    {
        image.sprite = tutorialSprites[tutorialCount];
        text.text = sentences[tutorialCount];
        countText.text = tutorialCount.ToString();
        tutorialCount++;
    }
    public void SkipButton()
    {
        AudioManager.Play(AudioClipName.ButtonClick);
        StartingGame();
    }
    public void StartingGame()
    {
        tutorial.SetActive(false);

        GameObject obj = Instantiate(enemySpawner) as GameObject;
        obj.transform.position = new Vector3(0, 0, 0);

        GameObject playerObj = Instantiate(player) as GameObject;
        playerObj.transform.position = new Vector3(0,0,0);

        unityEvents[EventName.CameraTargetEvent].Invoke(t);
    }
    public void ButtonToMainMenue()
    {
        AudioManager.Play(AudioClipName.ButtonClick);
        SceneManager.LoadScene("MainScreen");
    }
    public void LeftCannonFire()
    {
        t = 0;
        unityEvents[EventName.MobileInputEvent].Invoke(t);
    }
    public void RightCannonFire()
    {
        t = 1;
        unityEvents[EventName.MobileInputEvent].Invoke(t);
    }
    public void EndGameEventHandler(int value)
    {
        DestroyAllEnemy();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Destroy(player);
        if(value== 0)
           endGamePanel.SetActive(true);
        else
            winGamePanel.SetActive(true);
    }
    public void DestroyAllEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
}
