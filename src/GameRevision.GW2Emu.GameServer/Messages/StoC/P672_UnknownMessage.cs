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
    public class P672_UnknownMessage : GenericMessage
    {
        public int[] Unknown0;
        public int[] Unknown1;
        
        public override ushort Header
        {
            get
            {
                return 672;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.Write((byte)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                serializer.WriteVarint(Unknown0[i]);
            }
            serializer.Write((byte)Unknown1.Length);
            for (int i = 0; i < Unknown1.Length; i++)
            {
                serializer.WriteVarint(Unknown1[i]);
            }
        }
    }
}
