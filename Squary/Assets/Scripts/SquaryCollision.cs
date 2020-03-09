using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SquaryCollision : MonoBehaviour
{


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if(collisionInfo.tag == "Enemy")
        {
            Debug.Log("Vmer si mjmune!!!");
            ShopController.coinAmount = 0;
            FindObjectOfType<GameManager>().Restart();
        }
        if( collisionInfo.tag == "GameComplete")
        {
            SceneManager.LoadScene("Main Menu");
        }
        
    }
}
