using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlideToTargetEventProps : CVariable
	{
		[Ordinal(1)] [RED("minSlideDist")] 		public CFloat MinSlideDist { get; set;}

		[Ordinal(2)] [RED("maxSlideDist")] 		public CFloat MaxSlideDist { get; set;}

		[Ordinal(3)] [RED("slideToMaxDistIfTargetSeen")] 		public CBool SlideToMaxDistIfTargetSeen { get; set;}

		[Ordinal(4)] [RED("slideToMaxDistIfNoTarget")] 		public CBool SlideToMaxDistIfNoTarget { get; set;}

		public SSlideToTargetEventProps(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}