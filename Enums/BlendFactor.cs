namespace OpenGL_CS.Enums {
	public enum BlendFactor : uint {
		Zero = (uint)ALL.GL_ZERO,
		One = (uint)ALL.GL_ONE,
		Src_Color = (uint)ALL.GL_SRC_COLOR,
		One_minus_Src_Color = (uint)ALL.GL_ONE_MINUS_SRC_COLOR,
		Dst_Color = (uint)ALL.GL_DST_COLOR,
		One_minus_Dst_Color = (uint)ALL.GL_ONE_MINUS_DST_COLOR,
		Src_Alpha = (uint)ALL.GL_SRC_ALPHA,
		One_minus_Src_Alpha = (uint)ALL.GL_ONE_MINUS_SRC_ALPHA,
		Dst_Alpha = (uint)ALL.GL_DST_ALPHA,
		One_minus_Dst_Alpha = (uint)ALL.GL_ONE_MINUS_DST_ALPHA,
		Constant_Color = (uint)ALL.GL_CONSTANT_COLOR,
		One_minus_Constant_Color = (uint)ALL.GL_ONE_MINUS_CONSTANT_COLOR,
		Constant_Alpha = (uint)ALL.GL_CONSTANT_ALPHA,
		One_minus_Constant_Alpha = (uint)ALL.GL_ONE_MINUS_CONSTANT_ALPHA,
	}
}
