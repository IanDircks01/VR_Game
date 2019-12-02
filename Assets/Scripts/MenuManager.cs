using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public bool PlayOnStart;

    [Range(0.0f, 1.0f)]
    public float MenuMusicVolume = 0.5f;

    public AudioSource AS;
    public AudioClip AC;

    void Start()
    {
        AS.clip = AC;
        AS.volume = MenuMusicVolume;
        if (PlayOnStart == true)
        {
            AS.Play();
        }
    }

    public void GotoScene(int SceneNumber)
    {
        StartCoroutine(LoadSceneAsynchronous(SceneNumber));
    }

    IEnumerator LoadSceneAsynchronous(int SceneNumber)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneNumber);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
