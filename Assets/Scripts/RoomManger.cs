using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;

public class RoomManger : MonoBehaviourPunCallbacks
{
    
    public static RoomManger Instance;



     void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
                return;
        }
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }


   public override void OnEnable()
    {
        base.OnEnable();
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    public override void OnDisable()
    {
        base.OnDisable();
        SceneManager.sceneLoaded -= OnSceneLoad;
    }



    void OnSceneLoad(Scene scene, LoadSceneMode loadSceneMode) 
    {
        if (scene.buildIndex == 1) // we are in the game scene (its nr 1?!? )
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerManager"), Vector3.zero, Quaternion.identity);
            



        }



    }

    
    
    




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




    }
}
