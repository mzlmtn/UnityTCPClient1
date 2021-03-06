using System;
using KaymakNetwork.Network;

internal static class NetworkConfig
{
    internal static Client socket;
    internal static void InitializeNetwork()
    {
        if (!ReferenceEquals(socket, null)) return;
        socket = new Client(100);

        NetworkRecieve.PacketRouter();
    }

    internal static void ConnectToServer()
    {
        socket.Connect("localhost", 5555);
    }

    internal static void DisconnectFromServer()
    {
        socket.Dispose();
    }
}

