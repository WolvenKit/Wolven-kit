using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestTitleModifier : gameJournalEntry
	{
		private LocalizationString _title;

		[Ordinal(1)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestTitleModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}