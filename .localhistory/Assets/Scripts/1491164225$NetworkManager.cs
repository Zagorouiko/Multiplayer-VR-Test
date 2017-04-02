using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NetManager : MonoBehaviour
{

    public virtual void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1." + SceneManagerHelper.ActiveSceneBuildIndex);
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
        //PhotonNetwork.CreateRoom(null, new RoomOptions(), {MaxPlayers = 4}, null );
    }
}
