using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColectCoins : MonoBehaviour
{
    private int totalCoins = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            totalCoins++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("Fase 1");
        }
    }

    public int GetCoins()
    {
        return totalCoins;
    }
}
