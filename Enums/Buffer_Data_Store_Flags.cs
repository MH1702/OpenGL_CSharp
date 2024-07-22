namespace OpenGL_CS.Enums {
	[Flags]
	public enum Buffer_Data_Store_Flags : uint {
		Dynamic_Storage = (uint)ALL.GL_DYNAMIC_STORAGE_BIT,
		Map_Read = (uint)ALL.GL_MAP_READ_BIT,
		Map_Write = (uint)ALL.GL_MAP_WRITE_BIT,
		Map_Persistent = (uint)ALL.GL_MAP_PERSISTENT_BIT,
		Map_Coherent = (uint)ALL.GL_MAP_COHERENT_BIT,
		Client_Storage = (uint)ALL.GL_CLIENT_STORAGE_BIT,
	}
}
