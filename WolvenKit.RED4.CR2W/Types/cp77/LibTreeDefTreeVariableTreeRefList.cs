using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableTreeRefList : LibTreeDefTreeVariable
	{
		private CBool _exportAsProperty;
		private CArray<CHandle<LibTreeCTreeReference>> _defaultValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get
			{
				if (_exportAsProperty == null)
				{
					_exportAsProperty = (CBool) CR2WTypeManager.Create("Bool", "exportAsProperty", cr2w, this);
				}
				return _exportAsProperty;
			}
			set
			{
				if (_exportAsProperty == value)
				{
					return;
				}
				_exportAsProperty = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultValue")] 
		public CArray<CHandle<LibTreeCTreeReference>> DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CArray<CHandle<LibTreeCTreeReference>>) CR2WTypeManager.Create("array:handle:LibTreeCTreeReference", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		public LibTreeDefTreeVariableTreeRefList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}