using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlackholeController : MonoBehaviour


{

    private Text countText;
    public Text gameOverText;
    public Text restartText;

    //timer variables
    float currentTime = 0.0f;
    float startTime = 12.0f;
    public Text timerText ;
    private bool timerActive = true;
    private bool playerActive = true;
    private bool restart = false;




    public GameObject player;
   
    //star particle effect
    public GameObject explosion;



    private Rigidbody2D rb2d;
    private int count;

    //controls music, win and lose
    public AudioClip winMusic;
    public AudioClip loseMusic;
    public AudioClip instructMusic;

    public AudioSource musicSource;



    // Start is called before the first frame update
    void Start()
    {
        
        count = 0;
        
        gameOverText.text = "";
        restartText.text = "";
        currentTime = startTime;

        //StartCoroutine(Instruct());
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0 && timerActive)
        {
            currentTime = currentTime - 1 * Time.deltaTime;
        }

 
        if (currentTime <= 0 && timerActive)
        {
            currentTime = 0;
            timerActive = false;
            LoseGame();
        }

        if (restart)
        {
            restartText.text = "Press 'R' to restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Pluto Party");
                // or whatever the name of your scene is
            }
        }


        timerText.text = "Timer: " + currentTime.ToString("0.0");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Pick up counting
        if (other.gameObject.CompareTag("PickUp"))
            //PickUp tag refers to planets
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            Explode();
        }


     }


    //win condition
    void SetCountText()
    {
        
        if (count >= 3 && playerActive)
        //Win Text display
        {
            timerActive = false;
            gameOverText.text = "You win! Game created by Erica!";
            musicSource.clip = winMusic;
            musicSource.Play();
            restart = true;

        }

    }

    void LoseGame()
    {
        //Player active is to make sure player can't win after they have lost
        playerActive = false;
        gameOverText.text = "You Lose... Game created by Erica!";
        Destroy(player);

        musicSource.clip = loseMusic;
        musicSource.Play();
        restart = true;
    }


    /*IEnumerator Instruct()
    {

        float timePassed = 0;
        while (timePassed <= 3)
        {
            // Code to intro music goes here


            timePassed += Time.deltaTime;

            yield return null;
        }
    }*/

    void Explode()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
