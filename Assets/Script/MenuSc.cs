using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSc : MonoBehaviour
{
    // Start is called before the first frame update
    public void stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void menuss()
    {
        SceneManager.LoadScene("Menu");
    }
    public void quittt()
    {
        Application.Quit();
    }

}
