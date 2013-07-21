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
    public class P557_UnknownMessage : IMessage
    {
        public byte Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public string Unknown4;
        public UID Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        
        public ushort Header
        {
            get
            {
                return 557;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.Write(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.Write(this.Unknown2);
            serializer.WriteVarint(this.Unknown3);
            serializer.WriteUtf16String(this.Unknown4);
            serializer.Write(this.Unknown5);
            serializer.Write(this.Unknown6);
            serializer.Write(this.Unknown7);
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
