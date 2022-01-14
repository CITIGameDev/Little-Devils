using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    CharaMovement cm;
    void Start()
    {
        cm = GetComponent<CharaMovement>();
    }
    // Start is called before the first frame update
    public void stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    
     public void menus()
    {
        SceneManager.LoadScene("Menu1");
    } 
    public void quittt()
    {
        Application.Quit();
    }
    public void intros()
    {
        SceneManager.LoadScene("Intro");
    }

}
