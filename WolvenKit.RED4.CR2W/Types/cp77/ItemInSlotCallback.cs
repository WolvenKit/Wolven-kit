using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		private wCHandle<ItemInSlotPrereqState> _state;

		[Ordinal(2)] 
		[RED("state")] 
		public wCHandle<ItemInSlotPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public ItemInSlotCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
