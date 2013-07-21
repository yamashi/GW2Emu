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
    public class P540_UnknownMessage : IMessage
    {
        public int Unknown0;
        public string Unknown1;
        public byte Unknown2;
        
        public ushort Header
        {
            get
            {
                return 540;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteUtf16String(this.Unknown1);
            serializer.Write(this.Unknown2);
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
