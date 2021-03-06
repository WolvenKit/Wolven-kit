using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlotInfo : CVariable
	{
		[Ordinal(1)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(2)] [RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[Ordinal(3)] [RED("parentSlotIndex")] 		public CInt32 ParentSlotIndex { get; set;}

		[Ordinal(4)] [RED("relativePosition")] 		public Vector RelativePosition { get; set;}

		[Ordinal(5)] [RED("relativeRotation")] 		public EulerAngles RelativeRotation { get; set;}

		public SSlotInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}