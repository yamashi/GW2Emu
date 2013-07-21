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
    public class P324_UnknownMessage : IMessage
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public Vector3 Unknown3;
        public Vector2 Unknown4;
        public float Unknown5;
        public float Unknown6;
        public float Unknown7;
        
        public ushort Header
        {
            get
            {
                return 324;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
            serializer.Write(this.Unknown3);
            serializer.Write(this.Unknown4);
            serializer.Write(this.Unknown5);
            serializer.Write(this.Unknown6);
            serializer.Write(this.Unknown7);
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
