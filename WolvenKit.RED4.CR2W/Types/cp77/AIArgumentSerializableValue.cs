using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentSerializableValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CHandle<ISerializable> _defaultValue;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CHandle<ISerializable> DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public AIArgumentSerializableValue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
