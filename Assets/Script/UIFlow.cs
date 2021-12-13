using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFlow : MonoBehaviour
{
    private static UIFlow _instance = null;
    CharaMovement cm;

    public static UIFlow Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<UIFlow>();
            }
            return _instance;
        }
    }

    [Header("UI")]
    public UICon GameOverUI;
    public UICon WIN;

    public bool IsGameOver { get { return isGameOver; } }
    private bool isGameOver = false;
    public bool IsWin { get { return isWin; } }
    private bool isWin = false;

    private void Start()
    {
        isGameOver = false;
        isWin = false;
        cm = GetComponent<CharaMovement>();
    }
    public void GameOver()
    {
        isGameOver = true;
        GameOverUI.Show();
    }
    public void winn()
    {
        isWin = true;
        WIN.Show();
        
    }

}
