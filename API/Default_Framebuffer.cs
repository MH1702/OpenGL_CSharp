using OpenGL_CS.Enums;

namespace OpenGL_CS {
	public static partial class API {
		public static class Default_Framebuffer {
			public static void Clear(FramebufferBuffers buffers) {
				Bindings.glClear((uint)buffers);
			}

			public static class ColorBuffers {
				public static Default_Framebuffer_Color_Buffers Writable {
					get => (Default_Framebuffer_Color_Buffers)Get_Integer((uint)Context_Attribute_PName.Draw_Buffer);
					set => Bindings.glDrawBuffer((uint)value);
				}

				public static Blending Blending {
					get => throw new NotImplementedException();
					set {
						Bindings.glBlendFunc((uint)value.From, (uint)value.To);
					}
				}

				public static Color Clear_Value {
					get => Get_Float_Array_As<Color>((uint)Context_Attribute_PName.Clear_Color_Value, 4);
					set => Bindings.glClearColor(value.R, value.G, value.B, value.A);
				}

				public static Color_Mask Mask {
					get => Get_Integer_Array_As<Color_Mask>((uint)Context_Attribute_PName.Color_Writemask, 4);
					set => Bindings.glColorMask(value.R ? (byte)1 : (byte)0, value.G ? (byte)1 : (byte)0, value.B ? (byte)1 : (byte)0, value.A ? (byte)1 : (byte)0);
				}
			}

			public static class DepthBuffer {
				public static int Clear_Value {
					get => Get_Integer((uint)Context_Attribute_PName.Clear_Depth_Value);
					set => Bindings.glClearDepth(value);
				}

				public static bool Mask {
					get => Get_Integer((uint)Context_Attribute_PName.Depth_Writemask) > 0;
					set => Bindings.glDepthMask(value ? (byte)1 : (byte)0);
				}
			}

			public static class StencilBuffer {
				public static int Clear_Value {
					get => Get_Integer((uint)Context_Attribute_PName.Clear_Stencil_Value);
					set => Bindings.glClearStencil(value);
				}

				public static bool Mask {
					get => Get_Integer((uint)Context_Attribute_PName.Stencil_Writemask) > 0;
					set => Bindings.glStencilMask(value ? (byte)1 : (byte)0);
				}
			}
		}
	}
}
