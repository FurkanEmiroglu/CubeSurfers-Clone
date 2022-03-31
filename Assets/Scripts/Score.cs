using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    private void Update()
    {
        ScoreText.text = (player.position.z - 10).ToString("0") + (player.transform.childCount - 2);
    }
}
