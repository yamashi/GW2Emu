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
    public class P607_UnknownMessage : IMessage
    {
        public struct Struct0
        {
            public UID Unknown1;
            public UID Unknown2;
            public short Unknown3;
            public short Unknown4;
            public int Unknown5;
            public byte Unknown6;
            
            public void Serialize(Serializer serializer)
            {
                serializer.Write(this.Unknown1);
                serializer.Write(this.Unknown2);
                serializer.Write(this.Unknown3);
                serializer.Write(this.Unknown4);
                serializer.WriteVarint(this.Unknown5);
                serializer.Write(this.Unknown6);
            }
            public void Deserialize(Deserializer deserializer) {}
        }
        public Struct0[] Unknown7;
        
        public ushort Header
        {
            get
            {
                return 607;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.Write((byte)Unknown7.Length);
            for (int i = 0; i < Unknown7.Length; i++)
            {
                Unknown7[i].Serialize(serializer);
            }
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
