using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float sidewaysSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 5 && transform.position.x > -5)
        {
            float horizontal_axis = Input.GetAxis("Horizontal") * sidewaysSpeed * Time.deltaTime;
            this.transform.Translate(horizontal_axis, 0, forwardSpeed * Time.deltaTime);
            
        }
    }
}
