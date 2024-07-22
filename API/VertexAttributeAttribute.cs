using OpenGL_CS.Enums;

namespace OpenGL_CS {
	public static partial class API {
		[AttributeUsage(AttributeTargets.Field)]
		public class VertexAttributeAttribute(bool normalized = false, VertexAttributeType? special_type = null) : Attribute {
			public bool Normalized = normalized;
			public VertexAttributeType? SpecialType = special_type;
		}
	}
}
