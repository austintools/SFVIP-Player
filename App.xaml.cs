using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows;
using <PrivateImplementationDetails>{0817497A-5D09-4424-A2DC-C72ADD256165};
using libthemes.Themes;
using SFVipPlayer.Extensions;
using SFVipPlayer.Helpers;

namespace SFVipPlayer
{
	// Token: 0x02000006 RID: 6
	public partial class App : Application
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002159 File Offset: 0x00000359
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002161 File Offset: 0x00000361
		public string[] StartupArgs { get; set; }

		// Token: 0x0600001C RID: 28 RVA: 0x0000216A File Offset: 0x0000036A
		public App()
		{
			App.Instance = this;
			App._loadedAssemblies = new Dictionary<string, Assembly>();
			App._keyName = 55277722-7CFD-4E2E-A571-21B17BE1EBDA.a();
			AppDomain.CurrentDomain.AssemblyResolve += App.CurrentDomain_AssemblyResolve;
			DispatcherHelper.Initialize();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000021A8 File Offset: 0x000003A8
		private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			Assembly assembly = null;
			string name = new AssemblyName(args.Name).Name;
			if (name != null && !App._loadedAssemblies.TryGetValue(name, out assembly) && name == App._keyName)
			{
				assembly = Assembly.Load(((byte[])new ResourceManager(55277722-7CFD-4E2E-A571-21B17BE1EBDA.B(), typeof(App).Assembly).GetResourceSet(Thread.CurrentThread.CurrentCulture, true, true).GetObject(name)).LoadAssemblyImage());
				App._loadedAssemblies.Add(name, assembly);
			}
			return assembly;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002234 File Offset: 0x00000434
		protected override void OnStartup(StartupEventArgs e)
		{
			this.StartupArgs = e.Args;
			base.OnStartup(e);
			StyleManager.SetAppTheme(base.Resources, ThemesStyle.Blue);
		}

		// Token: 0x0400000E RID: 14
		public static App Instance;

		// Token: 0x0400000F RID: 15
		private static IDictionary<string, Assembly> _loadedAssemblies;

		// Token: 0x04000010 RID: 16
		private static string _keyName;
	}
}
