using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPoseSlotNode : CBehaviorGraphBaseNode
	{
		[RED("slotName")] 		public CName SlotName { get; set;}

		[RED("firstBone")] 		public CString FirstBone { get; set;}

		[RED("worldSpace")] 		public CBool WorldSpace { get; set;}

		[RED("interpolation")] 		public CEnum<EInterpolationType> Interpolation { get; set;}

		[RED("blendFloatTracks")] 		public CBool BlendFloatTracks { get; set;}

		[RED("ignoreZeroFloatTracks")] 		public CBool IgnoreZeroFloatTracks { get; set;}

		public CBehaviorGraphPoseSlotNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphPoseSlotNode(cr2w);

	}
}