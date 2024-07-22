using System.Numerics;
using System.Text;

namespace OpenGL_CS {
	public static partial class API {
		public class Program : Object {
			public Program(IEnumerable<Shader> shaders) {
				Name = Bindings.glCreateProgram();

				foreach (var shader in shaders) {
					Bindings.glAttachShader(Name, shader.Name);
				}

				Bindings.glLinkProgram(Name);
			}

			public unsafe int GetUniformLocation(string name) {
				var bytes = Encoding.ASCII.GetBytes(name);

				fixed (byte* ptr = bytes) {
					return Bindings.glGetUniformLocation(Name, ptr);
				}
			}

			public void SetUniform(int location, int value) {
				Bindings.glProgramUniform1i(Name, location, value);
			}

			public void SetUniform(int location, float value) {
				Bindings.glProgramUniform1f(Name, location, value);
			}

			public void SetUniform(int location, double value) {
				Bindings.glProgramUniform1d(Name, location, value);
			}

			public void SetUniform(int location, Vector2 value) {
				Bindings.glProgramUniform2f(Name, location, value.X, value.Y);
			}

			public void SetUniform(int location, Vector3 value) {
				Bindings.glProgramUniform3f(Name, location, value.X, value.Y, value.Z);
			}

			public void SetUniform(int location, Vector4 value) {
				Bindings.glProgramUniform4f(Name, location, value.X, value.Y, value.Z, value.W);
			}

			public void SetUniform(int location, Matrix2x2 value, bool transpose = false) {
				unsafe {
					var ptr = stackalloc float[4];

					// TODO: Confirm that this is actually the correct layout
					ptr[0] = value.M11;
					ptr[1] = value.M12;
					ptr[2] = value.M21;
					ptr[3] = value.M22;

					Bindings.glProgramUniformMatrix2fv(Name, location, 1, transpose ? (byte)1 : (byte)0, ptr);
				}
			}

			public void SetUniform(int location, Matrix3x3 value, bool transpose = false) {
				unsafe {
					var ptr = stackalloc float[9];

					// TODO: Confirm that this is actually the correct layout
					ptr[0] = value.M11;
					ptr[1] = value.M12;
					ptr[2] = value.M13;
					ptr[3] = value.M21;
					ptr[4] = value.M22;
					ptr[5] = value.M23;
					ptr[6] = value.M31;
					ptr[7] = value.M32;
					ptr[8] = value.M33;

					Bindings.glProgramUniformMatrix3fv(Name, location, 1, transpose ? (byte)1 : (byte)0, ptr);
				}
			}

			public void SetUniform(int location, Matrix4x4 value, bool transpose = false) {
				unsafe {
					var ptr = stackalloc float[16];

					// TODO: Confirm that this is actually the correct layout
					ptr[0] = value.M11;
					ptr[1] = value.M12;
					ptr[2] = value.M13;
					ptr[3] = value.M14;
					ptr[4] = value.M21;
					ptr[5] = value.M22;
					ptr[6] = value.M23;
					ptr[7] = value.M24;
					ptr[8] = value.M31;
					ptr[9] = value.M32;
					ptr[10] = value.M33;
					ptr[11] = value.M34;
					ptr[12] = value.M41;
					ptr[13] = value.M42;
					ptr[14] = value.M43;
					ptr[15] = value.M44;

					Bindings.glProgramUniformMatrix4fv(Name, location, 1, transpose ? (byte)1 : (byte)0, ptr);
				}
			}

			public void Use() {
				Bindings.glUseProgram(Name);
			}
		}
	}
}
