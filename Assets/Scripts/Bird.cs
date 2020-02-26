using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public Rigidbody2D birdrigidbody;
    public float flapforce;
    public GameObject gameoverUI;
    public GameObject backgroundmusic;
    public AudioSource scorenoise;
    public GameObject jumpnoise; 
    
    

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Flap Working Yeah");

            //birdrigidbody.AddForce(Vector2.up * flapforce);
            birdrigidbody.velocity = Vector2.up * flapforce;
            jumpnoise.GetComponent<AudioSource>().Play();

        }
    }

    //
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreTag")
        {
            //Debug.Log("Score!");

            score += 1;
            Debug.Log(score);
            GetComponent<AudioSource>().Play();
            
        }
        else
        {
            //Debug.Log("Collision!");

            gameoverUI.SetActive(true);
            Time.timeScale = 0;
        }



    }


    public void OnRestartButtonPressed ()
    {
        //Debug.Log("Button Pressed!"); 

        Time.timeScale = 1;

        DontDestroyOnLoad (this.backgroundmusic);

        SceneManager.LoadScene("Freshour_Scene");

    }

}
