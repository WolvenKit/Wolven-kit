using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CTerrainTile : CResource
	{
		[RED("tileFileVersion")] 		public CUInt32 TileFileVersion { get; set;}

		[RED("collisionType")] 		public CEnum<ETerrainTileCollision> CollisionType { get; set;}

		[RED("maxHeightValue")] 		public CUInt16 MaxHeightValue { get; set;}

		[RED("minHeightValue")] 		public CUInt16 MinHeightValue { get; set;}


		public override CVariable Create(CR2WFile cr2w) => new CTerrainTile(cr2w);

	}
}