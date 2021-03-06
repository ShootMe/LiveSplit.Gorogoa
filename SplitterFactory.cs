﻿#if !Info
using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;
namespace LiveSplit.Gorogoa {
	public class SplitterFactory : IComponentFactory {
		public string ComponentName { get { return "Gorogoa Autosplitter v" + this.Version.ToString(); } }
		public string Description { get { return "Autosplitter for Gorogoa"; } }
		public ComponentCategory Category { get { return ComponentCategory.Control; } }
		public IComponent Create(LiveSplitState state) { return new SplitterComponent(state); }
		public string UpdateName { get { return this.ComponentName; } }
		public string UpdateURL { get { return "https://raw.githubusercontent.com/ShootMe/LiveSplit.Gorogoa/master/"; } }
		public string XMLURL { get { return this.UpdateURL + "Components/Updates.xml"; } }
		public Version Version { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
	}
}
#endif