using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public GameObject deathCam;
    public GameObject deathScreen;
    public GameObject mainUI;
    public GameObject backgroundMusic;
    public GameObject playerPauseObject;
    public GameObject bulletpf, enemypf;
    public Camera playerCamera;
    public AudioSource audioSource;
    public AudioClip[] shootSounds;
    private AudioClip ShootClip;

    private int bulletcount = 0;

    public int xPos;
    public int zPos;

    // Use this for initialization
    public float bulletUp = .5f, bulletFwd = .75f, bulletSp = 20f;

    void Start()
    {
        deathCam.SetActive(false);
        deathScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))//fires the bullets
        {

            int index = Random.Range(0, shootSounds.Length);
            ShootClip = shootSounds[index];
            audioSource.clip = ShootClip;
            audioSource.Play();

            GameObject bulletObject = Instantiate(bulletpf);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;


        }
    }

    void OnCollisionEnter(Collision other)//death collision, pause game
    {
        if (other.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            deathCam.SetActive(true);//enables death camera
            mainUI.SetActive(false);//disables main UI in favor of death screen UI
            playerPauseObject.SetActive(false);//disables input from the player
            backgroundMusic.SetActive(false);//stops the background music, as a new sound effect will play
            deathScreen.SetActive(true);//enables the new UI, the deathscreen.
        }
    }
}

