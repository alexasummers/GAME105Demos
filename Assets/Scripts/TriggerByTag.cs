using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerByTag : MonoBehaviour
{
        private static int counter = 0; //need static, otherwise it will count prefabs independently
        private int coin = 1;

       private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
             counter = counter + coin;
             Debug.Log("Score: " + counter);
             Destroy(gameObject);
        }
            
    }
}
