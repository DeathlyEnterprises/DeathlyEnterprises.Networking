﻿namespace DeathlyEnterprises.Networking
{
    public class DefaultMessage : IMessage
    {
        public DefaultMessage(string messageType, byte[] messageContents, int messageContentSize)
        {
            MessageType = messageType;
            MessageContents = messageContents;
            MessageContentSize = messageContentSize;
        }

        public string MessageType { get; }
        public byte[] MessageContents { get; }

        public int MessageContentSize { get; }
    }
}