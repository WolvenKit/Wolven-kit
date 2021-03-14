using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigTypeMeleeWeaponConfigurationMap : CVariable
	{
		private CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> _mapItems;

		[Ordinal(0)] 
		[RED("mapItems")] 
		public CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> MapItems
		{
			get
			{
				if (_mapItems == null)
				{
					_mapItems = (CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem>) CR2WTypeManager.Create("array:audioMeleeRigTypeMeleeWeaponConfigurationMapItem", "mapItems", cr2w, this);
				}
				return _mapItems;
			}
			set
			{
				if (_mapItems == value)
				{
					return;
				}
				_mapItems = value;
				PropertySet(this);
			}
		}

		public audioMeleeRigTypeMeleeWeaponConfigurationMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}