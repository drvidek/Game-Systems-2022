using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    //Change the scene based off the scene index value
    public void ChangeScene(int sceneIndex)
    {
        //using Scene Manager, load the scene corresponding to the index provided
        SceneManager.LoadScene(sceneIndex);

        
    }

    //quit our game
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    
}
