using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFlow : MonoBehaviour
{
    private static UIFlow _instance = null;
    CharaMovement cm;
    GameObject pl;

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
    public UICon Pause;
    public UICon dewabar;
    public UICon dialo;

    public bool IsGameOver { get { return isGameOver; } }
    private bool isGameOver = false;
    public bool IsWin { get { return isWin; } }
    private bool isWin = false;

    void Start()
    {
        isGameOver = false;
        isWin = false;
        pl = GameObject.FindGameObjectWithTag("Player");
        cm = pl.GetComponent<CharaMovement>();
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

    public void dewa()
    {
        
        dewabar.Show();

    }
    public void dewas()
    {
        
        dewabar.Hide();

    }
    public void startdial()
    {
        
        dialo.Show();

    }
    public void stopdial()
    {
        
        dialo.Hide();

    }

    public void puse()
    {
        Pause.Show();
        cm.enabled = false;
        
    }
    public void endpuse()
    {
        Pause.Hide();
        cm.enabled = true;
        
    }


}
