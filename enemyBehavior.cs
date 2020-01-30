using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour
{
    public AudioClip sound1, sound2, sound3, sound4;
    public Transform Player;
    public static float movementSpeed = 4;
    private int soundDeterminer;
    private int killCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        soundDeterminer = Random.Range(1, 4);//generates a random # for determining the enemy sound on death
        if (other.gameObject.tag == "BulletTag")
        {
            killCount++; //increases the kill count of the player by 1, for tracking purposes.
            Destroy(other.gameObject);
            Die();
        }
    }
   
    void Die()
    {
        soundDeterminer = Random.Range(1, 4);//generates a random # for determining the enemy sound on death
        Debug.Log("SoundDeterminer = ");
        Debug.Log(soundDeterminer);
        switch (soundDeterminer)
        {
            case 1:
                AudioSource.PlayClipAtPoint(sound1, transform.position);
                break;
            case 2:
                AudioSource.PlayClipAtPoint(sound2, transform.position);
                break;
            case 3:
                AudioSource.PlayClipAtPoint(sound3, transform.position);
                break;
            case 4:
                AudioSource.PlayClipAtPoint(sound4, transform.position);
                break;
        }
        Destroy(gameObject);
    }
}
