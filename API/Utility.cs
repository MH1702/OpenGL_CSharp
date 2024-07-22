using OpenGL_CS.Enums;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL_CS {
	public static class Utility {
		internal static T[] Marshal_From_Unmanaged_Array<T>(nint src_ptr, int length) where T : struct {
			unsafe {
				var dest_array = new T[length];
				var size = Marshal.SizeOf<T>();
				var dest_ptr = (void*)Marshal.UnsafeAddrOfPinnedArrayElement(dest_array, 0);
				Buffer.MemoryCopy((void*)src_ptr, dest_ptr, length * size, length * size);

				return dest_array;
			}
		}

		internal static nint Marshal_To_Unmanaged_Array<T>(T[] source_array) where T : struct {
			unsafe {
				var size = Marshal.SizeOf<T>();
				var dest_ptr = (void*)Marshal.AllocHGlobal(source_array.Length * size);
				var src_ptr = (void*)Marshal.UnsafeAddrOfPinnedArrayElement(source_array, 0);
				Buffer.MemoryCopy(src_ptr, dest_ptr, source_array.Length * size, source_array.Length * size);

				return (nint)dest_ptr;
			}
		}

		internal static nint Marshal_String_To_Unmanaged_UTF8(string str) {
			int byte_count = Encoding.UTF8.GetByteCount(str);
			byte[] buffer = new byte[byte_count + 1];
			Encoding.UTF8.GetBytes(str, 0, str.Length, buffer, 0);

			nint ptr = Marshal.AllocHGlobal(buffer.Length);

			Marshal.Copy(buffer, 0, ptr, buffer.Length);

			Marshal.FreeHGlobal(ptr);

			return ptr;
		}

		internal static ReadOnlyDictionary<VertexAttributeType, Type> VertexAttributeType_To_CS = new(new Dictionary<VertexAttributeType, Type>() {
			{ VertexAttributeType.Float, typeof(float) },
			{ VertexAttributeType.Half, typeof(Half) },
			{ VertexAttributeType.Double, typeof(double) },
			{ VertexAttributeType.Integer, typeof(int) },
			{ VertexAttributeType.Short, typeof(short) },
			{ VertexAttributeType.Byte, typeof(sbyte) },
			{ VertexAttributeType.Unsigned_Byte, typeof(byte) },
			{ VertexAttributeType.Unsigned_Short, typeof(ushort) },
			{ VertexAttributeType.Unsigned_Integer, typeof(uint) },
		});

		internal static ReadOnlyDictionary<Type, VertexAttributeType> VertexAttributeType_From_CS = new(new Dictionary<Type, VertexAttributeType>() {
			{ typeof(float), VertexAttributeType.Float },
			{ typeof(Half), VertexAttributeType.Half },
			{ typeof(double), VertexAttributeType.Double },
			{ typeof(int), VertexAttributeType.Integer },
			{ typeof(short), VertexAttributeType.Short },
			{ typeof(sbyte), VertexAttributeType.Byte },
			{ typeof(byte), VertexAttributeType.Unsigned_Byte },
			{ typeof(ushort), VertexAttributeType.Unsigned_Short },
			{ typeof(uint), VertexAttributeType.Unsigned_Integer },
		});

		/// <summary>
		/// See <see href="https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#meshes-overview"/>
		/// </summary>
		public static class AttributeSemantics {
			public const string POSITION = "POSITION";
			public const string NORMAL = "NORMAL";
			public const string TANGENT = "TANGENT";
			public static string TEXCOORD_(int i) => $"TEXCOORD_{i}";
			public static string COLOR_(int i) => $"COLOR_{i}";
			public static string JOINTS_(int i) => $"JOINTS_{i}";
			public static string WEIGHTS_(int i) => $"WEIGHTS_{i}";
		}

		private static readonly ReadOnlyDictionary<TypeAndComponentType, TypeData> TypeDataLookup = new(new Dictionary<TypeAndComponentType, TypeData>() {
			{new() { Type = "SCALAR", ComponentType = VertexAttributeType.Byte }, new TypeData() { CsType = typeof(sbyte), number_of_components = 1, ComponentType = VertexAttributeType.Byte, ComponentByteSize = 1, byte_size = 1, Type = "SCALAR" }},
			{new() { Type = "SCALAR", ComponentType = VertexAttributeType.Unsigned_Byte }, new TypeData() { CsType = typeof(byte), number_of_components = 1, ComponentType = VertexAttributeType.Unsigned_Byte, ComponentByteSize = 1, byte_size = 1, Type = "SCALAR" }},
			{new() { Type = "SCALAR", ComponentType = VertexAttributeType.Short }, new TypeData() { CsType = typeof(short), number_of_components = 1, ComponentType = VertexAttributeType.Short, ComponentByteSize = 2, byte_size = 2, Type = "SCALAR" }},
			{new() { Type = "SCALAR", ComponentType = VertexAttributeType.Unsigned_Short }, new TypeData() { CsType = typeof(ushort), number_of_components = 1, ComponentType = VertexAttributeType.Unsigned_Short, ComponentByteSize = 2, byte_size = 2, Type = "SCALAR" }},
			{new() { Type = "SCALAR", ComponentType = VertexAttributeType.Unsigned_Integer }, new TypeData() { CsType = typeof(uint), number_of_components = 1, ComponentType = VertexAttributeType.Unsigned_Integer, ComponentByteSize = 4, byte_size = 4, Type = "SCALAR" }},
			{new() { Type = "SCALAR", ComponentType = VertexAttributeType.Float }, new TypeData() { CsType = typeof(float), number_of_components = 1, ComponentType = VertexAttributeType.Float, ComponentByteSize = 4, byte_size = 4, Type = "SCALAR" }},

			//{new() { Type = "VEC2", ComponentType = VertexAttributeType.Byte }, new TypeData() { csType = typeof(Vector2D<sbyte>), numComponents = 2, componentType = VertexAttributeType.Byte, componentSize = 1, size = 2, type = "VEC2" }},
			//{new() { Type = "VEC2", ComponentType = VertexAttributeType.UnsignedByte }, new TypeData() { csType = typeof(Vector2D<byte>), numComponents = 2, componentType = VertexAttributeType.UnsignedByte, componentSize = 1, size = 2, type = "VEC2" }},
			//{new() { Type = "VEC2", ComponentType = VertexAttributeType.Short }, new TypeData() { csType = typeof(Vector2D<short>), numComponents = 2, componentType = VertexAttributeType.Short, componentSize = 2, size = 4, type = "VEC2" }},
			//{new() { Type = "VEC2", ComponentType = VertexAttributeType.UnsignedShort }, new TypeData() { csType = typeof(Vector2D<ushort>), numComponents = 2, componentType = VertexAttributeType.UnsignedShort, componentSize = 2, size = 4, type = "VEC2" }},
			//{new() { Type = "VEC2", ComponentType = VertexAttributeType.UnsignedInt }, new TypeData() { csType = typeof(Vector2D<uint>), numComponents = 2, componentType = VertexAttributeType.UnsignedInt, componentSize = 4, size = 8, type = "VEC2" }},
			{new() { Type = "VEC2", ComponentType = VertexAttributeType.Float }, new TypeData() { CsType = typeof(Vector2), number_of_components = 2, ComponentType = VertexAttributeType.Float, ComponentByteSize = 4, byte_size = 8, Type = "VEC2" }},

			//{new() { Type = "VEC3", ComponentType = VertexAttributeType.Byte }, new TypeData() { csType = typeof(Vector3D<sbyte>), numComponents = 3, componentType = VertexAttributeType.Byte, componentSize = 1, size = 3, type = "VEC3" }},
			//{new() { Type = "VEC3", ComponentType = VertexAttributeType.UnsignedByte }, new TypeData() { csType = typeof(Vector3D<byte>), numComponents = 3, componentType = VertexAttributeType.UnsignedByte, componentSize = 1, size = 3, type = "VEC3" }},
			//{new() { Type = "VEC3", ComponentType = VertexAttributeType.Short }, new TypeData() { csType = typeof(Vector3D<short>), numComponents = 3, componentType = VertexAttributeType.Short, componentSize = 2, size = 6, type = "VEC3" }},
			//{new() { Type = "VEC3", ComponentType = VertexAttributeType.UnsignedShort }, new TypeData() { csType = typeof(Vector3D<ushort>), numComponents = 3, componentType = VertexAttributeType.UnsignedShort, componentSize = 2, size = 6, type = "VEC3" }},
			//{new() { Type = "VEC3", ComponentType = VertexAttributeType.UnsignedInt }, new TypeData() { csType = typeof(Vector3D<uint>), numComponents = 3, componentType = VertexAttributeType.Float, componentSize = 4, size = 12, type = "VEC3" }},
			{new() { Type = "VEC3", ComponentType = VertexAttributeType.Float }, new TypeData() { CsType = typeof(Vector3), number_of_components = 3, ComponentType = VertexAttributeType.Float, ComponentByteSize = 4, byte_size = 12, Type = "VEC3" }},

			//{new() { Type = "VEC4", ComponentType = VertexAttributeType.Byte }, new TypeData() { csType = typeof(Vector4D<sbyte>), numComponents = 4, componentType = VertexAttributeType.Byte, componentSize = 1, size = 4, type = "VEC4" }},
			//{new() { Type = "VEC4", ComponentType = VertexAttributeType.UnsignedByte }, new TypeData() { csType = typeof(Vector4D<byte>), numComponents = 4, componentType = VertexAttributeType.UnsignedByte, componentSize = 1, size = 4, type = "VEC4" }},
			//{new() { Type = "VEC4", ComponentType = VertexAttributeType.Short }, new TypeData() { csType = typeof(Vector4D<short>), numComponents = 4, componentType = VertexAttributeType.Short, componentSize = 2, size = 8, type = "VEC4" }},
			{new() { Type = "VEC4", ComponentType = VertexAttributeType.Unsigned_Short }, new TypeData() { CsType = typeof(Vector4), number_of_components = 4, ComponentType = VertexAttributeType.Unsigned_Short, ComponentByteSize = 4, byte_size = 16, Type = "VEC4" }},
			//{new() { Type = "VEC4", ComponentType = VertexAttributeType.UnsignedInt }, new TypeData() { csType = typeof(Vector4D<uint>), numComponents = 4, componentType = VertexAttributeType.UnsignedInt, componentSize = 4, size = 16, type = "VEC4" }},
			{new() { Type = "VEC4", ComponentType = VertexAttributeType.Float }, new TypeData() { CsType = typeof(Vector4), number_of_components = 4, ComponentType = VertexAttributeType.Float, ComponentByteSize = 4, byte_size = 16, Type = "VEC4" }},

				//{new() { Type = "MAT2", ComponentType = VertexAttributeType.Byte }, new TypeData() { csType = typeof(Matrix2X2<sbyte>), numComponents = 4, componentType = VertexAttributeType.Byte, componentSize = 1, size = 4, type = "MAT2" }},
				//{new() { Type = "MAT2", ComponentType = VertexAttributeType.UnsignedByte }, new TypeData() { csType = typeof(Matrix2X2<byte>), numComponents = 4, componentType = VertexAttributeType.UnsignedByte, componentSize = 1, size = 4, type = "MAT2" }},
				//{new() { Type = "MAT2", ComponentType = VertexAttributeType.Short }, new TypeData() { csType = typeof(Matrix2X2<short>), numComponents = 4, componentType = VertexAttributeType.Short, componentSize = 2, size = 8, type = "MAT2" }},
				//{new() { Type = "MAT2", ComponentType = VertexAttributeType.UnsignedShort }, new TypeData() { csType = typeof(Matrix2X2<ushort>), numComponents = 4, componentType = VertexAttributeType.UnsignedShort, componentSize = 2, size = 8, type = "MAT2" }},
				//{new() { Type = "MAT2", ComponentType = VertexAttributeType.UnsignedInt }, new TypeData() { csType = typeof(Matrix2X2<uint>), numComponents = 4, componentType = VertexAttributeType.UnsignedInt, componentSize = 4, size = 16, type = "MAT2" }},
			{new() { Type = "MAT2", ComponentType = VertexAttributeType.Float }, new TypeData() { CsType = typeof(Matrix2x2), number_of_components = 4, ComponentType = VertexAttributeType.Float, ComponentByteSize = 4, byte_size = 16, Type = "MAT2" }},

				//{new() { Type = "MAT3", ComponentType = VertexAttributeType.Byte }, new TypeData() { csType = typeof(Matrix3X3<sbyte>), numComponents = 9, componentType = VertexAttributeType.Byte, componentSize = 1, size = 9, type = "MAT3" }},
				//{new() { Type = "MAT3", ComponentType = VertexAttributeType.UnsignedByte }, new TypeData() { csType = typeof(Matrix3X3<byte>), numComponents = 9, componentType = VertexAttributeType.UnsignedByte, componentSize = 1, size = 9, type = "MAT3" }},
				//{new() { Type = "MAT3", ComponentType = VertexAttributeType.Short }, new TypeData() { csType = typeof(Matrix3X3<short>), numComponents = 9, componentType = VertexAttributeType.Short, componentSize = 2, size = 18, type = "MAT3" }},
				//{new() { Type = "MAT3", ComponentType = VertexAttributeType.UnsignedShort }, new TypeData() { csType = typeof(Matrix3X3<ushort>), numComponents = 9, componentType = VertexAttributeType.UnsignedShort, componentSize = 2, size = 18, type = "MAT3" }},
				//{new() { Type = "MAT3", ComponentType = VertexAttributeType.UnsignedInt }, new TypeData() { csType = typeof(Matrix3X3<uint>), numComponents = 9, componentType = VertexAttributeType.UnsignedInt, componentSize = 4, size = 36, type = "MAT3" }},
			{new() { Type = "MAT3", ComponentType = VertexAttributeType.Float }, new TypeData() { CsType = typeof(Matrix3x3), number_of_components = 9, ComponentType = VertexAttributeType.Float, ComponentByteSize = 4, byte_size = 36, Type = "MAT3" }},

				//{new() { Type = "MAT4", ComponentType = VertexAttributeType.Byte }, new TypeData() { csType = typeof(Matrix4X4<sbyte>), numComponents = 16, componentType = VertexAttributeType.Byte, componentSize = 1, size = 16, type = "MAT4" }},
				//{new() { Type = "MAT4", ComponentType = VertexAttributeType.UnsignedByte }, new TypeData() { csType = typeof(Matrix4X4<byte>), numComponents = 16, componentType = VertexAttributeType.UnsignedByte, componentSize = 1, size = 16, type = "MAT4" }},
				//{new() { Type = "MAT4", ComponentType = VertexAttributeType.Short }, new TypeData() { csType = typeof(Matrix4X4<short>), numComponents = 16, componentType = VertexAttributeType.Short, componentSize = 2, size = 32, type = "MAT4" }},
				//{new() { Type = "MAT4", ComponentType = VertexAttributeType.UnsignedShort }, new TypeData() { csType = typeof(Matrix4X4<ushort>), numComponents = 16, componentType = VertexAttributeType.UnsignedShort, componentSize = 2, size = 32, type = "MAT4" }},
				//{new() { Type = "MAT4", ComponentType = VertexAttributeType.UnsignedInt }, new TypeData() { csType = typeof(Matrix4X4<uint>), numComponents = 16, componentType = VertexAttributeType.UnsignedInt, componentSize = 4, size = 64, type = "MAT4" }},
			{new() { Type = "MAT4", ComponentType = VertexAttributeType.Float }, new TypeData() { CsType = typeof(Matrix4x4), number_of_components = 16, ComponentType = VertexAttributeType.Float, ComponentByteSize = 4, byte_size = 64, Type = "MAT4" }},
		});

		public readonly struct TypeAndComponentType : IEquatable<TypeAndComponentType> {
			public required string Type { get; init; }
			public required VertexAttributeType ComponentType { get; init; }

			public override bool Equals(object? obj) => obj is TypeAndComponentType type && Equals(type);
			public bool Equals(TypeAndComponentType other) => Type == other.Type && ComponentType == other.ComponentType;
			public override int GetHashCode() => HashCode.Combine(Type, ComponentType);

			public static bool operator ==(TypeAndComponentType left, TypeAndComponentType right) => left.Equals(right);
			public static bool operator !=(TypeAndComponentType left, TypeAndComponentType right) => !(left == right);

			public TypeData GetTypeData() => TypeDataLookup[this];
		}

		public class TypeData {
			public required Type CsType { get; init; }
			/// <summary>
			/// Number of components (VEC3 = 3, MAT4X4 = 16, etc.)
			/// </summary>
			public required int number_of_components { get; init; }
			public required VertexAttributeType ComponentType { get; init; }
			/// <summary>
			/// Type (SCALAR, VEC2, VEC3, VEC4, MAT2X2, MAT3X3, MAT4X4)
			/// </summary>
			public required string Type { get; init; }
			/// <summary>
			/// Size of a single component determined by componentType
			/// </summary>
			public required int ComponentByteSize { get; init; }
			/// <summary>
			/// Size of the whole attribute = ComponentByteSize * ComponentCount
			/// </summary>
			public required int byte_size { get; init; }
		}
	}
}