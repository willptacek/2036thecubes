using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveTextScript : MonoBehaviour
{
    public Text waveText;
   
    // Update is called once per frame
    void Update()
    {
        waveText.text = WaveSystem.WaveNumber.ToString();
    }
}
