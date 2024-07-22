namespace OpenGL_CS.Enums {
	public enum ShaderType : uint {
		Compute_Shader = (uint)ALL.GL_COMPUTE_SHADER,
		Vertex_Shader = (uint)ALL.GL_VERTEX_SHADER,
		Tesselation_Control_Shader = (uint)ALL.GL_TESS_CONTROL_SHADER,
		Tesselation_Evaluation_Shader = (uint)ALL.GL_TESS_EVALUATION_SHADER,
		Geometry_Shader = (uint)ALL.GL_GEOMETRY_SHADER,
		Fragment_Shader = (uint)ALL.GL_FRAGMENT_SHADER,
	}
}
