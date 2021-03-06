/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 24-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Common;
using GameRevision.GW2Emu.Common.Math;
using GameRevision.GW2Emu.Common.Session;
using GameRevision.GW2Emu.Common.Messaging;
using GameRevision.GW2Emu.Common.Serialization;

namespace GameRevision.GW2Emu.GameServer.Messages.StoC
{
    public class P709_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public struct Struct1
        {
            public short Unknown2;
            public short Unknown3;
            public int Unknown4;
            
            public void Serialize(Serializer serializer)
            {
                serializer.Write(this.Unknown2);
                serializer.Write(this.Unknown3);
                serializer.WriteVarint(this.Unknown4);
            }
        }
        public Struct1[] Unknown5;
        
        public override ushort Header
        {
            get
            {
                return 709;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.WriteVarint(this.Unknown0);
            serializer.Write((byte)Unknown5.Length);
            for (int i = 0; i < Unknown5.Length; i++)
            {
                Unknown5[i].Serialize(serializer);
            }
        }
    }
}
