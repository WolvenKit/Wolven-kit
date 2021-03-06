using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterListenerOnTargetHPEvent : redEvent
	{
		private CHandle<TargetedObjectDeathListener> _listener;
		private CBool _isFromListenerEvent;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<TargetedObjectDeathListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("isFromListenerEvent")] 
		public CBool IsFromListenerEvent
		{
			get => GetProperty(ref _isFromListenerEvent);
			set => SetProperty(ref _isFromListenerEvent, value);
		}

		public UnregisterListenerOnTargetHPEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
