using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQCItemQuantity : CQCActorInventory
	{
		[RED("item")] 		public CName Item { get; set;}

		[RED("itemCategory")] 		public CName ItemCategory { get; set;}

		[RED("itemTag")] 		public CName ItemTag { get; set;}

		[RED("quantity")] 		public CUInt32 Quantity { get; set;}

		[RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		public CQCItemQuantity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQCItemQuantity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}