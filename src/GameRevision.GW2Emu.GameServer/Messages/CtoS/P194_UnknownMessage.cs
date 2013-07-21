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
    public class P194_UnknownMessage : IMessage
    {
        public int Unknown0;
        public int Unknown1;
        
        public ushort Header
        {
            get
            {
                return 194;
            }
        }
        
        public void Serialize(Serializer serializer) {}
        public void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadVarint();
            this.Unknown1 = deserializer.ReadVarint();
        }
    }
}
