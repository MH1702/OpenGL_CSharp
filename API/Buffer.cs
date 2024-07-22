using OpenGL_CS.Enums;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL_CS {
	public static partial class API {
		public unsafe class Buffer : Object {
			public Buffer() {
				unsafe {
					uint* name = stackalloc uint[1];

					Bindings.glCreateBuffers(1, name);

					Name = *name;
				}
			}

			public string Label {
				get {
					var label_ptr = stackalloc byte[128];
					var length_ptr = stackalloc int[1];

					Bindings.glGetObjectLabel((uint)ObjectIdentifier.Buffer, Name, 128, length_ptr, label_ptr);

					return Marshal.PtrToStringAnsi((nint)label_ptr, *length_ptr);
				}
				set {
					var label_ascii_bytes = Encoding.ASCII.GetBytes(value);

					fixed (byte* label_ascii_ptr = label_ascii_bytes) {
						Bindings.glObjectLabel((uint)ObjectIdentifier.Buffer, Name, label_ascii_bytes.Length, label_ascii_ptr);
					}
				}
			}

			private bool isInitialized = false;

			public void Store(Span<byte> data, Buffer_Data_Store_Flags flags) {
				fixed (byte* data_ptr = data) {
					if (!isInitialized) {
						Bindings.glNamedBufferStorage(Name, data.Length, data_ptr, (uint)flags);
						isInitialized = true;
						return;
					}

					Bindings.glNamedBufferSubData(Name, 0, data.Length, data_ptr);
				}
			}

			public readonly List<View> Views = [];

			public static void DrawElements(View.Attribute indices, DrawMode mode) {
				Bindings.glDrawElements((uint)mode, (int)indices.Count, (uint)indices.VertexAttribute.TypeData.ComponentType, (void*)(indices.View.Offset + indices.RelativeOffset));
			}

			public void Bind(BufferBindingPoints binding_point) {
				Bindings.glBindBuffer((uint)binding_point, Name);
			}

			public class View(Buffer buffer) {
				public readonly Buffer Buffer = buffer;

				/// <summary>
				/// Offset from the buffers starting address where this view begins
				/// </summary>
				public uint Offset { get; init; } = 0;

				public uint? stride;

				public uint Stride => stride ??= (uint)Attributes.Sum(x => x.VertexAttribute.TypeData.byte_size);

				public readonly List<Attribute> Attributes = [];

				public class Attribute(View view) {
					public readonly View View = view;
					/// <summary>
					/// Offset relative to the views starting address where this attribute begins
					/// </summary>
					public uint RelativeOffset { get; init; } = 0;

					public required uint Count { get; init; }

					public required VertexAttribute VertexAttribute { get; init; }
				}
			}
		}
	}
}
