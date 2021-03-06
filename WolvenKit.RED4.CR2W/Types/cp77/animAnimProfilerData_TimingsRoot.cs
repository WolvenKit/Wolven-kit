using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TimingsRoot : ISerializable
	{
		private CArray<animAnimProfilerData_Timings> _timings;

		[Ordinal(0)] 
		[RED("timings")] 
		public CArray<animAnimProfilerData_Timings> Timings
		{
			get => GetProperty(ref _timings);
			set => SetProperty(ref _timings, value);
		}

		public animAnimProfilerData_TimingsRoot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
