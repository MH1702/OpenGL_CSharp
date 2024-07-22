namespace OpenGL_CS.Enums {
	public enum TextureMinFilter : uint {
		Nearest = (uint)ALL.GL_NEAREST,
		Linear = (uint)ALL.GL_LINEAR,
		Nearest_Mipmap_Nearest = (uint)ALL.GL_NEAREST_MIPMAP_NEAREST,
		Nearest_Mipmap_Linear = (uint)ALL.GL_NEAREST_MIPMAP_LINEAR,
		Linear_Mipmap_Nearest = (uint)ALL.GL_LINEAR_MIPMAP_NEAREST,
		Linear_Mipmap_Linear = (uint)ALL.GL_LINEAR_MIPMAP_LINEAR,
	}
}
