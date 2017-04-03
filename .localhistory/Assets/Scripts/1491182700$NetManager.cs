using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NetManager : MonoBehaviour
{
    public GameObject headPrefab;
    public GameObject Hand;

    public virtual void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1 ." + SceneManagerHelper.ActiveSceneBuildIndex);
    }

    public virtual void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedtoMaster() was called by PUN");
        PhotonNetwork.JoinRandomRoom();
    }

    public virtual void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby()");
        PhotonNetwork.JoinRandomRoom();
    }

    public virtual void OnPhotonRandomJoinFailed()
    {
        Debug.Log("OnPhotonRandomJoinFailed() was called by PUN");
        PhotonNetwork.CreateRoom(null, new RoomOptions() { MaxPlayers = 4 }, null );
    }

    public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        Debug.LogError("Cause: " + cause);
    }

    public void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom() called by PUN");
        PhotonNetwork.Instantiate(headPrefab.name, ViveManager.Instance.head.transform.position,
            ViveManager.Instance.head.transform.rotation, 0);
    }
}
