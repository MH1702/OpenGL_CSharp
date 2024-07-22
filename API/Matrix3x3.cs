// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;

namespace System.Numerics {
	/// <summary>
	/// A structure encapsulating a 4x4 matrix.
	/// </summary>
	public struct Matrix3x3 : IEquatable<Matrix3x3> {
		#region Public Fields
		/// <summary>
		/// Value at row 1, column 1 of the matrix.
		/// </summary>
		public float M11;
		/// <summary>
		/// Value at row 1, column 2 of the matrix.
		/// </summary>
		public float M12;
		/// <summary>
		/// Value at row 1, column 3 of the matrix.
		/// </summary>
		public float M13;

		/// <summary>
		/// Value at row 2, column 1 of the matrix.
		/// </summary>
		public float M21;
		/// <summary>
		/// Value at row 2, column 2 of the matrix.
		/// </summary>
		public float M22;
		/// <summary>
		/// Value at row 2, column 3 of the matrix.
		/// </summary>
		public float M23;

		/// <summary>
		/// Value at row 3, column 1 of the matrix.
		/// </summary>
		public float M31;
		/// <summary>
		/// Value at row 3, column 2 of the matrix.
		/// </summary>
		public float M32;
		/// <summary>
		/// Value at row 3, column 3 of the matrix.
		/// </summary>
		public float M33;
		#endregion Public Fields

		private static readonly Matrix3x3 _identity = new Matrix3x3
		(
			1f, 0f, 0f,
			0f, 1f, 0f,
			0f, 0f, 1f
		);

		/// <summary>
		/// Returns the multiplicative identity matrix.
		/// </summary>
		public static Matrix3x3 Identity {
			get { return _identity; }
		}

		/// <summary>
		/// Returns whether the matrix is the identity matrix.
		/// </summary>
		public bool IsIdentity {
			get {
				return M11 == 1f && M22 == 1f && M33 == 1f && // Check diagonal element first for early out.
									M12 == 0f && M13 == 0f && 
					   M21 == 0f && M23 == 0f &&
					   M31 == 0f && M32 == 0f;
			}
		}

		/// <summary>
		/// Constructs a Matrix3x3 from the given components.
		/// </summary>
		public Matrix3x3(float m11, float m12, float m13,
						 float m21, float m22, float m23,
						 float m31, float m32, float m33) {
			M11 = m11;
			M12 = m12;
			M13 = m13;

			M21 = m21;
			M22 = m22;
			M23 = m23;

			M31 = m31;
			M32 = m32;
			M33 = m33;
		}

		struct CanonicalBasis {
			public Vector3 Row0;
			public Vector3 Row1;
			public Vector3 Row2;
		};

		[System.Security.SecuritySafeCritical]
		struct VectorBasis {
			public unsafe Vector3* Element0;
			public unsafe Vector3* Element1;
			public unsafe Vector3* Element2;
		}

		/// <summary>
		/// Transposes the rows and columns of a matrix.
		/// </summary>
		/// <param name="matrix">The source matrix.</param>
		/// <returns>The transposed matrix.</returns>
		public static Matrix3x3 Transpose(Matrix3x3 matrix) {
			Matrix3x3 result;

			result.M11 = matrix.M11;
			result.M12 = matrix.M21;
			result.M13 = matrix.M31;
			result.M21 = matrix.M12;
			result.M22 = matrix.M22;
			result.M23 = matrix.M32;
			result.M31 = matrix.M13;
			result.M32 = matrix.M23;
			result.M33 = matrix.M33;

			return result;
		}

		/// <summary>
		/// Linearly interpolates between the corresponding values of two matrices.
		/// </summary>
		/// <param name="matrix1">The first source matrix.</param>
		/// <param name="matrix2">The second source matrix.</param>
		/// <param name="amount">The relative weight of the second source matrix.</param>
		/// <returns>The interpolated matrix.</returns>
		public static Matrix3x3 Lerp(Matrix3x3 matrix1, Matrix3x3 matrix2, float amount) {
			Matrix3x3 result;

			// First row
			result.M11 = matrix1.M11 + (matrix2.M11 - matrix1.M11) * amount;
			result.M12 = matrix1.M12 + (matrix2.M12 - matrix1.M12) * amount;
			result.M13 = matrix1.M13 + (matrix2.M13 - matrix1.M13) * amount;

			// Second row
			result.M21 = matrix1.M21 + (matrix2.M21 - matrix1.M21) * amount;
			result.M22 = matrix1.M22 + (matrix2.M22 - matrix1.M22) * amount;
			result.M23 = matrix1.M23 + (matrix2.M23 - matrix1.M23) * amount;

			// Third row
			result.M31 = matrix1.M31 + (matrix2.M31 - matrix1.M31) * amount;
			result.M32 = matrix1.M32 + (matrix2.M32 - matrix1.M32) * amount;
			result.M33 = matrix1.M33 + (matrix2.M33 - matrix1.M33) * amount;

			return result;
		}

		/// <summary>
		/// Returns a new matrix with the negated elements of the given matrix.
		/// </summary>
		/// <param name="value">The source matrix.</param>
		/// <returns>The negated matrix.</returns>
		public static Matrix3x3 Negate(Matrix3x3 value) {
			Matrix3x3 result;

			result.M11 = -value.M11;
			result.M12 = -value.M12;
			result.M13 = -value.M13;
			result.M21 = -value.M21;
			result.M22 = -value.M22;
			result.M23 = -value.M23;
			result.M31 = -value.M31;
			result.M32 = -value.M32;
			result.M33 = -value.M33;

			return result;
		}

		/// <summary>
		/// Adds two matrices together.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The resulting matrix.</returns>
		public static Matrix3x3 Add(Matrix3x3 value1, Matrix3x3 value2) {
			Matrix3x3 result;

			result.M11 = value1.M11 + value2.M11;
			result.M12 = value1.M12 + value2.M12;
			result.M13 = value1.M13 + value2.M13;
			result.M21 = value1.M21 + value2.M21;
			result.M22 = value1.M22 + value2.M22;
			result.M23 = value1.M23 + value2.M23;
			result.M31 = value1.M31 + value2.M31;
			result.M32 = value1.M32 + value2.M32;
			result.M33 = value1.M33 + value2.M33;

			return result;
		}

		/// <summary>
		/// Subtracts the second matrix from the first.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The result of the subtraction.</returns>
		public static Matrix3x3 Subtract(Matrix3x3 value1, Matrix3x3 value2) {
			Matrix3x3 result;

			result.M11 = value1.M11 - value2.M11;
			result.M12 = value1.M12 - value2.M12;
			result.M13 = value1.M13 - value2.M13;
			result.M21 = value1.M21 - value2.M21;
			result.M22 = value1.M22 - value2.M22;
			result.M23 = value1.M23 - value2.M23;
			result.M31 = value1.M31 - value2.M31;
			result.M32 = value1.M32 - value2.M32;
			result.M33 = value1.M33 - value2.M33;

			return result;
		}

		/// <summary>
		/// Multiplies a matrix by another matrix.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The result of the multiplication.</returns>
		public static Matrix3x3 Multiply(Matrix3x3 value1, Matrix3x3 value2) {
			Matrix3x3 result;

			// First row
			result.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31;
			result.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32;
			result.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33;

			// Second row
			result.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31;
			result.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32;
			result.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33;

			// Third row
			result.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31;
			result.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32;
			result.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33;

			return result;
		}

		/// <summary>
		/// Multiplies a matrix by a scalar value.
		/// </summary>
		/// <param name="value1">The source matrix.</param>
		/// <param name="value2">The scaling factor.</param>
		/// <returns>The scaled matrix.</returns>
		public static Matrix3x3 Multiply(Matrix3x3 value1, float value2) {
			Matrix3x3 result;

			result.M11 = value1.M11 * value2;
			result.M12 = value1.M12 * value2;
			result.M13 = value1.M13 * value2;
			result.M21 = value1.M21 * value2;
			result.M22 = value1.M22 * value2;
			result.M23 = value1.M23 * value2;
			result.M31 = value1.M31 * value2;
			result.M32 = value1.M32 * value2;
			result.M33 = value1.M33 * value2;

			return result;
		}

		/// <summary>
		/// Returns a new matrix with the negated elements of the given matrix.
		/// </summary>
		/// <param name="value">The source matrix.</param>
		/// <returns>The negated matrix.</returns>
		public static Matrix3x3 operator -(Matrix3x3 value) {
			Matrix3x3 m;

			m.M11 = -value.M11;
			m.M12 = -value.M12;
			m.M13 = -value.M13;
			m.M21 = -value.M21;
			m.M22 = -value.M22;
			m.M23 = -value.M23;
			m.M31 = -value.M31;
			m.M32 = -value.M32;
			m.M33 = -value.M33;

			return m;
		}

		/// <summary>
		/// Adds two matrices together.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The resulting matrix.</returns>
		public static Matrix3x3 operator +(Matrix3x3 value1, Matrix3x3 value2) {
			Matrix3x3 m;

			m.M11 = value1.M11 + value2.M11;
			m.M12 = value1.M12 + value2.M12;
			m.M13 = value1.M13 + value2.M13;
			m.M21 = value1.M21 + value2.M21;
			m.M22 = value1.M22 + value2.M22;
			m.M23 = value1.M23 + value2.M23;
			m.M31 = value1.M31 + value2.M31;
			m.M32 = value1.M32 + value2.M32;
			m.M33 = value1.M33 + value2.M33;

			return m;
		}

		/// <summary>
		/// Subtracts the second matrix from the first.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The result of the subtraction.</returns>
		public static Matrix3x3 operator -(Matrix3x3 value1, Matrix3x3 value2) {
			Matrix3x3 m;

			m.M11 = value1.M11 - value2.M11;
			m.M12 = value1.M12 - value2.M12;
			m.M13 = value1.M13 - value2.M13;
			m.M21 = value1.M21 - value2.M21;
			m.M22 = value1.M22 - value2.M22;
			m.M23 = value1.M23 - value2.M23;
			m.M31 = value1.M31 - value2.M31;
			m.M32 = value1.M32 - value2.M32;
			m.M33 = value1.M33 - value2.M33;

			return m;
		}

		/// <summary>
		/// Multiplies a matrix by another matrix.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The result of the multiplication.</returns>
		public static Matrix3x3 operator *(Matrix3x3 value1, Matrix3x3 value2) {
			Matrix3x3 m;

			// First row
			m.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31;
			m.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32;
			m.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33;

			// Second row
			m.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31;
			m.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32;
			m.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33;

			// Third row
			m.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31;
			m.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32;
			m.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33;

			return m;
		}

		/// <summary>
		/// Multiplies a matrix by a scalar value.
		/// </summary>
		/// <param name="value1">The source matrix.</param>
		/// <param name="value2">The scaling factor.</param>
		/// <returns>The scaled matrix.</returns>
		public static Matrix3x3 operator *(Matrix3x3 value1, float value2) {
			Matrix3x3 m;

			m.M11 = value1.M11 * value2;
			m.M12 = value1.M12 * value2;
			m.M13 = value1.M13 * value2;
			m.M21 = value1.M21 * value2;
			m.M22 = value1.M22 * value2;
			m.M23 = value1.M23 * value2;
			m.M31 = value1.M31 * value2;
			m.M32 = value1.M32 * value2;
			m.M33 = value1.M33 * value2;
			return m;
		}

		/// <summary>
		/// Returns a boolean indicating whether the given two matrices are equal.
		/// </summary>
		/// <param name="value1">The first matrix to compare.</param>
		/// <param name="value2">The second matrix to compare.</param>
		/// <returns>True if the given matrices are equal; False otherwise.</returns>
		public static bool operator ==(Matrix3x3 value1, Matrix3x3 value2) {
			return (value1.M11 == value2.M11 && value1.M22 == value2.M22 && value1.M33 == value2.M33 && // Check diagonal element first for early out.
												value1.M12 == value2.M12 && value1.M13 == value2.M13 &&
					value1.M21 == value2.M21 && value1.M23 == value2.M23 &&
					value1.M31 == value2.M31 && value1.M32 == value2.M32);
		}

		/// <summary>
		/// Returns a boolean indicating whether the given two matrices are not equal.
		/// </summary>
		/// <param name="value1">The first matrix to compare.</param>
		/// <param name="value2">The second matrix to compare.</param>
		/// <returns>True if the given matrices are not equal; False if they are equal.</returns>
		public static bool operator !=(Matrix3x3 value1, Matrix3x3 value2) {
			return (value1.M11 != value2.M11 || value1.M12 != value2.M12 || value1.M13 != value2.M13 ||
					value1.M21 != value2.M21 || value1.M22 != value2.M22 || value1.M23 != value2.M23 ||
					value1.M31 != value2.M31 || value1.M32 != value2.M32 || value1.M33 != value2.M33);
		}

		/// <summary>
		/// Returns a boolean indicating whether this matrix instance is equal to the other given matrix.
		/// </summary>
		/// <param name="other">The matrix to compare this instance to.</param>
		/// <returns>True if the matrices are equal; False otherwise.</returns>
		public bool Equals(Matrix3x3 other) {
			return (M11 == other.M11 && M22 == other.M22 && M33 == other.M33 && // Check diagonal element first for early out.
										M12 == other.M12 && M13 == other.M13 &&
										M21 == other.M21 && M23 == other.M23 &&
					M31 == other.M31 && M32 == other.M32);
		}

		/// <summary>
		/// Returns a boolean indicating whether the given Object is equal to this matrix instance.
		/// </summary>
		/// <param name="obj">The Object to compare against.</param>
		/// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
		public override bool Equals(object? obj) {
			return obj is Matrix3x3 other && Equals(other);
		}

		/// <summary>
		/// Returns a String representing this matrix instance.
		/// </summary>
		/// <returns>The string representation.</returns>
		public override string ToString() {
			CultureInfo ci = CultureInfo.CurrentCulture;

			return String.Format(ci, "{{ {{M11:{0} M12:{1} M13:{2} }} {{M21:{4} M22:{5} M23:{6} }} {{M31:{8} M32:{9} M33:{10} }}",
								 M11.ToString(ci), M12.ToString(ci), M13.ToString(ci),
								 M21.ToString(ci), M22.ToString(ci), M23.ToString(ci),
								 M31.ToString(ci), M32.ToString(ci), M33.ToString(ci));
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>The hash code.</returns>
		public override int GetHashCode() {
			return M11.GetHashCode() + M12.GetHashCode() + M13.GetHashCode() +
				   M21.GetHashCode() + M22.GetHashCode() + M23.GetHashCode() +
				   M31.GetHashCode() + M32.GetHashCode() + M33.GetHashCode();
		}
	}
}