using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentBoolValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CBool _defaultValue;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<AIArgumentType>) CR2WTypeManager.Create("AIArgumentType", "type", cr2w, this);
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

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CBool DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CBool) CR2WTypeManager.Create("Bool", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		public AIArgumentBoolValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}