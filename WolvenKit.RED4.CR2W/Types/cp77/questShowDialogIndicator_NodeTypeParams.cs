using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowDialogIndicator_NodeTypeParams : CVariable
	{
		private gameEntityReference _objectRef;
		private CBool _show;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get
			{
				if (_show == null)
				{
					_show = (CBool) CR2WTypeManager.Create("Bool", "show", cr2w, this);
				}
				return _show;
			}
			set
			{
				if (_show == value)
				{
					return;
				}
				_show = value;
				PropertySet(this);
			}
		}

		public questShowDialogIndicator_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}