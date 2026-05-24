using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public GameObject gameclearText;
    public Text timeText;

    float surviveTime;
    bool isGameover;

    void Start()
    {
        surviveTime = 0f;
        isGameover = false;
    }

    void Update()
    {
        if(!isGameover )
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);
    }

    public void ClearGame()
    {
        isGameover = true;
        gameclearText.SetActive(true);
    }
}
