using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveWithPolicyTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CBool _stopWhenDestinationReached;

		[Ordinal(1)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get
			{
				if (_stopWhenDestinationReached == null)
				{
					_stopWhenDestinationReached = (CBool) CR2WTypeManager.Create("Bool", "stopWhenDestinationReached", cr2w, this);
				}
				return _stopWhenDestinationReached;
			}
			set
			{
				if (_stopWhenDestinationReached == value)
				{
					return;
				}
				_stopWhenDestinationReached = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionMoveWithPolicyTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}