using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoStateChangeEvent : redEvent
	{
		private wCHandle<gameObject> _weaponOwner;

		[Ordinal(0)] 
		[RED("weaponOwner")] 
		public wCHandle<gameObject> WeaponOwner
		{
			get
			{
				if (_weaponOwner == null)
				{
					_weaponOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "weaponOwner", cr2w, this);
				}
				return _weaponOwner;
			}
			set
			{
				if (_weaponOwner == value)
				{
					return;
				}
				_weaponOwner = value;
				PropertySet(this);
			}
		}

		public AmmoStateChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}