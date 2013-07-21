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

namespace GameRevision.GW2Emu.GameServer.Messages.CtoS
{
    public class P100_UnknownMessage : IMessage
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        public string[] Unknown3;
        
        public ushort Header
        {
            get
            {
                return 100;
            }
        }
        
        public void Serialize(Serializer serializer) {}
        public void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadVarint();
            this.Unknown1 = deserializer.ReadUtf16String();
            this.Unknown2 = deserializer.ReadUtf16String();
            this.Unknown3 = new string[3];
            for (int i = 0; i < this.Unknown3.Length; i++)
            {
                this.Unknown3[i] = deserializer.ReadUtf16String();
            }
        }
    }
}
