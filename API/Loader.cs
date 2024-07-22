using System.Runtime.InteropServices;

namespace OpenGL_CS {
	public static partial class Loader {
#if PLATFORM_WINDOWS
		[LibraryImport("opengl32", SetLastError = true)]
		[UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
		private static partial nint wglGetProcAddress(nint name_ptr);

		[LibraryImport("Kernel32", SetLastError = true)]
		[UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
		private static partial nint GetProcAddress(nint handle, nint name_ptr);

		[LibraryImport("Kernel32", SetLastError = true)]
		[UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
		private static partial nint GetModuleHandleA(nint name_ptr);

		internal static nint opengl32_handle;

		static Loader() {
			var name_ptr = Marshal.StringToHGlobalAnsi("opengl32");

			opengl32_handle = GetModuleHandleA(name_ptr);

			Marshal.FreeHGlobal(name_ptr);
		}

		public static nint GetProcAddress(string name, int major_version, int minor_version) {

			var name_ptr = Marshal.StringToHGlobalAnsi(name);

			nint fn_ptr;

			if (major_version == 1 && minor_version <= 1) {
				fn_ptr = GetProcAddress(opengl32_handle, name_ptr);
			} else {
				fn_ptr = wglGetProcAddress(name_ptr);
			}
			
			Marshal.FreeHGlobal(name_ptr);

			return fn_ptr;
		}
#endif
	}
}
