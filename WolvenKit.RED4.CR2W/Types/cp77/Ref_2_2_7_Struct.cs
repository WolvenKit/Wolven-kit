using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_2_2_7_Struct : CVariable
	{
		private CInt32 _val;

		[Ordinal(0)] 
		[RED("val")] 
		public CInt32 Val
		{
			get
			{
				if (_val == null)
				{
					_val = (CInt32) CR2WTypeManager.Create("Int32", "val", cr2w, this);
				}
				return _val;
			}
			set
			{
				if (_val == value)
				{
					return;
				}
				_val = value;
				PropertySet(this);
			}
		}

		public Ref_2_2_7_Struct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}