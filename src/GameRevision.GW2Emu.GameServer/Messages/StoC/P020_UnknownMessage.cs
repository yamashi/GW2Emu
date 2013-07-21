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
    public class P020_UnknownMessage : IMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public WorldPosition Unknown3;
        public WorldPosition Unknown4;
        public short Unknown5;
        public Vector3 Unknown6;
        public float Unknown7;
        public float Unknown8;
        public byte Unknown9;
        
        public ushort Header
        {
            get
            {
                return 20;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.Write(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.Write(this.Unknown2);
            serializer.Write(this.Unknown3);
            serializer.Write(this.Unknown4);
            serializer.Write(this.Unknown5);
            serializer.Write(this.Unknown6);
            serializer.Write(this.Unknown7);
            serializer.Write(this.Unknown8);
            serializer.Write(this.Unknown9);
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
