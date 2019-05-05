using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController gc;
    public static GameStats gameStats;

    Text text;

    private void Awake()
    {
        if (gc == null)
        {
            DontDestroyOnLoad(gameObject);
            gc = this;
            gameStats = new GameStats();
        }
        else if (gc != this)
        {
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        NewGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (text == null)
        {
            text = GameObject.Find("HUDText").GetComponent<Text>();
        }
        string hudInfo = "";

        gameStats.gameTime += Time.deltaTime;

        hudInfo += "Level: " + (gameStats.level + 1) + "\n";
        hudInfo += "Score: " + gameStats.pickUps + "\n";
        hudInfo += "Time: " + gameStats.gameTime.ToString("F2");

        text.text = hudInfo;
    }

    void NewGame()
    {
        gameStats.level = 0;
        gameStats.pickUps = 0;
    }

    public void NextLevel()
    {
        gameStats.level = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(gameStats.level);
    }

    public void PreviousLevel()
    {
        gameStats.level = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(gameStats.level);
    }

    public void GetItem()
    {
        gameStats.pickUps += 1;
    }
}