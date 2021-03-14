using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSocketDefinition : graphGraphSocketDefinition
	{
		private CEnum<questSocketType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<questSocketType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questSocketType>) CR2WTypeManager.Create("questSocketType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public questSocketDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}