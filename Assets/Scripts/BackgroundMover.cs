using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{

    public float backgroundspeed;
    Vector3 originalpos;
    private float resetTime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        originalpos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * backgroundspeed * Time.deltaTime); 

        if (resetTime > 6.6f)
        {
            gameObject.transform.position = originalpos;
                resetTime = 0.0f;
        }
        resetTime += UnityEngine.Time.deltaTime;
    }
}
