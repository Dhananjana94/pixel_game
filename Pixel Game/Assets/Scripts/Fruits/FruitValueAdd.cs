using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitValueAdd : MonoBehaviour
{
    public int FruitValue = 1;
    public GameObject soundManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {

            ScoreManager.instance.changeScore(FruitValue);

            soundManager.GetComponent<FruitSound>().PlayCoinSound();
        }
    }
}
