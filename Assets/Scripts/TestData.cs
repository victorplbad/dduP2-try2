using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class TestData : MonoBehaviour
{

public void ClickSpawn()

{
        
        Debug.Log("spawning");
    PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Capsule"), new Vector3(-10, 5, 0), Quaternion.Euler(0, 0, 0));
    }


}


