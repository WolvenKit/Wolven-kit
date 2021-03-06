using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSetTextEvent : inkanimEvent
	{
		private CString _localizationString;

		[Ordinal(1)] 
		[RED("localizationString")] 
		public CString LocalizationString
		{
			get => GetProperty(ref _localizationString);
			set => SetProperty(ref _localizationString, value);
		}

		public inkanimSetTextEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
