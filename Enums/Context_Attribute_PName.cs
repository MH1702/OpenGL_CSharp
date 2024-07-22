namespace OpenGL_CS.Enums {
	public enum Context_Attribute_PName : uint {
		Cull_Face_Mode = (uint)ALL.GL_CULL_FACE_MODE,
		Front_Face = (uint)ALL.GL_FRONT_FACE,
		Clear_Color_Value = (uint)ALL.GL_COLOR_CLEAR_VALUE,
		Clear_Depth_Value = (uint)ALL.GL_DEPTH_CLEAR_VALUE,
		Clear_Stencil_Value = (uint)ALL.GL_STENCIL_CLEAR_VALUE,
		Color_Writemask = (uint)ALL.GL_COLOR_WRITEMASK,
		Depth_Writemask = (uint)ALL.GL_DEPTH_WRITEMASK,
		Stencil_Writemask = (uint)ALL.GL_STENCIL_WRITEMASK,
		Viewport = (uint)ALL.GL_VIEWPORT,
		Line_Smoothing = (uint)ALL.GL_LINE_SMOOTH,
		Line_Smoothing_Mode = (uint)ALL.GL_LINE_SMOOTH_HINT,
		Point_Size = (uint)ALL.GL_POINT_SIZE,
		Polygon_Mode = (uint)ALL.GL_POLYGON_MODE,
		Scissor_Box = (uint)ALL.GL_SCISSOR_BOX,
		Draw_Buffer = (uint)ALL.GL_DRAW_BUFFER,

		Max_Vertex_Attrib_Bindings = (uint)ALL.GL_MAX_VERTEX_ATTRIB_BINDINGS,
		Max_Vertex_Attribs = (uint)ALL.GL_MAX_VERTEX_ATTRIBS,

		Depth_Test_Func = (uint)ALL.GL_DEPTH_FUNC,
	}
}
