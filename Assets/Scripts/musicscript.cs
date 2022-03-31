using UnityEngine;
using UnityEngine.UI;

public class musicscript : MonoBehaviour
{
    public AudioSource music01;
    public bool musicstatus;
    void Start()
    {
        if (musicstatus == true)
        {
            music01.Play();
        }
    }
    void Update()
    {

    }

    public void stopMusic()
    {
        musicstatus = false;
        music01.Stop();
    }
    public void OpenVolume()
    {
        musicstatus = true;
        music01.Play();
    }
}
