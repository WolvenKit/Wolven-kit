using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardShot : CObject
	{
		[Ordinal(1)] [RED("shotname")] 		public CString Shotname { get; set;}

		[Ordinal(2)] [RED("camSettings")] 		public SStoryBoardCameraSettings CamSettings { get; set;}

		[Ordinal(3)] [RED("assetSettings", 2,0)] 		public CArray<SStoryBoardShotAssetSettings> AssetSettings { get; set;}

		public CModStoryBoardShot(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}