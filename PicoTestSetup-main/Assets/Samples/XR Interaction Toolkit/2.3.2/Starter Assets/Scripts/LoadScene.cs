using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene you want to load

    // Call this method to load the specified scene
    public void LoadNewScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}