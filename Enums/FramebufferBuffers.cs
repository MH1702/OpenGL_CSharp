namespace OpenGL_CS.Enums {
	[Flags]
	public enum FramebufferBuffers : uint {
		Color = (uint)ALL.GL_COLOR_BUFFER_BIT,
		Depth = (uint)ALL.GL_DEPTH_BUFFER_BIT,
		Stencil = (uint)ALL.GL_STENCIL_BUFFER_BIT,
		All = Color | Depth | Stencil,
	}
}
