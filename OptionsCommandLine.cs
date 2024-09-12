using System;
using libmpv.CommandLineArgs;

namespace SFVipPlayer
{
	// Token: 0x02000004 RID: 4
	public class OptionsCommandLine
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000212F File Offset: 0x0000032F
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002137 File Offset: 0x00000337
		[Option("s", "sub", DefaultValue = "")]
		public string Subtitle { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002140 File Offset: 0x00000340
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002148 File Offset: 0x00000348
		[Option("f", "file", DefaultValue = "")]
		public string MediaFile { get; set; }
	}
}
