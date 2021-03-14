using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanNPCRun : AIbehaviorconditionScript
	{
		private CInt32 _maxRunners;

		[Ordinal(0)] 
		[RED("maxRunners")] 
		public CInt32 MaxRunners
		{
			get
			{
				if (_maxRunners == null)
				{
					_maxRunners = (CInt32) CR2WTypeManager.Create("Int32", "maxRunners", cr2w, this);
				}
				return _maxRunners;
			}
			set
			{
				if (_maxRunners == value)
				{
					return;
				}
				_maxRunners = value;
				PropertySet(this);
			}
		}

		public CanNPCRun(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}