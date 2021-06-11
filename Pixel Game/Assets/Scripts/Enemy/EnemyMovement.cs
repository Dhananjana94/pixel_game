using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
   

    // Update is called once per frame
    void Update()
    {
        //if bool value of MoveRight is true enemy will move to the right
        if (MoveRight)
        {

            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(3,3); //head movement of the enemy
        }
        else {

            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-3, 3);
        }

     
    }
        
   void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn")) {

            if (MoveRight)
            {

                MoveRight = false;
            }
            else {

                MoveRight = true;
            }
        }

        
        
    }

   
}
