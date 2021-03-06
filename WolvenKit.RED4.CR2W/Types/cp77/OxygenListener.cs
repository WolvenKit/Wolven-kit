using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OxygenListener : gameScriptStatPoolsListener
	{
		private wCHandle<OxygenbarWidgetGameController> _oxygenBar;

		[Ordinal(0)] 
		[RED("oxygenBar")] 
		public wCHandle<OxygenbarWidgetGameController> OxygenBar
		{
			get => GetProperty(ref _oxygenBar);
			set => SetProperty(ref _oxygenBar, value);
		}

		public OxygenListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
