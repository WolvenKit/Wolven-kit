using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnTalkOnReturn_Operation : scnIInterruptManager_Operation
	{
		private CBool _talkOnReturn;

		[Ordinal(0)] 
		[RED("talkOnReturn")] 
		public CBool TalkOnReturn
		{
			get
			{
				if (_talkOnReturn == null)
				{
					_talkOnReturn = (CBool) CR2WTypeManager.Create("Bool", "talkOnReturn", cr2w, this);
				}
				return _talkOnReturn;
			}
			set
			{
				if (_talkOnReturn == value)
				{
					return;
				}
				_talkOnReturn = value;
				PropertySet(this);
			}
		}

		public scnTalkOnReturn_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}