using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameContainerObjectSingleItem : gameContainerObjectBase
	{
		private TweakDBID _itemTDBID;

		[Ordinal(51)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get
			{
				if (_itemTDBID == null)
				{
					_itemTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemTDBID", cr2w, this);
				}
				return _itemTDBID;
			}
			set
			{
				if (_itemTDBID == value)
				{
					return;
				}
				_itemTDBID = value;
				PropertySet(this);
			}
		}

		public gameContainerObjectSingleItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}