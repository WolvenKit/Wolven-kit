using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeleteEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		private CString _setName;

		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get
			{
				if (_setName == null)
				{
					_setName = (CString) CR2WTypeManager.Create("String", "setName", cr2w, this);
				}
				return _setName;
			}
			set
			{
				if (_setName == value)
				{
					return;
				}
				_setName = value;
				PropertySet(this);
			}
		}

		public DeleteEquipmentSetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}