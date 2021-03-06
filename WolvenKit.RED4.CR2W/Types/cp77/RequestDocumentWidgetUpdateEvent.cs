using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestDocumentWidgetUpdateEvent : RequestWidgetUpdateEvent
	{
		private CEnum<EDocumentType> _documentType;
		private SDocumentAdress _documentAdress;

		[Ordinal(2)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetProperty(ref _documentType);
			set => SetProperty(ref _documentType, value);
		}

		[Ordinal(3)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetProperty(ref _documentAdress);
			set => SetProperty(ref _documentAdress, value);
		}

		public RequestDocumentWidgetUpdateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
