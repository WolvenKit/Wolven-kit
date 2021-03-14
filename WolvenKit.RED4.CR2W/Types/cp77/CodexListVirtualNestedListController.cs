using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualNestedListController : VirtualNestedListController
	{
		private wCHandle<CodexListVirtualNestedDataView> _currentDataView;

		[Ordinal(13)] 
		[RED("currentDataView")] 
		public wCHandle<CodexListVirtualNestedDataView> CurrentDataView
		{
			get
			{
				if (_currentDataView == null)
				{
					_currentDataView = (wCHandle<CodexListVirtualNestedDataView>) CR2WTypeManager.Create("whandle:CodexListVirtualNestedDataView", "currentDataView", cr2w, this);
				}
				return _currentDataView;
			}
			set
			{
				if (_currentDataView == value)
				{
					return;
				}
				_currentDataView = value;
				PropertySet(this);
			}
		}

		public CodexListVirtualNestedListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}