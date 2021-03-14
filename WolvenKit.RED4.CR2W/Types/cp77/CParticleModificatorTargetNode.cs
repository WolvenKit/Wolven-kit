using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTargetNode : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _forceScale;
		private CHandle<IEvaluatorFloat> _killRadius;
		private CFloat _maxForce;

		[Ordinal(4)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get
			{
				if (_forceScale == null)
				{
					_forceScale = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "forceScale", cr2w, this);
				}
				return _forceScale;
			}
			set
			{
				if (_forceScale == value)
				{
					return;
				}
				_forceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("killRadius")] 
		public CHandle<IEvaluatorFloat> KillRadius
		{
			get
			{
				if (_killRadius == null)
				{
					_killRadius = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "killRadius", cr2w, this);
				}
				return _killRadius;
			}
			set
			{
				if (_killRadius == value)
				{
					return;
				}
				_killRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxForce")] 
		public CFloat MaxForce
		{
			get
			{
				if (_maxForce == null)
				{
					_maxForce = (CFloat) CR2WTypeManager.Create("Float", "maxForce", cr2w, this);
				}
				return _maxForce;
			}
			set
			{
				if (_maxForce == value)
				{
					return;
				}
				_maxForce = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorTargetNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}