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
    public class P553_UnknownMessage : IMessage
    {
        public ushort Header
        {
            get
            {
                return 553;
            }
        }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
