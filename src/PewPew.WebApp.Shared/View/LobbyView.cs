﻿using PewPew.WebApp.Shared.Model;
using System.Collections.Generic;

namespace PewPew.WebApp.Shared.View
{
	/// <summary>
	/// A shared scene for players to interact with eachother.
	/// </summary>
	public class LobbyView
	{
		public string LobbyKey { get; set; } = string.Empty;
		public GameplayWorld World { get; set; }
		public LobbyChat Chat { get; set; }
		public Dictionary<LocalId, LobbyPublicPlayerProfile> Players { get; set; }

		public LobbyView()
		{
			Chat = new LobbyChat();
			Players = new Dictionary<LocalId, LobbyPublicPlayerProfile>();
		}
	}
}
