using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    public int height;
    public AudioSource PickSound;
    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(mainCube.transform.position.x, height+1, mainCube.transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectable" && other.gameObject.GetComponent<CollectableCube>().GetIsCollected() == false)
        {
            height += 1;
            other.gameObject.GetComponent<CollectableCube>().SetCollected();
            other.gameObject.GetComponent<CollectableCube>().SetIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
            PickSound.Play();
        }
    }

    public void DecreseHeight()
    {
        height -= 1;
    }
}
