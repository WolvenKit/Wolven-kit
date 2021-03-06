using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMovementTypeSpec : CVariable
	{
		private CBool _useNPCMovementParams;
		private CEnum<moveMovementType> _movementType;

		[Ordinal(0)] 
		[RED("useNPCMovementParams")] 
		public CBool UseNPCMovementParams
		{
			get => GetProperty(ref _useNPCMovementParams);
			set => SetProperty(ref _useNPCMovementParams, value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		public AIMovementTypeSpec(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
