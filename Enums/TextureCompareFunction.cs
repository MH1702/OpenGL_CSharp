namespace OpenGL_CS.Enums {
	public enum TextureCompareFunction : uint {
		Less_or_Equal = (uint)ALL.GL_LEQUAL,
		Greater_or_Equal = (uint)ALL.GL_GEQUAL,
		Less = (uint)ALL.GL_LESS,
		Greater = (uint)ALL.GL_GREATER,
		Equal = (uint)ALL.GL_EQUAL,
		Not_Equal = (uint)ALL.GL_NOTEQUAL,
		Always = (uint)ALL.GL_ALWAYS,
		Never = (uint)ALL.GL_NEVER,
	}
}
