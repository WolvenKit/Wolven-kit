using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityArea : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _area;

		[Ordinal(93)] 
		[RED("area")] 
		public CHandle<gameStaticTriggerAreaComponent> Area
		{
			get
			{
				if (_area == null)
				{
					_area = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		public SecurityArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}