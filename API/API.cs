using OpenGL_CS.Enums;
using System.Drawing;
using System.Runtime.InteropServices;

namespace OpenGL_CS {
	public static partial class API {
		public class OpenGlException : Exception {
			public OpenGlException() {
			}

			public OpenGlException(string? message) : base(message) {
			}

			public OpenGlException(string? message, Exception? innerException) : base(message, innerException) {
			}
		}

		public static void CheckError() {
			var error = Bindings.glGetError();
			if (error != 0) {
				throw new OpenGlException($"OpenGL error: {error}");
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct Color(float r, float g, float b, float a) {
			public float R { get; set; } = r;
			public float G { get; set; } = g;
			public float B { get; set; } = b;
			public float A { get; set; } = a;

			public override readonly string ToString() {
				return $"{{{R}, {G}, {B}, {A}}}";
			}

			public static readonly Color Red = new() { R = 1.0f, G = 0.0f, B = 0.0f, A = 1.0f };
			public static readonly Color Green = new() { R = 0.0f, G = 1.0f, B = 0.0f, A = 1.0f };
			public static readonly Color Blue = new() { R = 0.0f, G = 0.0f, B = 1.0f, A = 1.0f };

			public static readonly Color Yellow = new() { R = 1.0f, G = 1.0f, B = 0.0f, A = 1.0f };
			public static readonly Color Magenta = new() { R = 1.0f, G = 0.0f, B = 1.0f, A = 1.0f };
			public static readonly Color Cyan = new() { R = 0.0f, G = 1.0f, B = 1.0f, A = 1.0f };

			public static readonly Color White = new() { R = 1.0f, G = 1.0f, B = 1.0f, A = 1.0f };
			public static readonly Color Black = new() { R = 0.0f, G = 0.0f, B = 0.0f, A = 1.0f };

			public static readonly Color Grey = new() { R = 0.5f, G = 0.5f, B = 0.5f, A = 1.0f };

			public static readonly Color Transparent = new() { R = 0.0f, G = 0.0f, B = 0.0f, A = 0.0f };
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct Color_Mask {
			public bool R { get; set; }
			public bool G { get; set; }
			public bool B { get; set; }
			public bool A { get; set; }

			public override readonly string ToString() {
				return $"{{{R}, {G}, {B}, {A}}}";
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		public struct Blending {
			public BlendFactor From { get; set; }
			public BlendFactor To { get; set; }
		}

		public static Rectangle Viewport {
			get => Get_Integer_Array_As<Rectangle>((uint)Context_Attribute_PName.Viewport, 4);
			set => Bindings.glViewport(value.X, value.Y, value.Width, value.Height);
		}

		public static Rectangle Scissor_Box {
			get => Get_Integer_Array_As<Rectangle>((uint)Context_Attribute_PName.Scissor_Box, 4);
			set => Bindings.glScissor(value.X, value.Y, value.Width, value.Height);
		}

		public static unsafe bool Get_Boolean(uint pname) {
			byte* ptr = stackalloc byte[1];

			Bindings.glGetBooleanv(pname, ptr);

			return *ptr > 0;
		}

		public static unsafe int Get_Integer(uint pname) {
			int* ptr = stackalloc int[1];

			Bindings.glGetIntegerv(pname, ptr);

			return *ptr;
		}

		public static unsafe float Get_Float(uint pname) {
			float* ptr = stackalloc float[1];

			Bindings.glGetFloatv(pname, ptr);

			return *ptr;
		}

		public static unsafe T Get_Integer_Array_As<T>(uint pname, int size) where T : struct {
			int* ptr = stackalloc int[size];

			Bindings.glGetIntegerv(pname, ptr);

			return Marshal.PtrToStructure<T>((nint)ptr);
		}

		public static unsafe T Get_Float_Array_As<T>(uint pname, int size) where T : struct {
			float* ptr = stackalloc float[size];

			Bindings.glGetFloatv(pname, ptr);

			return Marshal.PtrToStructure<T>((nint)ptr);
		}

		public class Texture {
			public readonly TextureTarget target;

			public DepthStencilTextureMode Depth_Stencil_Mode {
				get => (DepthStencilTextureMode)Get_Tex_Parameter_Integer((uint)target, (uint)TextureParameters.Depth_Stencil_Texture_Mode);
				set => Bindings.glTexParameteri((uint)target, (uint)TextureParameters.Depth_Stencil_Texture_Mode, (int)value);
			}

			internal int Get_Tex_Parameter_Integer(uint target, uint pname) {
				unsafe {
					int* ptr = stackalloc int[1];

					Bindings.glGetTexParameteriv(target, pname, ptr);

					return *ptr;
				}
			}

			internal float Get_Tex_Parameter_Float(uint target, uint pname) {
				unsafe {
					float* ptr = stackalloc float[1];

					Bindings.glGetTexParameterfv(target, pname, ptr);

					return *ptr;
				}
			}
		}

		public static void Finish() {
			Bindings.glFinish();
		}

		public static void Flush() {
			Bindings.glFlush();
		}

		public static class Settings {
			public static class Lines {
				public static float Width {
					get {
						return 0f;
					}
					set {
						Bindings.glLineWidth(value);
					}
				}

				public static LineSmoothingMode Smoothing {
					get {
						if (Get_Integer((uint)Context_Attribute_PName.Line_Smoothing) > 0) {
							return (LineSmoothingMode)Get_Integer((uint)Context_Attribute_PName.Line_Smoothing_Mode);
						}
						else {
							return LineSmoothingMode.Disabled;
						}
					}
					set {
						if (value == LineSmoothingMode.Disabled) {
							Bindings.glDisable((uint)Context_Attribute_PName.Line_Smoothing);
						}
						else {
							Bindings.glEnable((uint)Context_Attribute_PName.Line_Smoothing);
							Bindings.glHint((uint)Hints.Line_Smoothing, (uint)(value));
						}
					}
				}
			}

			public static class Faces {
				public static CullFaceMode Cull_Mode {
					get => (CullFaceMode)Get_Integer((uint)Context_Attribute_PName.Cull_Face_Mode);
					set => Bindings.glCullFace((uint)value);
				}

				public static WindingOrder Winding_Order {
					get => (WindingOrder)Get_Integer((uint)Context_Attribute_PName.Front_Face);
					set => Bindings.glFrontFace((uint)value);
				}
			}

			public static class Points {
				public static float Size {
					get => Get_Float((uint)Context_Attribute_PName.Point_Size);
					set => Bindings.glPointSize((uint)value);
				}
			}

			public static class Rasterizer {
				public static RasterizerMode Mode {
					get => (RasterizerMode)Get_Integer((uint)Context_Attribute_PName.Polygon_Mode);
					set => Bindings.glPolygonMode((uint)CullFaceMode.Front_and_Back, (uint)value);
				}
			}

			public static class PerSample {
				public static bool DepthTestingEnabled {
					get => Get_Boolean((uint)Capabilities.Depth_Test);
					set {
						if (value) {
							Bindings.glEnable((uint)Capabilities.Depth_Test);
						}
                        else
                        {
							Bindings.glDisable((uint)Capabilities.Depth_Test);
						}
                    }
				}

				public static DepthTestingFunction DepthTestingFunction {
					get => (DepthTestingFunction)Get_Integer((uint)Context_Attribute_PName.Depth_Test_Func);
					set => Bindings.glDepthFunc((uint)value);
				}
			}
		}
	}
}
