using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject mainMenu;
    public GameObject loadGame;
    public GameObject gameOver;
    public GameObject scoreUI;

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void ShowStart()
    {
        mainMenu.SetActive(true);
        loadGame.SetActive(false);
        gameOver.SetActive(false);
        scoreUI.SetActive(false);
    }

    public void HideStart()
    {
        mainMenu.SetActive(false);
    }

    public void ShowReady()
    {
        mainMenu.SetActive(false);
        loadGame.SetActive(true);
        gameOver.SetActive(false);
    }

    public void HideReady()
    {
        loadGame.SetActive(false);
        scoreUI.SetActive(true);
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }


}
