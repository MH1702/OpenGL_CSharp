using OpenGL_CS.Enums;
using System.Text;

namespace OpenGL_CS {
	public static partial class API {
		public unsafe class Shader : Object {
			public Shader(ShaderType type) {
				Name = Bindings.glCreateShader((uint)type);
			}

			public static Shader FromSource(ShaderType type, string source) {
				var shader = new Shader(type);

				var source_ascii = Encoding.ASCII.GetBytes(source);

				fixed (byte* source_ascii_ptr = source_ascii) {

					byte** sources_ptr = stackalloc byte*[1];
					sources_ptr[0] = source_ascii_ptr;

					int* lengths_ptr = stackalloc int[1];
					lengths_ptr[0] = source_ascii.Length;

					Bindings.glShaderSource(shader.Name, 1, sources_ptr, lengths_ptr);

					Bindings.glCompileShader(shader.Name);

					//int* length_ptr = stackalloc int[1];
					//byte* log_ptr = stackalloc byte[1000];
					//Bindings.glGetShaderInfoLog(shader.Name, 1000, length_ptr, log_ptr);
					//Console.WriteLine(Encoding.ASCII.GetString(log_ptr, *length_ptr));
					//Console.WriteLine(source);

				}

				return shader;
			}
		}
	}
}
