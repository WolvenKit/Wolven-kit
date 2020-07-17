using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Crossbow : RangedWeapon
	{
		[RED("shotCount")] 		public CInt32 ShotCount { get; set;}

		[RED("shotCountLimit")] 		public CInt32 ShotCountLimit { get; set;}

		[RED("reloadAtStartComplete")] 		public CBool ReloadAtStartComplete { get; set;}

		public Crossbow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new Crossbow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}