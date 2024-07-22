using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL_CS {
	internal partial class BindingsGen {
		static void Main(string[] args) {
			using HttpClient client = new();
			var glcorearb = client.GetAsync("https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/main/api/GL/glcorearb.h").Result.Content.ReadAsStringAsync().Result;

			var versions = Versions().Matches(glcorearb);
			GenerateBindings(versions);
			GenerateEnums(versions);

		}

		private static void GenerateEnums(MatchCollection versions) {
			StringBuilder codeBuilder = new();

			codeBuilder.AppendLine("namespace OpenGL_CS.Enums {");
			codeBuilder.AppendLine("  internal enum ALL {");

			foreach (Match version in versions.Cast<Match>()) {
				var defines = Defines().Matches(version.Value);

				foreach (Match define in defines.Cast<Match>()) {
					codeBuilder.AppendLine($"    {define.Groups["symbol"]} = {define.Groups["value"]},");
				}
			}

			codeBuilder.AppendLine("  }");
			codeBuilder.AppendLine("}");
			string generatedCode = codeBuilder.ToString();

			File.WriteAllText("Enums.cs", generatedCode);
		}

		private static void GenerateBindings(MatchCollection versions) {
			StringBuilder codeBuilder = new();
			codeBuilder.AppendLine("using System.Runtime.InteropServices;");
			codeBuilder.AppendLine();
			codeBuilder.AppendLine("#pragma warning disable CS8618");
			codeBuilder.AppendLine("namespace OpenGL_CS {");
			codeBuilder.AppendLine("  public static unsafe class Bindings");
			codeBuilder.AppendLine("  {");

			codeBuilder.AppendLine("    public delegate void DebugMessageCallback(uint source, uint type, uint id, uint severity, int length, nint message, nint userParam);");
			codeBuilder.AppendLine();

			Dictionary<string, string> typedefs = new() {
				{ "GLsync", "nint" },
				{ "GLDEBUGPROC", "DebugMessageCallback" }
			};

			string ResolveType(string type_unresolved) {
				type_unresolved = type_unresolved.Replace("const", "");

				var underlying_type = type_unresolved;
				var pointers = "";


				if (type_unresolved.EndsWith('*')) {
					var m = PointerType().Match(type_unresolved);

					underlying_type = m.Groups["underlying_type"].Value;
					pointers = m.Groups["pointers"].Value.Replace(" ", "");
				}

				if (underlying_type == "void") {
					return $"void{pointers}";
				}

				if (typedefs.TryGetValue(underlying_type, out string? value)) {
					return $"{value}{pointers}";
				}
				else {
					return $"UNRESOLVED_TYPE_NAME[{type_unresolved} => {underlying_type}]";
				}
			}


			foreach (Match version in versions.Cast<Match>()) {
				var type_typedefs = TypeTypedefs().Matches(version.Value);

				foreach (Match type_typedef in type_typedefs.Cast<Match>()) {
					var unresolved = type_typedef.Groups["unresolved"].Value.Trim();
					var resolved = type_typedef.Groups["resolved"].Value.Trim();

					switch (resolved) {
						case "unsigned int":
						resolved = "uint";
						break;
						case "unsigned char":
						resolved = "byte";
						break;
						case "char":
						resolved = "byte";
						break;
						case "khronos_float_t":
						resolved = "float";
						break;
						case "khronos_ssize_t":
						resolved = "int";
						break;
						case "khronos_intptr_t":
						resolved = "nint";
						break;
						case "khronos_int16_t":
						resolved = "short";
						break;
						case "khronos_uint16_t":
						resolved = "ushort";
						break;
						case "khronos_uint8_t":
						resolved = "byte";
						break;
						case "khronos_uint64_t":
						resolved = "ulong";
						break;
						case "khronos_int8_t":
						resolved = "sbyte";
						break;
						case "khronos_int64_t":
						resolved = "long";
						break;
					}

					typedefs.Add(unresolved, resolved);
				}

				var prototypes = GLEXT_PROTOTYPES().Matches(version.Value);

				var major_version = version.Groups["major_version"].Value;
				var minor_version = version.Groups["minor_version"].Value;

				codeBuilder.AppendLine($"      #region GL_VERSION_{major_version}_{minor_version}");

				foreach (Match prototype in prototypes.Cast<Match>()) {
					var name = prototype.Groups["function_name"].Value;

					var params_unresolved = prototype.Groups["params"].Value.Split(",").ToList();

					List<string> params_resolved = [];

					if (!(params_unresolved.Count == 1 && params_unresolved[0] == "void")) {
						params_resolved = params_unresolved.Select(
							(param) => {

								var param_match = Param().Match(param.Trim());

								var param_name = SanatizeParamName(param_match.Groups["name"].Value);

								string type_unresolved = param_match.Groups["type"].Value.Trim();

								string type_resolved = ResolveType(type_unresolved);

								return $"{type_resolved} {param_name}";
							}
						).ToList();
					}


					var return_type_unresolved = prototype.Groups["return_type"].Value;
					string return_type_resolved;
					if (return_type_unresolved == "void") {
						return_type_resolved = "void";
					}
					else {
						return_type_resolved = ResolveType(return_type_unresolved);
					}


					codeBuilder.AppendLine($"    internal delegate {return_type_resolved} {name}_Delegate({string.Join(", ", params_resolved)});");
					codeBuilder.AppendLine();
				}

				codeBuilder.AppendLine($"    #endregion");
			}

			foreach (Match version in versions.Cast<Match>()) {
				var prototypes = GLEXT_PROTOTYPES().Matches(version.Value);

				var major_version = version.Groups["major_version"].Value;
				var minor_version = version.Groups["minor_version"].Value;

				codeBuilder.AppendLine($"      #region GL_VERSION_{major_version}_{minor_version}");

				foreach (Match prototype in prototypes.Cast<Match>()) {
					codeBuilder.AppendLine($"    internal static {prototype.Groups["function_name"]}_Delegate {prototype.Groups["function_name"]};" +
						$"");
					codeBuilder.AppendLine();
				}

				codeBuilder.AppendLine($"    #endregion");
			}

			codeBuilder.AppendLine("  public static void Init(int major_version, int minor_version) {");
			foreach (Match version in versions.Cast<Match>()) {
				var prototypes = GLEXT_PROTOTYPES().Matches(version.Value);

				var major_version = version.Groups["major_version"].Value;
				var minor_version = version.Groups["minor_version"].Value;

				codeBuilder.AppendLine($"      #region GL_VERSION_{major_version}_{minor_version}");
				codeBuilder.AppendLine($"      if (major_version >= {major_version} && minor_version >= {minor_version}) {{");

				foreach (Match prototype in prototypes.Cast<Match>()) {
					codeBuilder.AppendLine($"      {prototype.Groups["function_name"]} = Marshal.GetDelegateForFunctionPointer<{prototype.Groups["function_name"]}_Delegate>(Loader.GetProcAddress(\"{prototype.Groups["function_name"]}\", {major_version}, {minor_version}));");
					codeBuilder.AppendLine();
				}

				codeBuilder.AppendLine($"      }}");
				codeBuilder.AppendLine($"      #endregion");
			}

			codeBuilder.AppendLine("    }");
			codeBuilder.AppendLine("  }");
			codeBuilder.AppendLine("}");
			string generatedCode = codeBuilder.ToString();

			File.WriteAllText("Bindings.cs", generatedCode);
		}

		private static string SanatizeParamName(string value) {
			return value switch {
				"ref" => "reference",
				"params" => "parameters",
				"string" => "str",
				_ => value,
			};
		}

		[GeneratedRegex(@"^(#ifndef GL_VERSION_(?<major_version>\d+)_(?<minor_version>\d+))$.*?^(#endif /\* GL_VERSION_(\k<major_version>)_(\k<minor_version>) \*/)$", RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.ExplicitCapture)]
		private static partial Regex Versions();

		[GeneratedRegex(@"^typedef\s+(?<resolved>[a-zA-Z_][a-zA-Z0-9_ ]*)\s+(?<unresolved>[a-zA-Z_][a-zA-Z0-9_]*)\s*;$", RegexOptions.Multiline | RegexOptions.ExplicitCapture)]
		private static partial Regex TypeTypedefs();

		[GeneratedRegex(@"^typedef (?<return_type>[a-zA-Z_0-9 *]+?) ?(?<a>\(APIENTRYP (?<s>[a-zA-Z_0-9]+)\)) (?<b>\([a-zA-Z_0-9 ,*]+\)).*", RegexOptions.Multiline | RegexOptions.ExplicitCapture)]
		private static partial Regex FunctionTypedefs();

		[GeneratedRegex(@"^#define (?<symbol>[a-zA-Z_0-9]+)\s+(?<value>[a-zA-Z_0-9]+)$", RegexOptions.Multiline | RegexOptions.ExplicitCapture)]
		private static partial Regex Defines();

		[GeneratedRegex(@"^GLAPI (?<return_type>[a-zA-Z_0-9 *]+?) APIENTRY (?<function_name>[a-zA-Z_0-9 *]+?) \((?<params>[a-zA-Z_0-9 ,*]+)\).*$", RegexOptions.Multiline | RegexOptions.ExplicitCapture)]
		private static partial Regex GLEXT_PROTOTYPES();

		[GeneratedRegex(@"^(?<type>.*[ *])(?<name>.*)$", RegexOptions.Multiline | RegexOptions.ExplicitCapture)]
		private static partial Regex Param();

		[GeneratedRegex(@"^\s*(?<underlying_type>.*)\s+(?<pointers>.*)$", RegexOptions.Multiline | RegexOptions.ExplicitCapture)]
		private static partial Regex PointerType();
	}
}