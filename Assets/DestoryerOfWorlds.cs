using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryerOfWorlds : MonoBehaviour
{

void OnTriggerEnter ( Collider other) {

    if (other.gameObject.tag == "hell")
    {
        IEnumerator coroutine = allKillig(other.gameObject);
        StartCoroutine (coroutine);
    }
}

IEnumerator allKillig(GameObject toDestroy){
    yield return new WaitForSeconds (5);
    Destroy (toDestroy);
}



}
