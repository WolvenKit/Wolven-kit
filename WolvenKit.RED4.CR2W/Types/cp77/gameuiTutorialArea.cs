using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialArea : inkWidgetLogicController
	{
		private CName _bracketID;

		[Ordinal(1)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get
			{
				if (_bracketID == null)
				{
					_bracketID = (CName) CR2WTypeManager.Create("CName", "bracketID", cr2w, this);
				}
				return _bracketID;
			}
			set
			{
				if (_bracketID == value)
				{
					return;
				}
				_bracketID = value;
				PropertySet(this);
			}
		}

		public gameuiTutorialArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}