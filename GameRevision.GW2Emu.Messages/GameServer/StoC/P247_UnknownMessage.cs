/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 08-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Core;
using GameRevision.GW2Emu.Core.Types;
using GameRevision.GW2Emu.Core.Serializers;

namespace GameRevision.GW2Emu.Messages.GameServer.StoC
{
    public class P247_UnknownMessage : GenericMessage
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
        }
        public Struct2[] Unknown6;
        
        public override ushort Header
        {
            get
            {
                return 247;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.Write(this.Unknown1);
            for (int i = 0; i < this.Unknown6.Length; i++)
            {
                this.Unknown6[i].Serialize(serializer);
            }
        }
    }
}