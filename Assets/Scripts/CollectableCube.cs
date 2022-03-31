using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool isCollected;
    int index;
    public Collector collector;
    public AudioSource obstacleHitSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    public bool GetIsCollected()
    {
        return isCollected;
    }

    public void SetCollected()
    {
        isCollected = true;
    }
    public void SetIndex(int index)
    {
        this.index = index;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            collector.DecreseHeight();
            gameObject.transform.parent = null;
            other.gameObject.transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            obstacleHitSound.Play();
        }
    }
}
