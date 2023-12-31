using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

   private void OnTriggerEnter(Collider other)
   {
        if(other.CompareTag("Player")){
            scoreManager.IncreaseScore();
            gameObject.SetActive(false);
        }
   }
}
