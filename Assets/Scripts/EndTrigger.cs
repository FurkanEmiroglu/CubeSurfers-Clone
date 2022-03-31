using UnityEngine.SceneManagement;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource LevelCompleteSound;
    private GameObject music;
    [SerializeField]
    private float delaytime = 2f;

    private void Start()
    {
        music = GameObject.Find("Level01Music");
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
        LevelCompleteSound.Play();
        music.gameObject.GetComponent<musicscript>().stopMusic();
        if (SceneManager.GetActiveScene().name != "Credits")
        {
            Invoke("LoadNextLevel", delaytime);
        }
    }

    void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().name != "Credits")
        {
            gameManager.CompleteLevel();
            LevelCompleteSound.Play();
            music.gameObject.GetComponent<musicscript>().stopMusic();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
