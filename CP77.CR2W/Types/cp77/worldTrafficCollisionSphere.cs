using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCollisionSphere : CVariable
	{
		[Ordinal(0)]  [RED("direction")] public Vector3 Direction { get; set; }
		[Ordinal(1)]  [RED("flags")] public CUInt8 Flags { get; set; }
		[Ordinal(2)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)]  [RED("userData")] public CUInt64 UserData { get; set; }
		[Ordinal(4)]  [RED("worldPos")] public Vector3 WorldPos { get; set; }

		public worldTrafficCollisionSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}