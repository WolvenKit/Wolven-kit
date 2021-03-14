using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLocationPrefabMetadata : worldPrefabMetadata
	{
		private CArray<CName> _tags;
		private CBool _ignoreParentPrefabs;

		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ignoreParentPrefabs")] 
		public CBool IgnoreParentPrefabs
		{
			get
			{
				if (_ignoreParentPrefabs == null)
				{
					_ignoreParentPrefabs = (CBool) CR2WTypeManager.Create("Bool", "ignoreParentPrefabs", cr2w, this);
				}
				return _ignoreParentPrefabs;
			}
			set
			{
				if (_ignoreParentPrefabs == value)
				{
					return;
				}
				_ignoreParentPrefabs = value;
				PropertySet(this);
			}
		}

		public gameLocationPrefabMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}