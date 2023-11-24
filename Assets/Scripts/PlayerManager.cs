using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{

    PhotonView PV;

    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }




    // Start is called before the first frame update
    void Start()
    {

        if (PV.IsMine)
        {
            CreateController();


        }

    }

    void CreateController()
    {

        // cutout // PhotonNetwork.Instantiate(Path.Combine("PhotonPrebas", "PlayerController"),Vector3.zero, Quaternion.identity);
        GameObject g = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerUiDemo"), new Vector3(-25, 45, -20), Quaternion.Euler(45, 0, 0));

        

        



    }



    





}
