using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
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
