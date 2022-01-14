using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer vid;
    public GameObject loadscrn;
    public Slider loadbar;

    void Start() { vid.loopPointReached += CheckOver; }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        LoadScene(2);
    }

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
