using System;
using SFVipPlayer.Config;
using SFVipPlayer.Logging;

namespace SFVipPlayer
{
	// Token: 0x02000003 RID: 3
	public static class AppSettings
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020CD File Offset: 0x000002CD
		public static SettingsMng ConfigMng { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020D5 File Offset: 0x000002D5
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020DC File Offset: 0x000002DC
		public static MainWindow Main { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020EB File Offset: 0x000002EB
		public static LogWriter Log { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020F3 File Offset: 0x000002F3
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020FA File Offset: 0x000002FA
		public static string BaseDirectory { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002102 File Offset: 0x00000302
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002109 File Offset: 0x00000309
		public static string AppUserAgent { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002111 File Offset: 0x00000311
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002118 File Offset: 0x00000318
		public static bool IsMissingMpvDllFile { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002120 File Offset: 0x00000320
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002127 File Offset: 0x00000327
		public static int TotalChannels { get; set; }
	}
}
