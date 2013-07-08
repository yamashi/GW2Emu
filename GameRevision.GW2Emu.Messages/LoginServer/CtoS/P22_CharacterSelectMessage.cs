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

namespace GameRevision.GW2Emu.Messages.LoginServer.CtoS
{
    public class P22_CharacterSelectMessage : GenericTriggerableMessage
    {
        public int Unknown0;
        public string CharacterName;
        
        public override ushort Header
        {
            get
            {
                return 22;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadVarint();
            this.CharacterName = deserializer.ReadUtf16String();
        }
    }
}