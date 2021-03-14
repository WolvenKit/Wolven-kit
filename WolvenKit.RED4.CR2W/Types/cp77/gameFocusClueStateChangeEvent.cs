using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFocusClueStateChangeEvent : redEvent
	{
		private CInt32 _clueIndex;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get
			{
				if (_clueIndex == null)
				{
					_clueIndex = (CInt32) CR2WTypeManager.Create("Int32", "clueIndex", cr2w, this);
				}
				return _clueIndex;
			}
			set
			{
				if (_clueIndex == value)
				{
					return;
				}
				_clueIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public gameFocusClueStateChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}