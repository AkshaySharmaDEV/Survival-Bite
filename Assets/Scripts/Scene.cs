using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //This will load the next scene in the buildIndex, e.g if in scene 3, go to scene 4
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
    public void LoadPLevel()
    {
        //This will load the next scene in the buildIndex, e.g if in scene 3, go to scene 4
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
        AudioListener.pause = false;

    }

    public void LoadSameLevel()
    {
        //This will load the next scene in the buildIndex, e.g if in scene 3, go to scene 4
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
}