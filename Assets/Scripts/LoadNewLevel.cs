using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNewLevel : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

