namespace OpenGL_CS.Enums {
	public enum TextureParameters : uint {
		Depth_Stencil_Texture_Mode = (uint)ALL.GL_DEPTH_STENCIL_TEXTURE_MODE,
		Texture_Base_Level = (uint)ALL.GL_TEXTURE_BASE_LEVEL,
		Texture_Border_Color = (uint)ALL.GL_TEXTURE_BORDER_COLOR,
		Texture_Compare_Function = (uint)ALL.GL_TEXTURE_COMPARE_FUNC,
		Texture_Compare_Mode = (uint)ALL.GL_TEXTURE_COMPARE_MODE,
		Texture_LOD_Bias = (uint)ALL.GL_TEXTURE_LOD_BIAS,
		Texture_Min_Filter = (uint)ALL.GL_TEXTURE_MIN_FILTER,
		Texture_Mag_Filter = (uint)ALL.GL_TEXTURE_MAG_FILTER,
		Texture_Min_LOD = (uint)ALL.GL_TEXTURE_MIN_LOD,
		Texture_Max_LOD = (uint)ALL.GL_TEXTURE_MAX_LOD,
		Texture_Max_Level = (uint)ALL.GL_TEXTURE_MAX_LEVEL,
		// TODO: Swizzle and Wrap
	}
}
