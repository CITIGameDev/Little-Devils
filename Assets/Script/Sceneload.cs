using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Sceneload : MonoBehaviour
{
    public GameObject loadscrn;
    public Slider loadbar;
    public void LoadScene(int levelIndex)
    {
        StartCoroutine(LoadSceneAsynchronously(levelIndex));
    }

    IEnumerator LoadSceneAsynchronously(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        loadscrn.SetActive(true);
        while (!operation.isDone)
        {
            loadbar.value = operation.progress;
            yield return null;
        }
    }
    // Start is called before the first frame update
    
}
