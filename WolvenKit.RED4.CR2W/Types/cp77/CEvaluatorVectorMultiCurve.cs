using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorMultiCurve : IEvaluatorVector
	{
		private multiChannelCurve<CFloat> _curves;
		private CUInt32 _numberOfCurveSamples;

		[Ordinal(2)] 
		[RED("curves")] 
		public multiChannelCurve<CFloat> Curves
		{
			get => GetProperty(ref _curves);
			set => SetProperty(ref _curves, value);
		}

		[Ordinal(3)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get => GetProperty(ref _numberOfCurveSamples);
			set => SetProperty(ref _numberOfCurveSamples, value);
		}

		public CEvaluatorVectorMultiCurve(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
