using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIbehaviorconditionScript> _script;
		private CBool _disableLazyInitialization;

		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviorconditionScript> Script
		{
			get
			{
				if (_script == null)
				{
					_script = (CHandle<AIbehaviorconditionScript>) CR2WTypeManager.Create("handle:AIbehaviorconditionScript", "script", cr2w, this);
				}
				return _script;
			}
			set
			{
				if (_script == value)
				{
					return;
				}
				_script = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("disableLazyInitialization")] 
		public CBool DisableLazyInitialization
		{
			get
			{
				if (_disableLazyInitialization == null)
				{
					_disableLazyInitialization = (CBool) CR2WTypeManager.Create("Bool", "disableLazyInitialization", cr2w, this);
				}
				return _disableLazyInitialization;
			}
			set
			{
				if (_disableLazyInitialization == value)
				{
					return;
				}
				_disableLazyInitialization = value;
				PropertySet(this);
			}
		}

		public AIbehaviorScriptConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}