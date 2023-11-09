using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Launcher : MonoBehaviourPunCallbacks
{


    [SerializeField] TMP_InputField roomNameInputField;
    [SerializeField] TMP_Text errorText;
    [SerializeField] TMP_Text roomNameText;

    void Start()
    {
        print("connecting to Master server.");
        
        PhotonNetwork.ConnectUsingSettings();
        
        

    }

    public override void OnConnectedToMaster()
    {
        print("Connect to Master Server.");

        PhotonNetwork.JoinLobby();

    }


    public override void OnJoinedLobby()
    {

        MenuManger.instance.OpenMenu("title");
        Debug.Log("Joined Lobby");
        


    }




    public override void OnDisconnected(DisconnectCause cause)
    {
        print("disconnecet from server for reason" + cause.ToString());



    }

    public void CreateRoom()
    {


        if(string.IsNullOrEmpty(roomNameInputField.text))
        {
            return; 

        }
        PhotonNetwork.CreateRoom(roomNameInputField.text);

        MenuManger.instance.OpenMenu("loading");

    }

    public override void OnJoinedRoom()
    {

        MenuManger.instance.OpenMenu("room");
        roomNameText.text = PhotonNetwork.CurrentRoom.Name;


    }


    public override void OnCreateRoomFailed(short returnCode, string message)
    {

        errorText.text = "Room Creation Failed" + message;
        MenuManger.instance.OpenMenu("error");


    }


    public void LeaveRoom()

    {
        PhotonNetwork.LeaveRoom();
        MenuManger.instance.OpenMenu("loading");

    }

    public override void OnLeftRoom()
    {
        MenuManger.instance.OpenMenu("title");
    }

}
