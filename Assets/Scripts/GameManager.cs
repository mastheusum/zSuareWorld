using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ColectCoins player;
    public GameObject portal;
    public Text score;
    public int MaxCoins = 0;

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + player.GetCoins();
        if (player.GetCoins() >= MaxCoins)
            portal.SetActive(true);
    }
}
