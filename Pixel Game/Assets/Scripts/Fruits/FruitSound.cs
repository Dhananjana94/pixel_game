using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSound : MonoBehaviour
    
{
    public AudioSource FruitsSound;

    public void PlayCoinSound() {

        FruitsSound.Play();
    }
}
