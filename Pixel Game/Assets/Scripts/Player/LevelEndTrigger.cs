using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //call level complete method inside Game Manager
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
