using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITrafficWorkspotDefinition : worldTrafficSpotDefinition
	{
		private rRef<workWorkspotResource> _workspotResource;

		[Ordinal(2)] 
		[RED("workspotResource")] 
		public rRef<workWorkspotResource> WorkspotResource
		{
			get
			{
				if (_workspotResource == null)
				{
					_workspotResource = (rRef<workWorkspotResource>) CR2WTypeManager.Create("rRef:workWorkspotResource", "workspotResource", cr2w, this);
				}
				return _workspotResource;
			}
			set
			{
				if (_workspotResource == value)
				{
					return;
				}
				_workspotResource = value;
				PropertySet(this);
			}
		}

		public AITrafficWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}