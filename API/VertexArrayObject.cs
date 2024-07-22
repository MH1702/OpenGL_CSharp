using OpenGL_CS.Enums;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL_CS {
	public static partial class API {
		public unsafe class VertexArrayObject : Object {
			public VertexArrayObject(List<Buffer.View> attribute_views) {
				uint* name_ptr = stackalloc uint[1];

				Bindings.glCreateVertexArrays(1, name_ptr);

				Name = *name_ptr;

				uint view_index = 0;
				uint attrib_index = 0;

				foreach (var view in attribute_views) {
					Bindings.glVertexArrayVertexBuffer(Name, view_index, view.Buffer.Name, (int)view.Offset, (int)view.Stride);

					foreach (var attribute in view.Attributes) {
						Bindings.glVertexArrayAttribFormat(Name, attrib_index, attribute.VertexAttribute.TypeData.number_of_components, (uint)attribute.VertexAttribute.TypeData.ComponentType, attribute.VertexAttribute.Normalized ? (byte)0 : (byte)1, attribute.RelativeOffset);

						Bindings.glVertexArrayAttribBinding(Name, attrib_index, view_index);

						Bindings.glEnableVertexArrayAttrib(Name, attrib_index);

						attrib_index++;
					}

					view_index++;
				}
			}

			public string Label {
				get {
					var label_ptr = stackalloc byte[128];
					var length_ptr = stackalloc int[1];

					Bindings.glGetObjectLabel((uint)ObjectIdentifier.Vertex_Array, Name, 128, length_ptr, label_ptr);

					return Marshal.PtrToStringAnsi((nint)label_ptr, *length_ptr);
				}
				set {
					var label_ascii_bytes = Encoding.ASCII.GetBytes(value);

					fixed (byte* label_ascii_ptr = label_ascii_bytes) {
						Bindings.glObjectLabel((uint)ObjectIdentifier.Vertex_Array, Name, label_ascii_bytes.Length, label_ascii_ptr);
					}
				}
			}

			public void Bind() {
				Bindings.glBindVertexArray(Name);
			}

			public static void Unbind() {
				Bindings.glBindVertexArray(0);
			}

			public void Draw(int count, int first = 0, DrawMode mode = DrawMode.Triangles) {
				Bind();
				Bindings.glDrawArrays((uint)mode, first, count);
			}
		}
	}
}
