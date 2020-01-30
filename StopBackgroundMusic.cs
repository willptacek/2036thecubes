using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundMusic : MonoBehaviour
{
    public GameObject backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
