using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineActionParameterCName : CVariable
	{
		private CName _name;
		private CName _value;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CName Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gamestateMachineActionParameterCName(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
