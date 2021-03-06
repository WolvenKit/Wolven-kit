using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FailedActionEvent : redEvent
	{
		private CHandle<gamedeviceAction> _action;
		private gamePersistentID _whoFailed;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("whoFailed")] 
		public gamePersistentID WhoFailed
		{
			get => GetProperty(ref _whoFailed);
			set => SetProperty(ref _whoFailed, value);
		}

		public FailedActionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
