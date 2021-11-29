using CubeSpaceFree;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    [SerializeField] GameController GC = new GameController();
    [SerializeField] string controllerButtonRestart = "Fire 1";

    void Start()
    {
        GC = GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GC.isGameOver && Input.GetKeyDown(controllerButtonRestart))
        {
            GC.Restart();
        }
    }
}
