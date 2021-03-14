using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionVector_ : animAnimNode_VectorValue
	{
		private animMathExpressionNodeData _expressionData;

		[Ordinal(11)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get
			{
				if (_expressionData == null)
				{
					_expressionData = (animMathExpressionNodeData) CR2WTypeManager.Create("animMathExpressionNodeData", "expressionData", cr2w, this);
				}
				return _expressionData;
			}
			set
			{
				if (_expressionData == value)
				{
					return;
				}
				_expressionData = value;
				PropertySet(this);
			}
		}

		public animAnimNode_MathExpressionVector_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}