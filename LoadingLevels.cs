using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadingLevel : MonoBehaviour {

    public void NextLevelButton(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void NextLevelButton(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void Close()
    {
        Application.Quit();
    }
}
