/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 21-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Common;
using GameRevision.GW2Emu.Common.Math;
using GameRevision.GW2Emu.Common.Messaging;
using GameRevision.GW2Emu.Common.Serialization;

namespace GameRevision.GW2Emu.GameServer.Messages.StoC
{
    public class P327_UnknownMessage : IMessage
    {
        public Vector2 Unknown0;
        public Vector2 Unknown1;
        public Vector2 Unknown2;
        public Vector2 Unknown3;
        
        public ushort Header
        {
            get
            {
                return 327;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.Write(this.Unknown0);
            serializer.Write(this.Unknown1);
            serializer.Write(this.Unknown2);
            serializer.Write(this.Unknown3);
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
