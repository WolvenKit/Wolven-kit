using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBaseStateOperationData : CVariable
	{
		private CEnum<EDeviceStatus> _state;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (SBaseDeviceOperationData) CR2WTypeManager.Create("SBaseDeviceOperationData", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		public SBaseStateOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}