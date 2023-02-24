using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public GameManager gameManager;

    public GameObject image;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " points";
    }

    #region Update
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    private void Replay()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameManager.Start();
            image.SetActive(false);
        }
    }

    #endregion
}
