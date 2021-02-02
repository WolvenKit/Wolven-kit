using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EyesLookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("weightALink")] public animFloatLink WeightALink { get; set; }
		[Ordinal(1)]  [RED("weightBLink")] public animFloatLink WeightBLink { get; set; }
		[Ordinal(2)]  [RED("transitionWeightLink")] public animFloatLink TransitionWeightLink { get; set; }
		[Ordinal(3)]  [RED("targetALink")] public animVectorLink TargetALink { get; set; }
		[Ordinal(4)]  [RED("targetBLink")] public animVectorLink TargetBLink { get; set; }
		[Ordinal(5)]  [RED("leftEye")] public animTransformIndex LeftEye { get; set; }
		[Ordinal(6)]  [RED("rightEye")] public animTransformIndex RightEye { get; set; }
		[Ordinal(7)]  [RED("head")] public animTransformIndex Head { get; set; }
		[Ordinal(8)]  [RED("forwardDirection")] public CEnum<animAxis> ForwardDirection { get; set; }

		public animAnimNode_EyesLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
