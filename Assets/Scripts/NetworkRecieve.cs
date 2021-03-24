using System;
using KaymakNetwork;
using UnityEngine;

enum ServerPackets
{
    WelcomeMsg = 1,
}

internal static class NetworkRecieve
{
    internal static void PacketRouter()
    {
        NetworkConfig.socket.PacketId[(int)ServerPackets.WelcomeMsg] = new KaymakNetwork.Network.Client.DataArgs(Packet_WelcomeMsg);
    }

    private static void Packet_WelcomeMsg(ref byte[] data)
    {
        ByteBuffer buffer = new ByteBuffer(data);
        string msg = buffer.ReadString();

        buffer.Dispose();

        Debug.Log(msg);

        NetworkSend.SendPing();
    }
}

