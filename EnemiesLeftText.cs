using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesLeftText : MonoBehaviour
{
    public Text enemiesText;

    // Update is called once per frame
    void Update()
    {
        enemiesText.text = ((WaveSystem.enemyClone.Length) - 1).ToString();
    }
}
