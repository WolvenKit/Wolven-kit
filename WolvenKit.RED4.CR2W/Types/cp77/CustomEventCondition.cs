using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomEventCondition : AISignalCondition
	{
		private CName _eventName;

		[Ordinal(5)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		public CustomEventCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
