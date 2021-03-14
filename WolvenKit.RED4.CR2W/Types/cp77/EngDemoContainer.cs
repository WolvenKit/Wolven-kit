using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EngDemoContainer : BaseSkillCheckContainer
	{
		private CHandle<EngineeringSkillCheck> _engineeringCheck;
		private CHandle<DemolitionSkillCheck> _demolitionCheck;

		[Ordinal(3)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get
			{
				if (_engineeringCheck == null)
				{
					_engineeringCheck = (CHandle<EngineeringSkillCheck>) CR2WTypeManager.Create("handle:EngineeringSkillCheck", "engineeringCheck", cr2w, this);
				}
				return _engineeringCheck;
			}
			set
			{
				if (_engineeringCheck == value)
				{
					return;
				}
				_engineeringCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get
			{
				if (_demolitionCheck == null)
				{
					_demolitionCheck = (CHandle<DemolitionSkillCheck>) CR2WTypeManager.Create("handle:DemolitionSkillCheck", "demolitionCheck", cr2w, this);
				}
				return _demolitionCheck;
			}
			set
			{
				if (_demolitionCheck == value)
				{
					return;
				}
				_demolitionCheck = value;
				PropertySet(this);
			}
		}

		public EngDemoContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}