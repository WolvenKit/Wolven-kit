using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSimpleCurve : CVariable
	{
		[RED("CurveType")] 		public CEnum<ESimpleCurveType> CurveType { get; set;}

		[RED("ScalarEditScale")] 		public CFloat ScalarEditScale { get; set;}

		[RED("ScalarEditOrigin")] 		public CFloat ScalarEditOrigin { get; set;}

		[RED("dataCurveValues", 142,0)] 		public CArray<SCurveDataEntry> DataCurveValues { get; set;}

		[RED("dataBaseType")] 		public CEnum<ECurveBaseType> DataBaseType { get; set;}

		public SSimpleCurve(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSimpleCurve(cr2w);

	}
}