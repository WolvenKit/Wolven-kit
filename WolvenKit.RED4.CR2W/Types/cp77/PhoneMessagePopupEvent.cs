using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessagePopupEvent : redEvent
	{
		private CHandle<JournalNotificationData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<JournalNotificationData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public PhoneMessagePopupEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
