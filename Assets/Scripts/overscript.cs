using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overscript : MonoBehaviour
{
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
