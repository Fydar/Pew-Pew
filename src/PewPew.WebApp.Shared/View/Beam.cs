﻿using PewPew.WebApp.Shared.Model;

namespace PewPew.WebApp.Shared.View
{
	public class Beam
	{
		public LocalId Owner { get; set; }
		public LocalId Target { get; set; }
		public Vector2 StartPosition { get; set; }
		public Vector2 EndPosition { get; set; }
		public int LifetimeRemaining { get; set; } = 3;
		public int DamagePerTick { get; set; } = 5;
		public int Thickness { get; set; } = 3;
	}
}
