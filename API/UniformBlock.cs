using System.Runtime.InteropServices;
namespace OpenGL_CS {
    public static partial class API {
		public class UniformBlock {
			private static uint NEXT_LOCATION = 0;

			public readonly uint Location;

			public UniformBlock(string label, Buffer.View view) {
				Location = NEXT_LOCATION;
				View = view;

				NEXT_LOCATION++;
			}

			private readonly Buffer.View View;

			public void UploadData<T>(T data) where T : struct {
				var size = Marshal.SizeOf<T>();
				var span = new byte[size];
				MemoryMarshal.Write(span, in data);

				// TODO: Always Dynamic Storage?
				View.Buffer.Store(span, Enums.Buffer_Data_Store_Flags.Dynamic_Storage);

				Bindings.glBindBufferRange((uint)Enums.BufferBindingPoints.Uniform_Buffer, Location, View.Buffer.Name, (nint)View.Offset, size);
			}
		}
	}
}
