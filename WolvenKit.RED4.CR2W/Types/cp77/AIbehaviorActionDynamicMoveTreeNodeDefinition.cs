using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionDynamicMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _moveType;
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _targetPosition;
		private CHandle<AIArgumentMapping> _toleranceRadius;
		private CHandle<AIArgumentMapping> _desiredDistanceFromTarget;
		private CHandle<AIArgumentMapping> _strafingTarget;
		private CHandle<AIArgumentMapping> _stopWhenDestinationReached;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _ignoreNavigation;

		[Ordinal(1)] 
		[RED("moveType")] 
		public CHandle<AIArgumentMapping> MoveType
		{
			get
			{
				if (_moveType == null)
				{
					_moveType = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "moveType", cr2w, this);
				}
				return _moveType;
			}
			set
			{
				if (_moveType == value)
				{
					return;
				}
				_moveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetPosition")] 
		public CHandle<AIArgumentMapping> TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("toleranceRadius")] 
		public CHandle<AIArgumentMapping> ToleranceRadius
		{
			get
			{
				if (_toleranceRadius == null)
				{
					_toleranceRadius = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "toleranceRadius", cr2w, this);
				}
				return _toleranceRadius;
			}
			set
			{
				if (_toleranceRadius == value)
				{
					return;
				}
				_toleranceRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("desiredDistanceFromTarget")] 
		public CHandle<AIArgumentMapping> DesiredDistanceFromTarget
		{
			get
			{
				if (_desiredDistanceFromTarget == null)
				{
					_desiredDistanceFromTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "desiredDistanceFromTarget", cr2w, this);
				}
				return _desiredDistanceFromTarget;
			}
			set
			{
				if (_desiredDistanceFromTarget == value)
				{
					return;
				}
				_desiredDistanceFromTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("strafingTarget")] 
		public CHandle<AIArgumentMapping> StrafingTarget
		{
			get
			{
				if (_strafingTarget == null)
				{
					_strafingTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "strafingTarget", cr2w, this);
				}
				return _strafingTarget;
			}
			set
			{
				if (_strafingTarget == value)
				{
					return;
				}
				_strafingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stopWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> StopWhenDestinationReached
		{
			get
			{
				if (_stopWhenDestinationReached == null)
				{
					_stopWhenDestinationReached = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "stopWhenDestinationReached", cr2w, this);
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

		[Ordinal(8)] 
		[RED("rotateEntity")] 
		public CHandle<AIArgumentMapping> RotateEntity
		{
			get
			{
				if (_rotateEntity == null)
				{
					_rotateEntity = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rotateEntity", cr2w, this);
				}
				return _rotateEntity;
			}
			set
			{
				if (_rotateEntity == value)
				{
					return;
				}
				_rotateEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ignoreNavigation")] 
		public CHandle<AIArgumentMapping> IgnoreNavigation
		{
			get
			{
				if (_ignoreNavigation == null)
				{
					_ignoreNavigation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreNavigation", cr2w, this);
				}
				return _ignoreNavigation;
			}
			set
			{
				if (_ignoreNavigation == value)
				{
					return;
				}
				_ignoreNavigation = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionDynamicMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}