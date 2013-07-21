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
    public class P247_UnknownMessage : IMessage
    {
        public int Unknown0;
        public byte Unknown1;
        public struct Struct2
        {
            public byte Unknown3;
            public byte Unknown4;
            public int Unknown5;
            
            public void Serialize(Serializer serializer)
            {
                serializer.Write(this.Unknown3);
                serializer.Write(this.Unknown4);
                serializer.WriteVarint(this.Unknown5);
            }
            public void Deserialize(Deserializer deserializer) {}
        }
        public Struct2[] Unknown6;
        
        public ushort Header
        {
            get
            {
                return 247;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.WriteVarint(this.Unknown0);
            serializer.Write(this.Unknown1);
            for (int i = 0; i < this.Unknown6.Length; i++)
            {
                this.Unknown6[i].Serialize(serializer);
            }
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
