﻿using System;
using KaymakNetwork;

enum ClientPackets
{
    CPing = 1,
}

internal static class NetworkSend
{
    public static void SendPing()
    {
        ByteBuffer buffer = new ByteBuffer(4);
        buffer.WriteInt32((int)ClientPackets.CPing);
        buffer.WriteString("Hi, I'm the client!");

        NetworkConfig.socket.SendData(buffer.Data, buffer.Head);

        buffer.Dispose();
    }
}

