﻿using System;
using System.Net;
using System.Reflection;
using GameRevision.GW2Emu.Core;
using GameRevision.GW2Emu.Network;

namespace GameRevision.GW2Emu.LoginServer
{
    public class LoginServerApp : IServerApp
    {
        public IEventAggregator EventAggregator { get; private set; }
        public ISessionListener SessionListener { get; private set; }
        public ConcurrentSessionCollection SessionCollection { get; private set; }

        public string Name
        {
            get
            {
                return "GW2Emu - Login Server";
            }
        }

        public LoginServerApp()
        {
            this.EventAggregator = new EventAggregator();
            this.SessionCollection = new ConcurrentSessionCollection();
            this.SessionListener = new SessionListener(IPAddress.Any, 6112);
            this.SessionListener.NetworkSessionCreated += OnNetworkSessionCreated;
        }

        public void RegisterHandlers()
        {
        }

        public void Run()
        {
            this.SessionListener.Listen();
        }

        public void Stop()
        {
            this.SessionListener.Stop();
            this.SessionCollection.StopAll();
        }

        private void OnNetworkSessionCreated(object sender, NetworkSessionCreatedEventArgs e)
        {
            ISession session = new LoginSession(this, e.NetworkSession);
            session.Run();
            this.SessionCollection.Add(session);
        }
    }
}