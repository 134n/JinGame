using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Drawing;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI totalPointText;
    [SerializeField] private TextMeshProUGUI gameClearText;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject itemGenarator;

    public void PointText(int point)
    {
        totalPointText.text = "Point:" + point;
        if (point >= 10)
        {
            GameClear();
        }
    }
    public void GameClear()
    {
        gameClearText.gameObject.SetActive(true);
        player.SetActive(false);
        itemGenarator.SetActive(false);
    }

    public void MainMenuClick()
    {
        SceneManager.LoadScene("Title");
    }

    public void ReStartClick()
    {
        SceneManager.LoadScene("Main");
    }

}
