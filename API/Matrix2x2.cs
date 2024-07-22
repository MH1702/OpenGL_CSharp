using System.Globalization;

namespace System.Numerics {
	/// <summary>
	/// A structure encapsulating a 2x2 matrix.
	/// </summary>
	public struct Matrix2x2 : IEquatable<Matrix2x2> {
		#region Public Fields
		/// <summary>
		/// The first element of the first row
		/// </summary>
		public float M11;
		/// <summary>
		/// The second element of the first row
		/// </summary>
		public float M12;
		/// <summary>
		/// The first element of the second row
		/// </summary>
		public float M21;
		/// <summary>
		/// The second element of the second row
		/// </summary>
		public float M22;
		#endregion Public Fields

		private static readonly Matrix2x2 _identity = new Matrix2x2
		(
			1f, 0f,
			0f, 1f
		);

		/// <summary>
		/// Returns the multiplicative identity matrix.
		/// </summary>
		public static Matrix2x2 Identity {
			get { return _identity; }
		}

		/// <summary>
		/// Returns whether the matrix is the identity matrix.
		/// </summary>
		public bool IsIdentity {
			get {
				return M11 == 1f && M22 == 1f && // Check diagonal element first for early out.
									M12 == 0f &&
					   M21 == 0f;
			}
		}

		/// <summary>
		/// Constructs a Matrix2x2 from the given components.
		/// </summary>
		public Matrix2x2(float m11, float m12,
						 float m21, float m22) {
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
		}

		/// <summary>
		/// Calculates the determinant for this matrix.
		/// </summary>
		/// <returns>The determinant.</returns>
		public readonly float GetDeterminant() {
			return (M11 * M22) - (M21 * M12);
		}

		/// <summary>
		/// Attempts to invert the given matrix. If the operation succeeds, the inverted matrix is stored in the result parameter.
		/// </summary>
		/// <param name="matrix">The source matrix.</param>
		/// <param name="result">The output matrix.</param>
		/// <returns>True if the operation succeeded, False otherwise.</returns>
		public static bool Invert(Matrix2x2 matrix, out Matrix2x2 result) {
			float det = (matrix.M11 * matrix.M22) - (matrix.M21 * matrix.M12);

			if (Math.Abs(det) < float.Epsilon) {
				result = new Matrix2x2(float.NaN, float.NaN, float.NaN, float.NaN);
				return false;
			}

			float invDet = 1.0f / det;

			result.M11 = matrix.M22 * invDet;
			result.M12 = -matrix.M12 * invDet;
			result.M21 = -matrix.M21 * invDet;
			result.M22 = matrix.M11 * invDet;

			return true;
		}

		/// <summary>
		/// Linearly interpolates from matrix1 to matrix2, based on the third parameter.
		/// </summary>
		/// <param name="matrix1">The first source matrix.</param>
		/// <param name="matrix2">The second source matrix.</param>
		/// <param name="amount">The relative weighting of matrix2.</param>
		/// <returns>The interpolated matrix.</returns>
		public static Matrix2x2 Lerp(Matrix2x2 matrix1, Matrix2x2 matrix2, float amount) {
			Matrix2x2 result;

			// First row
			result.M11 = matrix1.M11 + (matrix2.M11 - matrix1.M11) * amount;
			result.M12 = matrix1.M12 + (matrix2.M12 - matrix1.M12) * amount;

			// Second row
			result.M21 = matrix1.M21 + (matrix2.M21 - matrix1.M21) * amount;
			result.M22 = matrix1.M22 + (matrix2.M22 - matrix1.M22) * amount;

			return result;
		}

		/// <summary>
		/// Negates the given matrix by multiplying all values by -1.
		/// </summary>
		/// <param name="value">The source matrix.</param>
		/// <returns>The negated matrix.</returns>
		public static Matrix2x2 Negate(Matrix2x2 value) {
			Matrix2x2 result;

			result.M11 = -value.M11;
			result.M12 = -value.M12;
			result.M21 = -value.M21;
			result.M22 = -value.M22;

			return result;
		}

		/// <summary>
		/// Adds each matrix element in value1 with its corresponding element in value2.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The matrix containing the summed values.</returns>
		public static Matrix2x2 Add(Matrix2x2 value1, Matrix2x2 value2) {
			Matrix2x2 result;

			result.M11 = value1.M11 + value2.M11;
			result.M12 = value1.M12 + value2.M12;
			result.M21 = value1.M21 + value2.M21;
			result.M22 = value1.M22 + value2.M22;

			return result;
		}

		/// <summary>
		/// Subtracts each matrix element in value2 from its corresponding element in value1.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The matrix containing the resulting values.</returns>
		public static Matrix2x2 Subtract(Matrix2x2 value1, Matrix2x2 value2) {
			Matrix2x2 result;

			result.M11 = value1.M11 - value2.M11;
			result.M12 = value1.M12 - value2.M12;
			result.M21 = value1.M21 - value2.M21;
			result.M22 = value1.M22 - value2.M22;

			return result;
		}

		/// <summary>
		/// Multiplies two matrices together and returns the resulting matrix.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The product matrix.</returns>
		public static Matrix2x2 Multiply(Matrix2x2 value1, Matrix2x2 value2) {
			Matrix2x2 result;

			// First row
			result.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21;
			result.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22;

			// Second row
			result.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21;
			result.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22;

			return result;
		}

		/// <summary>
		/// Scales all elements in a matrix by the given scalar factor.
		/// </summary>
		/// <param name="value1">The source matrix.</param>
		/// <param name="value2">The scaling value to use.</param>
		/// <returns>The resulting matrix.</returns>
		public static Matrix2x2 Multiply(Matrix2x2 value1, float value2) {
			Matrix2x2 result;

			result.M11 = value1.M11 * value2;
			result.M12 = value1.M12 * value2;
			result.M21 = value1.M21 * value2;
			result.M22 = value1.M22 * value2;

			return result;
		}

		/// <summary>
		/// Negates the given matrix by multiplying all values by -1.
		/// </summary>
		/// <param name="value">The source matrix.</param>
		/// <returns>The negated matrix.</returns>
		public static Matrix2x2 operator -(Matrix2x2 value) {
			Matrix2x2 m;

			m.M11 = -value.M11;
			m.M12 = -value.M12;
			m.M21 = -value.M21;
			m.M22 = -value.M22;

			return m;
		}

		/// <summary>
		/// Adds each matrix element in value1 with its corresponding element in value2.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The matrix containing the summed values.</returns>
		public static Matrix2x2 operator +(Matrix2x2 value1, Matrix2x2 value2) {
			Matrix2x2 m;

			m.M11 = value1.M11 + value2.M11;
			m.M12 = value1.M12 + value2.M12;
			m.M21 = value1.M21 + value2.M21;
			m.M22 = value1.M22 + value2.M22;

			return m;
		}

		/// <summary>
		/// Subtracts each matrix element in value2 from its corresponding element in value1.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The matrix containing the resulting values.</returns>
		public static Matrix2x2 operator -(Matrix2x2 value1, Matrix2x2 value2) {
			Matrix2x2 m;

			m.M11 = value1.M11 - value2.M11;
			m.M12 = value1.M12 - value2.M12;
			m.M21 = value1.M21 - value2.M21;
			m.M22 = value1.M22 - value2.M22;

			return m;
		}

		/// <summary>
		/// Multiplies two matrices together and returns the resulting matrix.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>The product matrix.</returns>
		public static Matrix2x2 operator *(Matrix2x2 value1, Matrix2x2 value2) {
			Matrix2x2 m;

			// First row
			m.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21;
			m.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22;

			// Second row
			m.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21;
			m.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22;

			return m;
		}

		/// <summary>
		/// Scales all elements in a matrix by the given scalar factor.
		/// </summary>
		/// <param name="value1">The source matrix.</param>
		/// <param name="value2">The scaling value to use.</param>
		/// <returns>The resulting matrix.</returns>
		public static Matrix2x2 operator *(Matrix2x2 value1, float value2) {
			Matrix2x2 m;

			m.M11 = value1.M11 * value2;
			m.M12 = value1.M12 * value2;
			m.M21 = value1.M21 * value2;
			m.M22 = value1.M22 * value2;

			return m;
		}

		/// <summary>
		/// Returns a boolean indicating whether the given matrices are equal.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>True if the matrices are equal; False otherwise.</returns>
		public static bool operator ==(Matrix2x2 value1, Matrix2x2 value2) {
			return (value1.M11 == value2.M11 && value1.M22 == value2.M22 && // Check diagonal element first for early out.
												value1.M12 == value2.M12 &&
					value1.M21 == value2.M21);
		}

		/// <summary>
		/// Returns a boolean indicating whether the given matrices are not equal.
		/// </summary>
		/// <param name="value1">The first source matrix.</param>
		/// <param name="value2">The second source matrix.</param>
		/// <returns>True if the matrices are not equal; False if they are equal.</returns>
		public static bool operator !=(Matrix2x2 value1, Matrix2x2 value2) {
			return (value1.M11 != value2.M11 || value1.M12 != value2.M12 ||
					value1.M21 != value2.M21 || value1.M22 != value2.M22);
		}

		/// <summary>
		/// Returns a boolean indicating whether the matrix is equal to the other given matrix.
		/// </summary>
		/// <param name="other">The other matrix to test equality against.</param>
		/// <returns>True if this matrix is equal to other; False otherwise.</returns>
		public bool Equals(Matrix2x2 other) {
			return (M11 == other.M11 && M22 == other.M22 && // Check diagonal element first for early out.
										M12 == other.M12 &&
					M21 == other.M21);
		}

		/// <summary>
		/// Returns a boolean indicating whether the given Object is equal to this matrix instance.
		/// </summary>
		/// <param name="obj">The Object to compare against.</param>
		/// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
		public override bool Equals(object? obj) {
			return obj is Matrix2x2 other && Equals(other);
		}

		/// <summary>
		/// Returns a String representing this matrix instance.
		/// </summary>
		/// <returns>The string representation.</returns>
		public override string ToString() {
			CultureInfo ci = CultureInfo.CurrentCulture;
			return String.Format(ci, "{{ {{M11:{0} M12:{1}}} {{M21:{2} M22:{3}}} }}",
								 M11.ToString(ci), M12.ToString(ci),
								 M21.ToString(ci), M22.ToString(ci));
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>The hash code.</returns>
		public override int GetHashCode() {
			return M11.GetHashCode() + M12.GetHashCode() +
				   M21.GetHashCode() + M22.GetHashCode();
		}
	}
}