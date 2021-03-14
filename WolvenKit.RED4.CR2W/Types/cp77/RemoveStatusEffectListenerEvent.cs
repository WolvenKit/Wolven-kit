using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectListenerEvent : redEvent
	{
		private CHandle<StatusEffectTriggerListener> _listener;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<StatusEffectTriggerListener> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<StatusEffectTriggerListener>) CR2WTypeManager.Create("handle:StatusEffectTriggerListener", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		public RemoveStatusEffectListenerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}