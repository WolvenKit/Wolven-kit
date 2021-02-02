using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worlduiSceneWidgetProperties : CVariable
	{
		[Ordinal(0)]  [RED("faceVector")] public Vector3 FaceVector { get; set; }
		[Ordinal(1)]  [RED("projectionPlaneSize")] public Vector2 ProjectionPlaneSize { get; set; }
		[Ordinal(2)]  [RED("maxInteractionDistance")] public CFloat MaxInteractionDistance { get; set; }
		[Ordinal(3)]  [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(4)]  [RED("useCustomFaceVector")] public CBool UseCustomFaceVector { get; set; }
		[Ordinal(5)]  [RED("isInteractable")] public CBool IsInteractable { get; set; }
		[Ordinal(6)]  [RED("isInteractableFromBehind")] public CBool IsInteractableFromBehind { get; set; }

		public worlduiSceneWidgetProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
