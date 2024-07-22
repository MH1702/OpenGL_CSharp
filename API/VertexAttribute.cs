using static OpenGL_CS.Utility;

namespace OpenGL_CS {
	public static partial class API {
		public class VertexAttribute {
			public required string Name { get; init; }
			public required TypeData TypeData { get; init; }
			public bool Normalized { get; init; } = false;
		}
	}
}
