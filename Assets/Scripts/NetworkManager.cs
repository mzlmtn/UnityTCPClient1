using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);

        NetworkConfig.InitializeNetwork();
        NetworkConfig.ConnectToServer();
    }

    private void OnApplicationQuit()
    {
        NetworkConfig.DisconnectFromServer();
    }
}
