﻿using System;
using GameRevision.GW2Emu.Common.Events;
using CtoS = GameRevision.GW2Emu.LoginServer.Messages.CtoS;
using StoC = GameRevision.GW2Emu.LoginServer.Messages.StoC;
using GameRevision.GW2Emu.Common.Session;

namespace GameRevision.GW2Emu.LoginServer.Handlers
{
//    public class Login : IRegisterable
//    {
//        public void Register(IEventAggregator aggregator)
//        {
//            aggregator.Register<CtoS.P03_UnknownMessage>(this.OnComputerInfo);
//            aggregator.Register<CtoS.P10_UnknownMessage>(this.OnClientSessionInfo);
//        }
//
//        private void OnComputerInfo(CtoS.P03_UnknownMessage message)
//        {
//            ISession session = message.Session;
//            session.Send(new StoC.P02_UnknownMessage());
//            session.Send(new StoC.P01_UnknownMessage());
//        }
//
//        private void OnClientSessionInfo(CtoS.P10_UnknownMessage message)
//        {
//            ISession session = message.Session;
//        }
//    }
}
