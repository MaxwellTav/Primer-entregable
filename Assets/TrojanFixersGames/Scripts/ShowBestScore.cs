using UnityEngine;
using UnityEngine.UI;


public class ShowBestScore : MonoBehaviour
{
    [SerializeField] Text bestScore;

    // Start is called before the first frame update
    void Start()
    {
        bestScore = GetComponent<Text>();
        bestScore.text = "Mejor puntuación: " + PlayerPrefs.GetInt("bestScore", 0);
    }
}
