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
    public class P006_UnknownMessage : IMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public Vector4 Unknown5;
        public int Unknown6;
        public Optional<Vector4> Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public byte Unknown10;
        public short Unknown11;
        public short Unknown12;
        public short Unknown13;
        
        public ushort Header
        {
            get
            {
                return 6;
            }
        }
        
        public void Serialize(Serializer serializer) {}
        public void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadInt16();
            this.Unknown1 = deserializer.ReadVarint();
            this.Unknown2 = deserializer.ReadByte();
            this.Unknown3 = deserializer.ReadVarint();
            byte unknown4Length = deserializer.ReadByte();
            if (unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = deserializer.ReadByte();
            }
            this.Unknown5 = deserializer.ReadVector4();
            this.Unknown6 = deserializer.ReadVarint();
            if (deserializer.ReadBoolean())
            {
                this.Unknown7 = new Optional<Vector4>(deserializer.ReadVector4());
            }
            else
            {
                this.Unknown7 = null;
            }
            this.Unknown8 = deserializer.ReadByte();
            this.Unknown9 = deserializer.ReadByte();
            this.Unknown10 = deserializer.ReadByte();
            this.Unknown11 = deserializer.ReadInt16();
            this.Unknown12 = deserializer.ReadInt16();
            this.Unknown13 = deserializer.ReadInt16();
        }
    }
}
