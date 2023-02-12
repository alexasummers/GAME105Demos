using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put on coin
// don't forget rigid body on coin
//don't forget to mark coin as trigger

public class TriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        Destroy(gameObject);
    }
}
