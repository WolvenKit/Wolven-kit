using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStatistic : CVariable
	{
		[RED("statType")] 		public CEnum<EStatistic> StatType { get; set;}

		[RED("registeredAchievements", 2,0)] 		public CArray<SAchievement> RegisteredAchievements { get; set;}

		public SStatistic(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SStatistic(cr2w);

	}
}