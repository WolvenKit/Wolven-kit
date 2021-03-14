using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationChain : IScriptable
	{
		private CArray<AnimationElement> _data;
		private CName _name;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<AnimationElement> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<AnimationElement>) CR2WTypeManager.Create("array:AnimationElement", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		public AnimationChain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}