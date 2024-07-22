namespace OpenGL_CS.Enums {
	public enum DrawMode : uint {
		Points = (uint)ALL.GL_POINTS,
		Line_Strip = (uint)ALL.GL_LINE_STRIP,
		Line_Loop = (uint)ALL.GL_LINE_LOOP,
		Lines = (uint)ALL.GL_LINES,
		Line_Strip_Adjacency = (uint)ALL.GL_LINE_STRIP_ADJACENCY,
		Lines_Adjacency = (uint)ALL.GL_LINES_ADJACENCY,
		Triangle_Strip = (uint)ALL.GL_TRIANGLE_STRIP,
		Triangle_Fan = (uint)ALL.GL_TRIANGLE_FAN,
		Triangles = (uint)ALL.GL_TRIANGLES,
		Triangle_strip_Adjacency = (uint)ALL.GL_TRIANGLE_STRIP_ADJACENCY,
		Triangles_Adjacency = (uint)ALL.GL_TRIANGLES_ADJACENCY,
		Patches = (uint)ALL.GL_PATCHES,
	}
}
