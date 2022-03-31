using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    [SerializeField]
    private float restartdelay = 1f;
    public GameObject CompleteLevelUI;
    public GameObject closeScoreUI;
    public GameObject MainMenuUI;

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void startGame(string name)
    {
        Debug.Log("Loaded");
        MainMenuUI.SetActive(false);
        SceneManager.LoadScene(name);
    }

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        closeScoreUI.SetActive(false);
    }
    public void Endgame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartdelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
