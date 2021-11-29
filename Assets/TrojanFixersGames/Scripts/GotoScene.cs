using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoScene : MonoBehaviour
{
    [SerializeField] string SceneToGo = "MainScene";

    public void GoToScene()
    {
        SceneManager.LoadScene(SceneToGo, LoadSceneMode.Single);
    }
}
