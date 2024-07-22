using System.Runtime.InteropServices;

#pragma warning disable CS8618
namespace OpenGL_CS {
	public static unsafe class Bindings {
		public delegate void DebugMessageCallback(uint source, uint type, uint id, uint severity, int length, nint message, nint userParam);

		#region GL_VERSION_1_0
		internal delegate void glCullFace_Delegate(uint mode);

		internal delegate void glFrontFace_Delegate(uint mode);

		internal delegate void glHint_Delegate(uint target, uint mode);

		internal delegate void glLineWidth_Delegate(float width);

		internal delegate void glPointSize_Delegate(float size);

		internal delegate void glPolygonMode_Delegate(uint face, uint mode);

		internal delegate void glScissor_Delegate(int x, int y, int width, int height);

		internal delegate void glTexParameterf_Delegate(uint target, uint pname, float param);

		internal delegate void glTexParameterfv_Delegate(uint target, uint pname, float* parameters);

		internal delegate void glTexParameteri_Delegate(uint target, uint pname, int param);

		internal delegate void glTexParameteriv_Delegate(uint target, uint pname, int* parameters);

		internal delegate void glTexImage1D_Delegate(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);

		internal delegate void glTexImage2D_Delegate(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

		internal delegate void glDrawBuffer_Delegate(uint buf);

		internal delegate void glClear_Delegate(uint mask);

		internal delegate void glClearColor_Delegate(float red, float green, float blue, float alpha);

		internal delegate void glClearStencil_Delegate(int s);

		internal delegate void glClearDepth_Delegate(double depth);

		internal delegate void glStencilMask_Delegate(uint mask);

		internal delegate void glColorMask_Delegate(byte red, byte green, byte blue, byte alpha);

		internal delegate void glDepthMask_Delegate(byte flag);

		internal delegate void glDisable_Delegate(uint cap);

		internal delegate void glEnable_Delegate(uint cap);

		internal delegate void glFinish_Delegate();

		internal delegate void glFlush_Delegate();

		internal delegate void glBlendFunc_Delegate(uint sfactor, uint dfactor);

		internal delegate void glLogicOp_Delegate(uint opcode);

		internal delegate void glStencilFunc_Delegate(uint func, int reference, uint mask);

		internal delegate void glStencilOp_Delegate(uint fail, uint zfail, uint zpass);

		internal delegate void glDepthFunc_Delegate(uint func);

		internal delegate void glPixelStoref_Delegate(uint pname, float param);

		internal delegate void glPixelStorei_Delegate(uint pname, int param);

		internal delegate void glReadBuffer_Delegate(uint src);

		internal delegate void glReadPixels_Delegate(int x, int y, int width, int height, uint format, uint type, void* pixels);

		internal delegate void glGetBooleanv_Delegate(uint pname, byte* data);

		internal delegate void glGetDoublev_Delegate(uint pname, double* data);

		internal delegate uint glGetError_Delegate();

		internal delegate void glGetFloatv_Delegate(uint pname, float* data);

		internal delegate void glGetIntegerv_Delegate(uint pname, int* data);

		internal delegate void glGetTexImage_Delegate(uint target, int level, uint format, uint type, void* pixels);

		internal delegate void glGetTexParameterfv_Delegate(uint target, uint pname, float* parameters);

		internal delegate void glGetTexParameteriv_Delegate(uint target, uint pname, int* parameters);

		internal delegate void glGetTexLevelParameterfv_Delegate(uint target, int level, uint pname, float* parameters);

		internal delegate void glGetTexLevelParameteriv_Delegate(uint target, int level, uint pname, int* parameters);

		internal delegate byte glIsEnabled_Delegate(uint cap);

		internal delegate void glDepthRange_Delegate(double n, double f);

		internal delegate void glViewport_Delegate(int x, int y, int width, int height);

		#endregion
		#region GL_VERSION_1_1
		internal delegate void glDrawArrays_Delegate(uint mode, int first, int count);

		internal delegate void glDrawElements_Delegate(uint mode, int count, uint type, void* indices);

		internal delegate void glGetPointerv_Delegate(uint pname, void** parameters);

		internal delegate void glPolygonOffset_Delegate(float factor, float units);

		internal delegate void glCopyTexImage1D_Delegate(uint target, int level, uint internalformat, int x, int y, int width, int border);

		internal delegate void glCopyTexImage2D_Delegate(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

		internal delegate void glCopyTexSubImage1D_Delegate(uint target, int level, int xoffset, int x, int y, int width);

		internal delegate void glCopyTexSubImage2D_Delegate(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		internal delegate void glTexSubImage1D_Delegate(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);

		internal delegate void glTexSubImage2D_Delegate(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

		internal delegate void glBindTexture_Delegate(uint target, uint texture);

		internal delegate void glDeleteTextures_Delegate(int n, uint* textures);

		internal delegate void glGenTextures_Delegate(int n, uint* textures);

		internal delegate byte glIsTexture_Delegate(uint texture);

		#endregion
		#region GL_VERSION_1_2
		internal delegate void glDrawRangeElements_Delegate(uint mode, uint start, uint end, int count, uint type, void* indices);

		internal delegate void glTexImage3D_Delegate(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

		internal delegate void glTexSubImage3D_Delegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

		internal delegate void glCopyTexSubImage3D_Delegate(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		#endregion
		#region GL_VERSION_1_3
		internal delegate void glActiveTexture_Delegate(uint texture);

		internal delegate void glSampleCoverage_Delegate(float value, byte invert);

		internal delegate void glCompressedTexImage3D_Delegate(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);

		internal delegate void glCompressedTexImage2D_Delegate(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

		internal delegate void glCompressedTexImage1D_Delegate(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);

		internal delegate void glCompressedTexSubImage3D_Delegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

		internal delegate void glCompressedTexSubImage2D_Delegate(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

		internal delegate void glCompressedTexSubImage1D_Delegate(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);

		internal delegate void glGetCompressedTexImage_Delegate(uint target, int level, void* img);

		#endregion
		#region GL_VERSION_1_4
		internal delegate void glBlendFuncSeparate_Delegate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

		internal delegate void glMultiDrawArrays_Delegate(uint mode, int* first, int* count, int drawcount);

		internal delegate void glMultiDrawElements_Delegate(uint mode, int* count, uint type, void** indices, int drawcount);

		internal delegate void glPointParameterf_Delegate(uint pname, float param);

		internal delegate void glPointParameterfv_Delegate(uint pname, float* parameters);

		internal delegate void glPointParameteri_Delegate(uint pname, int param);

		internal delegate void glPointParameteriv_Delegate(uint pname, int* parameters);

		internal delegate void glBlendColor_Delegate(float red, float green, float blue, float alpha);

		internal delegate void glBlendEquation_Delegate(uint mode);

		#endregion
		#region GL_VERSION_1_5
		internal delegate void glGenQueries_Delegate(int n, uint* ids);

		internal delegate void glDeleteQueries_Delegate(int n, uint* ids);

		internal delegate byte glIsQuery_Delegate(uint id);

		internal delegate void glBeginQuery_Delegate(uint target, uint id);

		internal delegate void glEndQuery_Delegate(uint target);

		internal delegate void glGetQueryiv_Delegate(uint target, uint pname, int* parameters);

		internal delegate void glGetQueryObjectiv_Delegate(uint id, uint pname, int* parameters);

		internal delegate void glGetQueryObjectuiv_Delegate(uint id, uint pname, uint* parameters);

		internal delegate void glBindBuffer_Delegate(uint target, uint buffer);

		internal delegate void glDeleteBuffers_Delegate(int n, uint* buffers);

		internal delegate void glGenBuffers_Delegate(int n, uint* buffers);

		internal delegate byte glIsBuffer_Delegate(uint buffer);

		internal delegate void glBufferData_Delegate(uint target, int size, void* data, uint usage);

		internal delegate void glBufferSubData_Delegate(uint target, nint offset, int size, void* data);

		internal delegate void glGetBufferSubData_Delegate(uint target, nint offset, int size, void* data);

		internal delegate byte glUnmapBuffer_Delegate(uint target);

		internal delegate void glGetBufferParameteriv_Delegate(uint target, uint pname, int* parameters);

		internal delegate void glGetBufferPointerv_Delegate(uint target, uint pname, void** parameters);

		#endregion
		#region GL_VERSION_2_0
		internal delegate void glBlendEquationSeparate_Delegate(uint modeRGB, uint modeAlpha);

		internal delegate void glDrawBuffers_Delegate(int n, uint* bufs);

		internal delegate void glStencilOpSeparate_Delegate(uint face, uint sfail, uint dpfail, uint dppass);

		internal delegate void glStencilFuncSeparate_Delegate(uint face, uint func, int reference, uint mask);

		internal delegate void glStencilMaskSeparate_Delegate(uint face, uint mask);

		internal delegate void glAttachShader_Delegate(uint program, uint shader);

		internal delegate void glBindAttribLocation_Delegate(uint program, uint index, byte* name);

		internal delegate void glCompileShader_Delegate(uint shader);

		internal delegate uint glCreateProgram_Delegate();

		internal delegate uint glCreateShader_Delegate(uint type);

		internal delegate void glDeleteProgram_Delegate(uint program);

		internal delegate void glDeleteShader_Delegate(uint shader);

		internal delegate void glDetachShader_Delegate(uint program, uint shader);

		internal delegate void glDisableVertexAttribArray_Delegate(uint index);

		internal delegate void glEnableVertexAttribArray_Delegate(uint index);

		internal delegate void glGetActiveAttrib_Delegate(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);

		internal delegate void glGetActiveUniform_Delegate(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);

		internal delegate void glGetAttachedShaders_Delegate(uint program, int maxCount, int* count, uint* shaders);

		internal delegate int glGetAttribLocation_Delegate(uint program, byte* name);

		internal delegate void glGetProgramiv_Delegate(uint program, uint pname, int* parameters);

		internal delegate void glGetProgramInfoLog_Delegate(uint program, int bufSize, int* length, byte* infoLog);

		internal delegate void glGetShaderiv_Delegate(uint shader, uint pname, int* parameters);

		internal delegate void glGetShaderInfoLog_Delegate(uint shader, int bufSize, int* length, byte* infoLog);

		internal delegate void glGetShaderSource_Delegate(uint shader, int bufSize, int* length, byte* source);

		internal delegate int glGetUniformLocation_Delegate(uint program, byte* name);

		internal delegate void glGetUniformfv_Delegate(uint program, int location, float* parameters);

		internal delegate void glGetUniformiv_Delegate(uint program, int location, int* parameters);

		internal delegate void glGetVertexAttribdv_Delegate(uint index, uint pname, double* parameters);

		internal delegate void glGetVertexAttribfv_Delegate(uint index, uint pname, float* parameters);

		internal delegate void glGetVertexAttribiv_Delegate(uint index, uint pname, int* parameters);

		internal delegate void glGetVertexAttribPointerv_Delegate(uint index, uint pname, void** pointer);

		internal delegate byte glIsProgram_Delegate(uint program);

		internal delegate byte glIsShader_Delegate(uint shader);

		internal delegate void glLinkProgram_Delegate(uint program);

		internal delegate void glShaderSource_Delegate(uint shader, int count, byte** str, int* length);

		internal delegate void glUseProgram_Delegate(uint program);

		internal delegate void glUniform1f_Delegate(int location, float v0);

		internal delegate void glUniform2f_Delegate(int location, float v0, float v1);

		internal delegate void glUniform3f_Delegate(int location, float v0, float v1, float v2);

		internal delegate void glUniform4f_Delegate(int location, float v0, float v1, float v2, float v3);

		internal delegate void glUniform1i_Delegate(int location, int v0);

		internal delegate void glUniform2i_Delegate(int location, int v0, int v1);

		internal delegate void glUniform3i_Delegate(int location, int v0, int v1, int v2);

		internal delegate void glUniform4i_Delegate(int location, int v0, int v1, int v2, int v3);

		internal delegate void glUniform1fv_Delegate(int location, int count, float* value);

		internal delegate void glUniform2fv_Delegate(int location, int count, float* value);

		internal delegate void glUniform3fv_Delegate(int location, int count, float* value);

		internal delegate void glUniform4fv_Delegate(int location, int count, float* value);

		internal delegate void glUniform1iv_Delegate(int location, int count, int* value);

		internal delegate void glUniform2iv_Delegate(int location, int count, int* value);

		internal delegate void glUniform3iv_Delegate(int location, int count, int* value);

		internal delegate void glUniform4iv_Delegate(int location, int count, int* value);

		internal delegate void glUniformMatrix2fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glUniformMatrix3fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glUniformMatrix4fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glValidateProgram_Delegate(uint program);

		internal delegate void glVertexAttrib1d_Delegate(uint index, double x);

		internal delegate void glVertexAttrib1dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttrib1f_Delegate(uint index, float x);

		internal delegate void glVertexAttrib1fv_Delegate(uint index, float* v);

		internal delegate void glVertexAttrib1s_Delegate(uint index, short x);

		internal delegate void glVertexAttrib1sv_Delegate(uint index, short* v);

		internal delegate void glVertexAttrib2d_Delegate(uint index, double x, double y);

		internal delegate void glVertexAttrib2dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttrib2f_Delegate(uint index, float x, float y);

		internal delegate void glVertexAttrib2fv_Delegate(uint index, float* v);

		internal delegate void glVertexAttrib2s_Delegate(uint index, short x, short y);

		internal delegate void glVertexAttrib2sv_Delegate(uint index, short* v);

		internal delegate void glVertexAttrib3d_Delegate(uint index, double x, double y, double z);

		internal delegate void glVertexAttrib3dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttrib3f_Delegate(uint index, float x, float y, float z);

		internal delegate void glVertexAttrib3fv_Delegate(uint index, float* v);

		internal delegate void glVertexAttrib3s_Delegate(uint index, short x, short y, short z);

		internal delegate void glVertexAttrib3sv_Delegate(uint index, short* v);

		internal delegate void glVertexAttrib4Nbv_Delegate(uint index, sbyte* v);

		internal delegate void glVertexAttrib4Niv_Delegate(uint index, int* v);

		internal delegate void glVertexAttrib4Nsv_Delegate(uint index, short* v);

		internal delegate void glVertexAttrib4Nub_Delegate(uint index, byte x, byte y, byte z, byte w);

		internal delegate void glVertexAttrib4Nubv_Delegate(uint index, byte* v);

		internal delegate void glVertexAttrib4Nuiv_Delegate(uint index, uint* v);

		internal delegate void glVertexAttrib4Nusv_Delegate(uint index, ushort* v);

		internal delegate void glVertexAttrib4bv_Delegate(uint index, sbyte* v);

		internal delegate void glVertexAttrib4d_Delegate(uint index, double x, double y, double z, double w);

		internal delegate void glVertexAttrib4dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttrib4f_Delegate(uint index, float x, float y, float z, float w);

		internal delegate void glVertexAttrib4fv_Delegate(uint index, float* v);

		internal delegate void glVertexAttrib4iv_Delegate(uint index, int* v);

		internal delegate void glVertexAttrib4s_Delegate(uint index, short x, short y, short z, short w);

		internal delegate void glVertexAttrib4sv_Delegate(uint index, short* v);

		internal delegate void glVertexAttrib4ubv_Delegate(uint index, byte* v);

		internal delegate void glVertexAttrib4uiv_Delegate(uint index, uint* v);

		internal delegate void glVertexAttrib4usv_Delegate(uint index, ushort* v);

		internal delegate void glVertexAttribPointer_Delegate(uint index, int size, uint type, byte normalized, int stride, void* pointer);

		#endregion
		#region GL_VERSION_2_1
		internal delegate void glUniformMatrix2x3fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glUniformMatrix3x2fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glUniformMatrix2x4fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glUniformMatrix4x2fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glUniformMatrix3x4fv_Delegate(int location, int count, byte transpose, float* value);

		internal delegate void glUniformMatrix4x3fv_Delegate(int location, int count, byte transpose, float* value);

		#endregion
		#region GL_VERSION_3_0
		internal delegate void glColorMaski_Delegate(uint index, byte r, byte g, byte b, byte a);

		internal delegate void glGetBooleani_v_Delegate(uint target, uint index, byte* data);

		internal delegate void glGetIntegeri_v_Delegate(uint target, uint index, int* data);

		internal delegate void glEnablei_Delegate(uint target, uint index);

		internal delegate void glDisablei_Delegate(uint target, uint index);

		internal delegate byte glIsEnabledi_Delegate(uint target, uint index);

		internal delegate void glBeginTransformFeedback_Delegate(uint primitiveMode);

		internal delegate void glEndTransformFeedback_Delegate();

		internal delegate void glBindBufferRange_Delegate(uint target, uint index, uint buffer, nint offset, int size);

		internal delegate void glBindBufferBase_Delegate(uint target, uint index, uint buffer);

		internal delegate void glTransformFeedbackVaryings_Delegate(uint program, int count, byte** varyings, uint bufferMode);

		internal delegate void glGetTransformFeedbackVarying_Delegate(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);

		internal delegate void glClampColor_Delegate(uint target, uint clamp);

		internal delegate void glBeginConditionalRender_Delegate(uint id, uint mode);

		internal delegate void glEndConditionalRender_Delegate();

		internal delegate void glVertexAttribIPointer_Delegate(uint index, int size, uint type, int stride, void* pointer);

		internal delegate void glGetVertexAttribIiv_Delegate(uint index, uint pname, int* parameters);

		internal delegate void glGetVertexAttribIuiv_Delegate(uint index, uint pname, uint* parameters);

		internal delegate void glVertexAttribI1i_Delegate(uint index, int x);

		internal delegate void glVertexAttribI2i_Delegate(uint index, int x, int y);

		internal delegate void glVertexAttribI3i_Delegate(uint index, int x, int y, int z);

		internal delegate void glVertexAttribI4i_Delegate(uint index, int x, int y, int z, int w);

		internal delegate void glVertexAttribI1ui_Delegate(uint index, uint x);

		internal delegate void glVertexAttribI2ui_Delegate(uint index, uint x, uint y);

		internal delegate void glVertexAttribI3ui_Delegate(uint index, uint x, uint y, uint z);

		internal delegate void glVertexAttribI4ui_Delegate(uint index, uint x, uint y, uint z, uint w);

		internal delegate void glVertexAttribI1iv_Delegate(uint index, int* v);

		internal delegate void glVertexAttribI2iv_Delegate(uint index, int* v);

		internal delegate void glVertexAttribI3iv_Delegate(uint index, int* v);

		internal delegate void glVertexAttribI4iv_Delegate(uint index, int* v);

		internal delegate void glVertexAttribI1uiv_Delegate(uint index, uint* v);

		internal delegate void glVertexAttribI2uiv_Delegate(uint index, uint* v);

		internal delegate void glVertexAttribI3uiv_Delegate(uint index, uint* v);

		internal delegate void glVertexAttribI4uiv_Delegate(uint index, uint* v);

		internal delegate void glVertexAttribI4bv_Delegate(uint index, sbyte* v);

		internal delegate void glVertexAttribI4sv_Delegate(uint index, short* v);

		internal delegate void glVertexAttribI4ubv_Delegate(uint index, byte* v);

		internal delegate void glVertexAttribI4usv_Delegate(uint index, ushort* v);

		internal delegate void glGetUniformuiv_Delegate(uint program, int location, uint* parameters);

		internal delegate void glBindFragDataLocation_Delegate(uint program, uint color, byte* name);

		internal delegate int glGetFragDataLocation_Delegate(uint program, byte* name);

		internal delegate void glUniform1ui_Delegate(int location, uint v0);

		internal delegate void glUniform2ui_Delegate(int location, uint v0, uint v1);

		internal delegate void glUniform3ui_Delegate(int location, uint v0, uint v1, uint v2);

		internal delegate void glUniform4ui_Delegate(int location, uint v0, uint v1, uint v2, uint v3);

		internal delegate void glUniform1uiv_Delegate(int location, int count, uint* value);

		internal delegate void glUniform2uiv_Delegate(int location, int count, uint* value);

		internal delegate void glUniform3uiv_Delegate(int location, int count, uint* value);

		internal delegate void glUniform4uiv_Delegate(int location, int count, uint* value);

		internal delegate void glTexParameterIiv_Delegate(uint target, uint pname, int* parameters);

		internal delegate void glTexParameterIuiv_Delegate(uint target, uint pname, uint* parameters);

		internal delegate void glGetTexParameterIiv_Delegate(uint target, uint pname, int* parameters);

		internal delegate void glGetTexParameterIuiv_Delegate(uint target, uint pname, uint* parameters);

		internal delegate void glClearBufferiv_Delegate(uint buffer, int drawbuffer, int* value);

		internal delegate void glClearBufferuiv_Delegate(uint buffer, int drawbuffer, uint* value);

		internal delegate void glClearBufferfv_Delegate(uint buffer, int drawbuffer, float* value);

		internal delegate void glClearBufferfi_Delegate(uint buffer, int drawbuffer, float depth, int stencil);

		internal delegate byte glIsRenderbuffer_Delegate(uint renderbuffer);

		internal delegate void glBindRenderbuffer_Delegate(uint target, uint renderbuffer);

		internal delegate void glDeleteRenderbuffers_Delegate(int n, uint* renderbuffers);

		internal delegate void glGenRenderbuffers_Delegate(int n, uint* renderbuffers);

		internal delegate void glRenderbufferStorage_Delegate(uint target, uint internalformat, int width, int height);

		internal delegate void glGetRenderbufferParameteriv_Delegate(uint target, uint pname, int* parameters);

		internal delegate byte glIsFramebuffer_Delegate(uint framebuffer);

		internal delegate void glBindFramebuffer_Delegate(uint target, uint framebuffer);

		internal delegate void glDeleteFramebuffers_Delegate(int n, uint* framebuffers);

		internal delegate void glGenFramebuffers_Delegate(int n, uint* framebuffers);

		internal delegate uint glCheckFramebufferStatus_Delegate(uint target);

		internal delegate void glFramebufferTexture1D_Delegate(uint target, uint attachment, uint textarget, uint texture, int level);

		internal delegate void glFramebufferTexture2D_Delegate(uint target, uint attachment, uint textarget, uint texture, int level);

		internal delegate void glFramebufferTexture3D_Delegate(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);

		internal delegate void glFramebufferRenderbuffer_Delegate(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

		internal delegate void glGetFramebufferAttachmentParameteriv_Delegate(uint target, uint attachment, uint pname, int* parameters);

		internal delegate void glGenerateMipmap_Delegate(uint target);

		internal delegate void glBlitFramebuffer_Delegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

		internal delegate void glRenderbufferStorageMultisample_Delegate(uint target, int samples, uint internalformat, int width, int height);

		internal delegate void glFramebufferTextureLayer_Delegate(uint target, uint attachment, uint texture, int level, int layer);

		internal delegate void glFlushMappedBufferRange_Delegate(uint target, nint offset, int length);

		internal delegate void glBindVertexArray_Delegate(uint array);

		internal delegate void glDeleteVertexArrays_Delegate(int n, uint* arrays);

		internal delegate void glGenVertexArrays_Delegate(int n, uint* arrays);

		internal delegate byte glIsVertexArray_Delegate(uint array);

		#endregion
		#region GL_VERSION_3_1
		internal delegate void glDrawArraysInstanced_Delegate(uint mode, int first, int count, int instancecount);

		internal delegate void glDrawElementsInstanced_Delegate(uint mode, int count, uint type, void* indices, int instancecount);

		internal delegate void glTexBuffer_Delegate(uint target, uint internalformat, uint buffer);

		internal delegate void glPrimitiveRestartIndex_Delegate(uint index);

		internal delegate void glCopyBufferSubData_Delegate(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, int size);

		internal delegate void glGetUniformIndices_Delegate(uint program, int uniformCount, byte** uniformNames, uint* uniformIndices);

		internal delegate void glGetActiveUniformsiv_Delegate(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters);

		internal delegate void glGetActiveUniformName_Delegate(uint program, uint uniformIndex, int bufSize, int* length, byte* uniformName);

		internal delegate uint glGetUniformBlockIndex_Delegate(uint program, byte* uniformBlockName);

		internal delegate void glGetActiveUniformBlockiv_Delegate(uint program, uint uniformBlockIndex, uint pname, int* parameters);

		internal delegate void glGetActiveUniformBlockName_Delegate(uint program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName);

		internal delegate void glUniformBlockBinding_Delegate(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

		#endregion
		#region GL_VERSION_3_2
		internal delegate void glDrawElementsBaseVertex_Delegate(uint mode, int count, uint type, void* indices, int basevertex);

		internal delegate void glDrawRangeElementsBaseVertex_Delegate(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);

		internal delegate void glDrawElementsInstancedBaseVertex_Delegate(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);

		internal delegate void glMultiDrawElementsBaseVertex_Delegate(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex);

		internal delegate void glProvokingVertex_Delegate(uint mode);

		internal delegate nint glFenceSync_Delegate(uint condition, uint flags);

		internal delegate byte glIsSync_Delegate(nint sync);

		internal delegate void glDeleteSync_Delegate(nint sync);

		internal delegate uint glClientWaitSync_Delegate(nint sync, uint flags, ulong timeout);

		internal delegate void glWaitSync_Delegate(nint sync, uint flags, ulong timeout);

		internal delegate void glGetInteger64v_Delegate(uint pname, long* data);

		internal delegate void glGetSynciv_Delegate(nint sync, uint pname, int count, int* length, int* values);

		internal delegate void glGetInteger64i_v_Delegate(uint target, uint index, long* data);

		internal delegate void glGetBufferParameteri64v_Delegate(uint target, uint pname, long* parameters);

		internal delegate void glFramebufferTexture_Delegate(uint target, uint attachment, uint texture, int level);

		internal delegate void glTexImage2DMultisample_Delegate(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);

		internal delegate void glTexImage3DMultisample_Delegate(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);

		internal delegate void glGetMultisamplefv_Delegate(uint pname, uint index, float* val);

		internal delegate void glSampleMaski_Delegate(uint maskNumber, uint mask);

		#endregion
		#region GL_VERSION_3_3
		internal delegate void glBindFragDataLocationIndexed_Delegate(uint program, uint colorNumber, uint index, byte* name);

		internal delegate int glGetFragDataIndex_Delegate(uint program, byte* name);

		internal delegate void glGenSamplers_Delegate(int count, uint* samplers);

		internal delegate void glDeleteSamplers_Delegate(int count, uint* samplers);

		internal delegate byte glIsSampler_Delegate(uint sampler);

		internal delegate void glBindSampler_Delegate(uint unit, uint sampler);

		internal delegate void glSamplerParameteri_Delegate(uint sampler, uint pname, int param);

		internal delegate void glSamplerParameteriv_Delegate(uint sampler, uint pname, int* param);

		internal delegate void glSamplerParameterf_Delegate(uint sampler, uint pname, float param);

		internal delegate void glSamplerParameterfv_Delegate(uint sampler, uint pname, float* param);

		internal delegate void glSamplerParameterIiv_Delegate(uint sampler, uint pname, int* param);

		internal delegate void glSamplerParameterIuiv_Delegate(uint sampler, uint pname, uint* param);

		internal delegate void glGetSamplerParameteriv_Delegate(uint sampler, uint pname, int* parameters);

		internal delegate void glGetSamplerParameterIiv_Delegate(uint sampler, uint pname, int* parameters);

		internal delegate void glGetSamplerParameterfv_Delegate(uint sampler, uint pname, float* parameters);

		internal delegate void glGetSamplerParameterIuiv_Delegate(uint sampler, uint pname, uint* parameters);

		internal delegate void glQueryCounter_Delegate(uint id, uint target);

		internal delegate void glGetQueryObjecti64v_Delegate(uint id, uint pname, long* parameters);

		internal delegate void glGetQueryObjectui64v_Delegate(uint id, uint pname, ulong* parameters);

		internal delegate void glVertexAttribDivisor_Delegate(uint index, uint divisor);

		internal delegate void glVertexAttribP1ui_Delegate(uint index, uint type, byte normalized, uint value);

		internal delegate void glVertexAttribP1uiv_Delegate(uint index, uint type, byte normalized, uint* value);

		internal delegate void glVertexAttribP2ui_Delegate(uint index, uint type, byte normalized, uint value);

		internal delegate void glVertexAttribP2uiv_Delegate(uint index, uint type, byte normalized, uint* value);

		internal delegate void glVertexAttribP3ui_Delegate(uint index, uint type, byte normalized, uint value);

		internal delegate void glVertexAttribP3uiv_Delegate(uint index, uint type, byte normalized, uint* value);

		internal delegate void glVertexAttribP4ui_Delegate(uint index, uint type, byte normalized, uint value);

		internal delegate void glVertexAttribP4uiv_Delegate(uint index, uint type, byte normalized, uint* value);

		#endregion
		#region GL_VERSION_4_0
		internal delegate void glMinSampleShading_Delegate(float value);

		internal delegate void glBlendEquationi_Delegate(uint buf, uint mode);

		internal delegate void glBlendEquationSeparatei_Delegate(uint buf, uint modeRGB, uint modeAlpha);

		internal delegate void glBlendFunci_Delegate(uint buf, uint src, uint dst);

		internal delegate void glBlendFuncSeparatei_Delegate(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

		internal delegate void glDrawArraysIndirect_Delegate(uint mode, void* indirect);

		internal delegate void glDrawElementsIndirect_Delegate(uint mode, uint type, void* indirect);

		internal delegate void glUniform1d_Delegate(int location, double x);

		internal delegate void glUniform2d_Delegate(int location, double x, double y);

		internal delegate void glUniform3d_Delegate(int location, double x, double y, double z);

		internal delegate void glUniform4d_Delegate(int location, double x, double y, double z, double w);

		internal delegate void glUniform1dv_Delegate(int location, int count, double* value);

		internal delegate void glUniform2dv_Delegate(int location, int count, double* value);

		internal delegate void glUniform3dv_Delegate(int location, int count, double* value);

		internal delegate void glUniform4dv_Delegate(int location, int count, double* value);

		internal delegate void glUniformMatrix2dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix3dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix4dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix2x3dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix2x4dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix3x2dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix3x4dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix4x2dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glUniformMatrix4x3dv_Delegate(int location, int count, byte transpose, double* value);

		internal delegate void glGetUniformdv_Delegate(uint program, int location, double* parameters);

		internal delegate int glGetSubroutineUniformLocation_Delegate(uint program, uint shadertype, byte* name);

		internal delegate uint glGetSubroutineIndex_Delegate(uint program, uint shadertype, byte* name);

		internal delegate void glGetActiveSubroutineUniformiv_Delegate(uint program, uint shadertype, uint index, uint pname, int* values);

		internal delegate void glGetActiveSubroutineUniformName_Delegate(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name);

		internal delegate void glGetActiveSubroutineName_Delegate(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name);

		internal delegate void glUniformSubroutinesuiv_Delegate(uint shadertype, int count, uint* indices);

		internal delegate void glGetUniformSubroutineuiv_Delegate(uint shadertype, int location, uint* parameters);

		internal delegate void glGetProgramStageiv_Delegate(uint program, uint shadertype, uint pname, int* values);

		internal delegate void glPatchParameteri_Delegate(uint pname, int value);

		internal delegate void glPatchParameterfv_Delegate(uint pname, float* values);

		internal delegate void glBindTransformFeedback_Delegate(uint target, uint id);

		internal delegate void glDeleteTransformFeedbacks_Delegate(int n, uint* ids);

		internal delegate void glGenTransformFeedbacks_Delegate(int n, uint* ids);

		internal delegate byte glIsTransformFeedback_Delegate(uint id);

		internal delegate void glPauseTransformFeedback_Delegate();

		internal delegate void glResumeTransformFeedback_Delegate();

		internal delegate void glDrawTransformFeedback_Delegate(uint mode, uint id);

		internal delegate void glDrawTransformFeedbackStream_Delegate(uint mode, uint id, uint stream);

		internal delegate void glBeginQueryIndexed_Delegate(uint target, uint index, uint id);

		internal delegate void glEndQueryIndexed_Delegate(uint target, uint index);

		internal delegate void glGetQueryIndexediv_Delegate(uint target, uint index, uint pname, int* parameters);

		#endregion
		#region GL_VERSION_4_1
		internal delegate void glReleaseShaderCompiler_Delegate();

		internal delegate void glShaderBinary_Delegate(int count, uint* shaders, uint binaryFormat, void* binary, int length);

		internal delegate void glGetShaderPrecisionFormat_Delegate(uint shadertype, uint precisiontype, int* range, int* precision);

		internal delegate void glDepthRangef_Delegate(float n, float f);

		internal delegate void glClearDepthf_Delegate(float d);

		internal delegate void glGetProgramBinary_Delegate(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);

		internal delegate void glProgramBinary_Delegate(uint program, uint binaryFormat, void* binary, int length);

		internal delegate void glProgramParameteri_Delegate(uint program, uint pname, int value);

		internal delegate void glUseProgramStages_Delegate(uint pipeline, uint stages, uint program);

		internal delegate void glActiveShaderProgram_Delegate(uint pipeline, uint program);

		internal delegate uint glCreateShaderProgramv_Delegate(uint type, int count, byte** strings);

		internal delegate void glBindProgramPipeline_Delegate(uint pipeline);

		internal delegate void glDeleteProgramPipelines_Delegate(int n, uint* pipelines);

		internal delegate void glGenProgramPipelines_Delegate(int n, uint* pipelines);

		internal delegate byte glIsProgramPipeline_Delegate(uint pipeline);

		internal delegate void glGetProgramPipelineiv_Delegate(uint pipeline, uint pname, int* parameters);

		internal delegate void glProgramUniform1i_Delegate(uint program, int location, int v0);

		internal delegate void glProgramUniform1iv_Delegate(uint program, int location, int count, int* value);

		internal delegate void glProgramUniform1f_Delegate(uint program, int location, float v0);

		internal delegate void glProgramUniform1fv_Delegate(uint program, int location, int count, float* value);

		internal delegate void glProgramUniform1d_Delegate(uint program, int location, double v0);

		internal delegate void glProgramUniform1dv_Delegate(uint program, int location, int count, double* value);

		internal delegate void glProgramUniform1ui_Delegate(uint program, int location, uint v0);

		internal delegate void glProgramUniform1uiv_Delegate(uint program, int location, int count, uint* value);

		internal delegate void glProgramUniform2i_Delegate(uint program, int location, int v0, int v1);

		internal delegate void glProgramUniform2iv_Delegate(uint program, int location, int count, int* value);

		internal delegate void glProgramUniform2f_Delegate(uint program, int location, float v0, float v1);

		internal delegate void glProgramUniform2fv_Delegate(uint program, int location, int count, float* value);

		internal delegate void glProgramUniform2d_Delegate(uint program, int location, double v0, double v1);

		internal delegate void glProgramUniform2dv_Delegate(uint program, int location, int count, double* value);

		internal delegate void glProgramUniform2ui_Delegate(uint program, int location, uint v0, uint v1);

		internal delegate void glProgramUniform2uiv_Delegate(uint program, int location, int count, uint* value);

		internal delegate void glProgramUniform3i_Delegate(uint program, int location, int v0, int v1, int v2);

		internal delegate void glProgramUniform3iv_Delegate(uint program, int location, int count, int* value);

		internal delegate void glProgramUniform3f_Delegate(uint program, int location, float v0, float v1, float v2);

		internal delegate void glProgramUniform3fv_Delegate(uint program, int location, int count, float* value);

		internal delegate void glProgramUniform3d_Delegate(uint program, int location, double v0, double v1, double v2);

		internal delegate void glProgramUniform3dv_Delegate(uint program, int location, int count, double* value);

		internal delegate void glProgramUniform3ui_Delegate(uint program, int location, uint v0, uint v1, uint v2);

		internal delegate void glProgramUniform3uiv_Delegate(uint program, int location, int count, uint* value);

		internal delegate void glProgramUniform4i_Delegate(uint program, int location, int v0, int v1, int v2, int v3);

		internal delegate void glProgramUniform4iv_Delegate(uint program, int location, int count, int* value);

		internal delegate void glProgramUniform4f_Delegate(uint program, int location, float v0, float v1, float v2, float v3);

		internal delegate void glProgramUniform4fv_Delegate(uint program, int location, int count, float* value);

		internal delegate void glProgramUniform4d_Delegate(uint program, int location, double v0, double v1, double v2, double v3);

		internal delegate void glProgramUniform4dv_Delegate(uint program, int location, int count, double* value);

		internal delegate void glProgramUniform4ui_Delegate(uint program, int location, uint v0, uint v1, uint v2, uint v3);

		internal delegate void glProgramUniform4uiv_Delegate(uint program, int location, int count, uint* value);

		internal delegate void glProgramUniformMatrix2fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix3fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix4fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix2dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix3dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix4dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix2x3fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix3x2fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix2x4fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix4x2fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix3x4fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix4x3fv_Delegate(uint program, int location, int count, byte transpose, float* value);

		internal delegate void glProgramUniformMatrix2x3dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix3x2dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix2x4dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix4x2dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix3x4dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glProgramUniformMatrix4x3dv_Delegate(uint program, int location, int count, byte transpose, double* value);

		internal delegate void glValidateProgramPipeline_Delegate(uint pipeline);

		internal delegate void glGetProgramPipelineInfoLog_Delegate(uint pipeline, int bufSize, int* length, byte* infoLog);

		internal delegate void glVertexAttribL1d_Delegate(uint index, double x);

		internal delegate void glVertexAttribL2d_Delegate(uint index, double x, double y);

		internal delegate void glVertexAttribL3d_Delegate(uint index, double x, double y, double z);

		internal delegate void glVertexAttribL4d_Delegate(uint index, double x, double y, double z, double w);

		internal delegate void glVertexAttribL1dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttribL2dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttribL3dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttribL4dv_Delegate(uint index, double* v);

		internal delegate void glVertexAttribLPointer_Delegate(uint index, int size, uint type, int stride, void* pointer);

		internal delegate void glGetVertexAttribLdv_Delegate(uint index, uint pname, double* parameters);

		internal delegate void glViewportArrayv_Delegate(uint first, int count, float* v);

		internal delegate void glViewportIndexedf_Delegate(uint index, float x, float y, float w, float h);

		internal delegate void glViewportIndexedfv_Delegate(uint index, float* v);

		internal delegate void glScissorArrayv_Delegate(uint first, int count, int* v);

		internal delegate void glScissorIndexed_Delegate(uint index, int left, int bottom, int width, int height);

		internal delegate void glScissorIndexedv_Delegate(uint index, int* v);

		internal delegate void glDepthRangeArrayv_Delegate(uint first, int count, double* v);

		internal delegate void glDepthRangeIndexed_Delegate(uint index, double n, double f);

		internal delegate void glGetFloati_v_Delegate(uint target, uint index, float* data);

		internal delegate void glGetDoublei_v_Delegate(uint target, uint index, double* data);

		#endregion
		#region GL_VERSION_4_2
		internal delegate void glDrawArraysInstancedBaseInstance_Delegate(uint mode, int first, int count, int instancecount, uint baseinstance);

		internal delegate void glDrawElementsInstancedBaseInstance_Delegate(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);

		internal delegate void glDrawElementsInstancedBaseVertexBaseInstance_Delegate(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);

		internal delegate void glGetInternalformativ_Delegate(uint target, uint internalformat, uint pname, int count, int* parameters);

		internal delegate void glGetActiveAtomicCounterBufferiv_Delegate(uint program, uint bufferIndex, uint pname, int* parameters);

		internal delegate void glBindImageTexture_Delegate(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format);

		internal delegate void glMemoryBarrier_Delegate(uint barriers);

		internal delegate void glTexStorage1D_Delegate(uint target, int levels, uint internalformat, int width);

		internal delegate void glTexStorage2D_Delegate(uint target, int levels, uint internalformat, int width, int height);

		internal delegate void glTexStorage3D_Delegate(uint target, int levels, uint internalformat, int width, int height, int depth);

		internal delegate void glDrawTransformFeedbackInstanced_Delegate(uint mode, uint id, int instancecount);

		internal delegate void glDrawTransformFeedbackStreamInstanced_Delegate(uint mode, uint id, uint stream, int instancecount);

		#endregion
		#region GL_VERSION_4_3
		internal delegate void glClearBufferData_Delegate(uint target, uint internalformat, uint format, uint type, void* data);

		internal delegate void glClearBufferSubData_Delegate(uint target, uint internalformat, nint offset, int size, uint format, uint type, void* data);

		internal delegate void glDispatchCompute_Delegate(uint num_groups_x, uint num_groups_y, uint num_groups_z);

		internal delegate void glDispatchComputeIndirect_Delegate(nint indirect);

		internal delegate void glCopyImageSubData_Delegate(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

		internal delegate void glFramebufferParameteri_Delegate(uint target, uint pname, int param);

		internal delegate void glGetFramebufferParameteriv_Delegate(uint target, uint pname, int* parameters);

		internal delegate void glGetInternalformati64v_Delegate(uint target, uint internalformat, uint pname, int count, long* parameters);

		internal delegate void glInvalidateTexSubImage_Delegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

		internal delegate void glInvalidateTexImage_Delegate(uint texture, int level);

		internal delegate void glInvalidateBufferSubData_Delegate(uint buffer, nint offset, int length);

		internal delegate void glInvalidateBufferData_Delegate(uint buffer);

		internal delegate void glInvalidateFramebuffer_Delegate(uint target, int numAttachments, uint* attachments);

		internal delegate void glInvalidateSubFramebuffer_Delegate(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);

		internal delegate void glMultiDrawArraysIndirect_Delegate(uint mode, void* indirect, int drawcount, int stride);

		internal delegate void glMultiDrawElementsIndirect_Delegate(uint mode, uint type, void* indirect, int drawcount, int stride);

		internal delegate void glGetProgramInterfaceiv_Delegate(uint program, uint programInterface, uint pname, int* parameters);

		internal delegate uint glGetProgramResourceIndex_Delegate(uint program, uint programInterface, byte* name);

		internal delegate void glGetProgramResourceName_Delegate(uint program, uint programInterface, uint index, int bufSize, int* length, byte* name);

		internal delegate void glGetProgramResourceiv_Delegate(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* parameters);

		internal delegate int glGetProgramResourceLocation_Delegate(uint program, uint programInterface, byte* name);

		internal delegate int glGetProgramResourceLocationIndex_Delegate(uint program, uint programInterface, byte* name);

		internal delegate void glShaderStorageBlockBinding_Delegate(uint program, uint storageBlockIndex, uint storageBlockBinding);

		internal delegate void glTexBufferRange_Delegate(uint target, uint internalformat, uint buffer, nint offset, int size);

		internal delegate void glTexStorage2DMultisample_Delegate(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);

		internal delegate void glTexStorage3DMultisample_Delegate(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);

		internal delegate void glTextureView_Delegate(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

		internal delegate void glBindVertexBuffer_Delegate(uint bindingindex, uint buffer, nint offset, int stride);

		internal delegate void glVertexAttribFormat_Delegate(uint attribindex, int size, uint type, byte normalized, uint relativeoffset);

		internal delegate void glVertexAttribIFormat_Delegate(uint attribindex, int size, uint type, uint relativeoffset);

		internal delegate void glVertexAttribLFormat_Delegate(uint attribindex, int size, uint type, uint relativeoffset);

		internal delegate void glVertexAttribBinding_Delegate(uint attribindex, uint bindingindex);

		internal delegate void glVertexBindingDivisor_Delegate(uint bindingindex, uint divisor);

		internal delegate void glDebugMessageControl_Delegate(uint source, uint type, uint severity, int count, uint* ids, byte enabled);

		internal delegate void glDebugMessageInsert_Delegate(uint source, uint type, uint id, uint severity, int length, byte* buf);

		internal delegate void glDebugMessageCallback_Delegate(DebugMessageCallback callback, void* userParam);

		internal delegate uint glGetDebugMessageLog_Delegate(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, byte* messageLog);

		internal delegate void glPushDebugGroup_Delegate(uint source, uint id, int length, byte* message);

		internal delegate void glPopDebugGroup_Delegate();

		internal delegate void glObjectLabel_Delegate(uint identifier, uint name, int length, byte* label);

		internal delegate void glGetObjectLabel_Delegate(uint identifier, uint name, int bufSize, int* length, byte* label);

		internal delegate void glObjectPtrLabel_Delegate(void* ptr, int length, byte* label);

		internal delegate void glGetObjectPtrLabel_Delegate(void* ptr, int bufSize, int* length, byte* label);

		#endregion
		#region GL_VERSION_4_4
		internal delegate void glBufferStorage_Delegate(uint target, int size, void* data, uint flags);

		internal delegate void glClearTexImage_Delegate(uint texture, int level, uint format, uint type, void* data);

		internal delegate void glClearTexSubImage_Delegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);

		internal delegate void glBindBuffersBase_Delegate(uint target, uint first, int count, uint* buffers);

		internal delegate void glBindBuffersRange_Delegate(uint target, uint first, int count, uint* buffers, nint* offsets, int* sizes);

		internal delegate void glBindTextures_Delegate(uint first, int count, uint* textures);

		internal delegate void glBindSamplers_Delegate(uint first, int count, uint* samplers);

		internal delegate void glBindImageTextures_Delegate(uint first, int count, uint* textures);

		internal delegate void glBindVertexBuffers_Delegate(uint first, int count, uint* buffers, nint* offsets, int* strides);

		#endregion
		#region GL_VERSION_4_5
		internal delegate void glClipControl_Delegate(uint origin, uint depth);

		internal delegate void glCreateTransformFeedbacks_Delegate(int n, uint* ids);

		internal delegate void glTransformFeedbackBufferBase_Delegate(uint xfb, uint index, uint buffer);

		internal delegate void glTransformFeedbackBufferRange_Delegate(uint xfb, uint index, uint buffer, nint offset, int size);

		internal delegate void glGetTransformFeedbackiv_Delegate(uint xfb, uint pname, int* param);

		internal delegate void glGetTransformFeedbacki_v_Delegate(uint xfb, uint pname, uint index, int* param);

		internal delegate void glGetTransformFeedbacki64_v_Delegate(uint xfb, uint pname, uint index, long* param);

		internal delegate void glCreateBuffers_Delegate(int n, uint* buffers);

		internal delegate void glNamedBufferStorage_Delegate(uint buffer, int size, void* data, uint flags);

		internal delegate void glNamedBufferData_Delegate(uint buffer, int size, void* data, uint usage);

		internal delegate void glNamedBufferSubData_Delegate(uint buffer, nint offset, int size, void* data);

		internal delegate void glCopyNamedBufferSubData_Delegate(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, int size);

		internal delegate void glClearNamedBufferData_Delegate(uint buffer, uint internalformat, uint format, uint type, void* data);

		internal delegate void glClearNamedBufferSubData_Delegate(uint buffer, uint internalformat, nint offset, int size, uint format, uint type, void* data);

		internal delegate byte glUnmapNamedBuffer_Delegate(uint buffer);

		internal delegate void glFlushMappedNamedBufferRange_Delegate(uint buffer, nint offset, int length);

		internal delegate void glGetNamedBufferParameteriv_Delegate(uint buffer, uint pname, int* parameters);

		internal delegate void glGetNamedBufferParameteri64v_Delegate(uint buffer, uint pname, long* parameters);

		internal delegate void glGetNamedBufferPointerv_Delegate(uint buffer, uint pname, void** parameters);

		internal delegate void glGetNamedBufferSubData_Delegate(uint buffer, nint offset, int size, void* data);

		internal delegate void glCreateFramebuffers_Delegate(int n, uint* framebuffers);

		internal delegate void glNamedFramebufferRenderbuffer_Delegate(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);

		internal delegate void glNamedFramebufferParameteri_Delegate(uint framebuffer, uint pname, int param);

		internal delegate void glNamedFramebufferTexture_Delegate(uint framebuffer, uint attachment, uint texture, int level);

		internal delegate void glNamedFramebufferTextureLayer_Delegate(uint framebuffer, uint attachment, uint texture, int level, int layer);

		internal delegate void glNamedFramebufferDrawBuffer_Delegate(uint framebuffer, uint buf);

		internal delegate void glNamedFramebufferDrawBuffers_Delegate(uint framebuffer, int n, uint* bufs);

		internal delegate void glNamedFramebufferReadBuffer_Delegate(uint framebuffer, uint src);

		internal delegate void glInvalidateNamedFramebufferData_Delegate(uint framebuffer, int numAttachments, uint* attachments);

		internal delegate void glInvalidateNamedFramebufferSubData_Delegate(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height);

		internal delegate void glClearNamedFramebufferiv_Delegate(uint framebuffer, uint buffer, int drawbuffer, int* value);

		internal delegate void glClearNamedFramebufferuiv_Delegate(uint framebuffer, uint buffer, int drawbuffer, uint* value);

		internal delegate void glClearNamedFramebufferfv_Delegate(uint framebuffer, uint buffer, int drawbuffer, float* value);

		internal delegate void glClearNamedFramebufferfi_Delegate(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

		internal delegate void glBlitNamedFramebuffer_Delegate(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

		internal delegate uint glCheckNamedFramebufferStatus_Delegate(uint framebuffer, uint target);

		internal delegate void glGetNamedFramebufferParameteriv_Delegate(uint framebuffer, uint pname, int* param);

		internal delegate void glGetNamedFramebufferAttachmentParameteriv_Delegate(uint framebuffer, uint attachment, uint pname, int* parameters);

		internal delegate void glCreateRenderbuffers_Delegate(int n, uint* renderbuffers);

		internal delegate void glNamedRenderbufferStorage_Delegate(uint renderbuffer, uint internalformat, int width, int height);

		internal delegate void glNamedRenderbufferStorageMultisample_Delegate(uint renderbuffer, int samples, uint internalformat, int width, int height);

		internal delegate void glGetNamedRenderbufferParameteriv_Delegate(uint renderbuffer, uint pname, int* parameters);

		internal delegate void glCreateTextures_Delegate(uint target, int n, uint* textures);

		internal delegate void glTextureBuffer_Delegate(uint texture, uint internalformat, uint buffer);

		internal delegate void glTextureBufferRange_Delegate(uint texture, uint internalformat, uint buffer, nint offset, int size);

		internal delegate void glTextureStorage1D_Delegate(uint texture, int levels, uint internalformat, int width);

		internal delegate void glTextureStorage2D_Delegate(uint texture, int levels, uint internalformat, int width, int height);

		internal delegate void glTextureStorage3D_Delegate(uint texture, int levels, uint internalformat, int width, int height, int depth);

		internal delegate void glTextureStorage2DMultisample_Delegate(uint texture, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);

		internal delegate void glTextureStorage3DMultisample_Delegate(uint texture, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);

		internal delegate void glTextureSubImage1D_Delegate(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels);

		internal delegate void glTextureSubImage2D_Delegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

		internal delegate void glTextureSubImage3D_Delegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

		internal delegate void glCompressedTextureSubImage1D_Delegate(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data);

		internal delegate void glCompressedTextureSubImage2D_Delegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

		internal delegate void glCompressedTextureSubImage3D_Delegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

		internal delegate void glCopyTextureSubImage1D_Delegate(uint texture, int level, int xoffset, int x, int y, int width);

		internal delegate void glCopyTextureSubImage2D_Delegate(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		internal delegate void glCopyTextureSubImage3D_Delegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		internal delegate void glTextureParameterf_Delegate(uint texture, uint pname, float param);

		internal delegate void glTextureParameterfv_Delegate(uint texture, uint pname, float* param);

		internal delegate void glTextureParameteri_Delegate(uint texture, uint pname, int param);

		internal delegate void glTextureParameterIiv_Delegate(uint texture, uint pname, int* parameters);

		internal delegate void glTextureParameterIuiv_Delegate(uint texture, uint pname, uint* parameters);

		internal delegate void glTextureParameteriv_Delegate(uint texture, uint pname, int* param);

		internal delegate void glGenerateTextureMipmap_Delegate(uint texture);

		internal delegate void glBindTextureUnit_Delegate(uint unit, uint texture);

		internal delegate void glGetTextureImage_Delegate(uint texture, int level, uint format, uint type, int bufSize, void* pixels);

		internal delegate void glGetCompressedTextureImage_Delegate(uint texture, int level, int bufSize, void* pixels);

		internal delegate void glGetTextureLevelParameterfv_Delegate(uint texture, int level, uint pname, float* parameters);

		internal delegate void glGetTextureLevelParameteriv_Delegate(uint texture, int level, uint pname, int* parameters);

		internal delegate void glGetTextureParameterfv_Delegate(uint texture, uint pname, float* parameters);

		internal delegate void glGetTextureParameterIiv_Delegate(uint texture, uint pname, int* parameters);

		internal delegate void glGetTextureParameterIuiv_Delegate(uint texture, uint pname, uint* parameters);

		internal delegate void glGetTextureParameteriv_Delegate(uint texture, uint pname, int* parameters);

		internal delegate void glCreateVertexArrays_Delegate(int n, uint* arrays);

		internal delegate void glDisableVertexArrayAttrib_Delegate(uint vaobj, uint index);

		internal delegate void glEnableVertexArrayAttrib_Delegate(uint vaobj, uint index);

		internal delegate void glVertexArrayElementBuffer_Delegate(uint vaobj, uint buffer);

		internal delegate void glVertexArrayVertexBuffer_Delegate(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride);

		internal delegate void glVertexArrayVertexBuffers_Delegate(uint vaobj, uint first, int count, uint* buffers, nint* offsets, int* strides);

		internal delegate void glVertexArrayAttribBinding_Delegate(uint vaobj, uint attribindex, uint bindingindex);

		internal delegate void glVertexArrayAttribFormat_Delegate(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset);

		internal delegate void glVertexArrayAttribIFormat_Delegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

		internal delegate void glVertexArrayAttribLFormat_Delegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

		internal delegate void glVertexArrayBindingDivisor_Delegate(uint vaobj, uint bindingindex, uint divisor);

		internal delegate void glGetVertexArrayiv_Delegate(uint vaobj, uint pname, int* param);

		internal delegate void glGetVertexArrayIndexediv_Delegate(uint vaobj, uint index, uint pname, int* param);

		internal delegate void glGetVertexArrayIndexed64iv_Delegate(uint vaobj, uint index, uint pname, long* param);

		internal delegate void glCreateSamplers_Delegate(int n, uint* samplers);

		internal delegate void glCreateProgramPipelines_Delegate(int n, uint* pipelines);

		internal delegate void glCreateQueries_Delegate(uint target, int n, uint* ids);

		internal delegate void glGetQueryBufferObjecti64v_Delegate(uint id, uint buffer, uint pname, nint offset);

		internal delegate void glGetQueryBufferObjectiv_Delegate(uint id, uint buffer, uint pname, nint offset);

		internal delegate void glGetQueryBufferObjectui64v_Delegate(uint id, uint buffer, uint pname, nint offset);

		internal delegate void glGetQueryBufferObjectuiv_Delegate(uint id, uint buffer, uint pname, nint offset);

		internal delegate void glMemoryBarrierByRegion_Delegate(uint barriers);

		internal delegate void glGetTextureSubImage_Delegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels);

		internal delegate void glGetCompressedTextureSubImage_Delegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels);

		internal delegate uint glGetGraphicsResetStatus_Delegate();

		internal delegate void glGetnCompressedTexImage_Delegate(uint target, int lod, int bufSize, void* pixels);

		internal delegate void glGetnTexImage_Delegate(uint target, int level, uint format, uint type, int bufSize, void* pixels);

		internal delegate void glGetnUniformdv_Delegate(uint program, int location, int bufSize, double* parameters);

		internal delegate void glGetnUniformfv_Delegate(uint program, int location, int bufSize, float* parameters);

		internal delegate void glGetnUniformiv_Delegate(uint program, int location, int bufSize, int* parameters);

		internal delegate void glGetnUniformuiv_Delegate(uint program, int location, int bufSize, uint* parameters);

		internal delegate void glReadnPixels_Delegate(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);

		internal delegate void glTextureBarrier_Delegate();

		#endregion
		#region GL_VERSION_4_6
		internal delegate void glSpecializeShader_Delegate(uint shader, byte* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

		internal delegate void glMultiDrawArraysIndirectCount_Delegate(uint mode, void* indirect, nint drawcount, int maxdrawcount, int stride);

		internal delegate void glMultiDrawElementsIndirectCount_Delegate(uint mode, uint type, void* indirect, nint drawcount, int maxdrawcount, int stride);

		internal delegate void glPolygonOffsetClamp_Delegate(float factor, float units, float clamp);

		#endregion
		#region GL_VERSION_1_0
		internal static glCullFace_Delegate glCullFace;

		internal static glFrontFace_Delegate glFrontFace;

		internal static glHint_Delegate glHint;

		internal static glLineWidth_Delegate glLineWidth;

		internal static glPointSize_Delegate glPointSize;

		internal static glPolygonMode_Delegate glPolygonMode;

		internal static glScissor_Delegate glScissor;

		internal static glTexParameterf_Delegate glTexParameterf;

		internal static glTexParameterfv_Delegate glTexParameterfv;

		internal static glTexParameteri_Delegate glTexParameteri;

		internal static glTexParameteriv_Delegate glTexParameteriv;

		internal static glTexImage1D_Delegate glTexImage1D;

		internal static glTexImage2D_Delegate glTexImage2D;

		internal static glDrawBuffer_Delegate glDrawBuffer;

		internal static glClear_Delegate glClear;

		internal static glClearColor_Delegate glClearColor;

		internal static glClearStencil_Delegate glClearStencil;

		internal static glClearDepth_Delegate glClearDepth;

		internal static glStencilMask_Delegate glStencilMask;

		internal static glColorMask_Delegate glColorMask;

		internal static glDepthMask_Delegate glDepthMask;

		internal static glDisable_Delegate glDisable;

		internal static glEnable_Delegate glEnable;

		internal static glFinish_Delegate glFinish;

		internal static glFlush_Delegate glFlush;

		internal static glBlendFunc_Delegate glBlendFunc;

		internal static glLogicOp_Delegate glLogicOp;

		internal static glStencilFunc_Delegate glStencilFunc;

		internal static glStencilOp_Delegate glStencilOp;

		internal static glDepthFunc_Delegate glDepthFunc;

		internal static glPixelStoref_Delegate glPixelStoref;

		internal static glPixelStorei_Delegate glPixelStorei;

		internal static glReadBuffer_Delegate glReadBuffer;

		internal static glReadPixels_Delegate glReadPixels;

		internal static glGetBooleanv_Delegate glGetBooleanv;

		internal static glGetDoublev_Delegate glGetDoublev;

		internal static glGetError_Delegate glGetError;

		internal static glGetFloatv_Delegate glGetFloatv;

		internal static glGetIntegerv_Delegate glGetIntegerv;

		internal static glGetTexImage_Delegate glGetTexImage;

		internal static glGetTexParameterfv_Delegate glGetTexParameterfv;

		internal static glGetTexParameteriv_Delegate glGetTexParameteriv;

		internal static glGetTexLevelParameterfv_Delegate glGetTexLevelParameterfv;

		internal static glGetTexLevelParameteriv_Delegate glGetTexLevelParameteriv;

		internal static glIsEnabled_Delegate glIsEnabled;

		internal static glDepthRange_Delegate glDepthRange;

		internal static glViewport_Delegate glViewport;

		#endregion
		#region GL_VERSION_1_1
		internal static glDrawArrays_Delegate glDrawArrays;

		internal static glDrawElements_Delegate glDrawElements;

		internal static glGetPointerv_Delegate glGetPointerv;

		internal static glPolygonOffset_Delegate glPolygonOffset;

		internal static glCopyTexImage1D_Delegate glCopyTexImage1D;

		internal static glCopyTexImage2D_Delegate glCopyTexImage2D;

		internal static glCopyTexSubImage1D_Delegate glCopyTexSubImage1D;

		internal static glCopyTexSubImage2D_Delegate glCopyTexSubImage2D;

		internal static glTexSubImage1D_Delegate glTexSubImage1D;

		internal static glTexSubImage2D_Delegate glTexSubImage2D;

		internal static glBindTexture_Delegate glBindTexture;

		internal static glDeleteTextures_Delegate glDeleteTextures;

		internal static glGenTextures_Delegate glGenTextures;

		internal static glIsTexture_Delegate glIsTexture;

		#endregion
		#region GL_VERSION_1_2
		internal static glDrawRangeElements_Delegate glDrawRangeElements;

		internal static glTexImage3D_Delegate glTexImage3D;

		internal static glTexSubImage3D_Delegate glTexSubImage3D;

		internal static glCopyTexSubImage3D_Delegate glCopyTexSubImage3D;

		#endregion
		#region GL_VERSION_1_3
		internal static glActiveTexture_Delegate glActiveTexture;

		internal static glSampleCoverage_Delegate glSampleCoverage;

		internal static glCompressedTexImage3D_Delegate glCompressedTexImage3D;

		internal static glCompressedTexImage2D_Delegate glCompressedTexImage2D;

		internal static glCompressedTexImage1D_Delegate glCompressedTexImage1D;

		internal static glCompressedTexSubImage3D_Delegate glCompressedTexSubImage3D;

		internal static glCompressedTexSubImage2D_Delegate glCompressedTexSubImage2D;

		internal static glCompressedTexSubImage1D_Delegate glCompressedTexSubImage1D;

		internal static glGetCompressedTexImage_Delegate glGetCompressedTexImage;

		#endregion
		#region GL_VERSION_1_4
		internal static glBlendFuncSeparate_Delegate glBlendFuncSeparate;

		internal static glMultiDrawArrays_Delegate glMultiDrawArrays;

		internal static glMultiDrawElements_Delegate glMultiDrawElements;

		internal static glPointParameterf_Delegate glPointParameterf;

		internal static glPointParameterfv_Delegate glPointParameterfv;

		internal static glPointParameteri_Delegate glPointParameteri;

		internal static glPointParameteriv_Delegate glPointParameteriv;

		internal static glBlendColor_Delegate glBlendColor;

		internal static glBlendEquation_Delegate glBlendEquation;

		#endregion
		#region GL_VERSION_1_5
		internal static glGenQueries_Delegate glGenQueries;

		internal static glDeleteQueries_Delegate glDeleteQueries;

		internal static glIsQuery_Delegate glIsQuery;

		internal static glBeginQuery_Delegate glBeginQuery;

		internal static glEndQuery_Delegate glEndQuery;

		internal static glGetQueryiv_Delegate glGetQueryiv;

		internal static glGetQueryObjectiv_Delegate glGetQueryObjectiv;

		internal static glGetQueryObjectuiv_Delegate glGetQueryObjectuiv;

		internal static glBindBuffer_Delegate glBindBuffer;

		internal static glDeleteBuffers_Delegate glDeleteBuffers;

		internal static glGenBuffers_Delegate glGenBuffers;

		internal static glIsBuffer_Delegate glIsBuffer;

		internal static glBufferData_Delegate glBufferData;

		internal static glBufferSubData_Delegate glBufferSubData;

		internal static glGetBufferSubData_Delegate glGetBufferSubData;

		internal static glUnmapBuffer_Delegate glUnmapBuffer;

		internal static glGetBufferParameteriv_Delegate glGetBufferParameteriv;

		internal static glGetBufferPointerv_Delegate glGetBufferPointerv;

		#endregion
		#region GL_VERSION_2_0
		internal static glBlendEquationSeparate_Delegate glBlendEquationSeparate;

		internal static glDrawBuffers_Delegate glDrawBuffers;

		internal static glStencilOpSeparate_Delegate glStencilOpSeparate;

		internal static glStencilFuncSeparate_Delegate glStencilFuncSeparate;

		internal static glStencilMaskSeparate_Delegate glStencilMaskSeparate;

		internal static glAttachShader_Delegate glAttachShader;

		internal static glBindAttribLocation_Delegate glBindAttribLocation;

		internal static glCompileShader_Delegate glCompileShader;

		internal static glCreateProgram_Delegate glCreateProgram;

		internal static glCreateShader_Delegate glCreateShader;

		internal static glDeleteProgram_Delegate glDeleteProgram;

		internal static glDeleteShader_Delegate glDeleteShader;

		internal static glDetachShader_Delegate glDetachShader;

		internal static glDisableVertexAttribArray_Delegate glDisableVertexAttribArray;

		internal static glEnableVertexAttribArray_Delegate glEnableVertexAttribArray;

		internal static glGetActiveAttrib_Delegate glGetActiveAttrib;

		internal static glGetActiveUniform_Delegate glGetActiveUniform;

		internal static glGetAttachedShaders_Delegate glGetAttachedShaders;

		internal static glGetAttribLocation_Delegate glGetAttribLocation;

		internal static glGetProgramiv_Delegate glGetProgramiv;

		internal static glGetProgramInfoLog_Delegate glGetProgramInfoLog;

		internal static glGetShaderiv_Delegate glGetShaderiv;

		internal static glGetShaderInfoLog_Delegate glGetShaderInfoLog;

		internal static glGetShaderSource_Delegate glGetShaderSource;

		internal static glGetUniformLocation_Delegate glGetUniformLocation;

		internal static glGetUniformfv_Delegate glGetUniformfv;

		internal static glGetUniformiv_Delegate glGetUniformiv;

		internal static glGetVertexAttribdv_Delegate glGetVertexAttribdv;

		internal static glGetVertexAttribfv_Delegate glGetVertexAttribfv;

		internal static glGetVertexAttribiv_Delegate glGetVertexAttribiv;

		internal static glGetVertexAttribPointerv_Delegate glGetVertexAttribPointerv;

		internal static glIsProgram_Delegate glIsProgram;

		internal static glIsShader_Delegate glIsShader;

		internal static glLinkProgram_Delegate glLinkProgram;

		internal static glShaderSource_Delegate glShaderSource;

		internal static glUseProgram_Delegate glUseProgram;

		internal static glUniform1f_Delegate glUniform1f;

		internal static glUniform2f_Delegate glUniform2f;

		internal static glUniform3f_Delegate glUniform3f;

		internal static glUniform4f_Delegate glUniform4f;

		internal static glUniform1i_Delegate glUniform1i;

		internal static glUniform2i_Delegate glUniform2i;

		internal static glUniform3i_Delegate glUniform3i;

		internal static glUniform4i_Delegate glUniform4i;

		internal static glUniform1fv_Delegate glUniform1fv;

		internal static glUniform2fv_Delegate glUniform2fv;

		internal static glUniform3fv_Delegate glUniform3fv;

		internal static glUniform4fv_Delegate glUniform4fv;

		internal static glUniform1iv_Delegate glUniform1iv;

		internal static glUniform2iv_Delegate glUniform2iv;

		internal static glUniform3iv_Delegate glUniform3iv;

		internal static glUniform4iv_Delegate glUniform4iv;

		internal static glUniformMatrix2fv_Delegate glUniformMatrix2fv;

		internal static glUniformMatrix3fv_Delegate glUniformMatrix3fv;

		internal static glUniformMatrix4fv_Delegate glUniformMatrix4fv;

		internal static glValidateProgram_Delegate glValidateProgram;

		internal static glVertexAttrib1d_Delegate glVertexAttrib1d;

		internal static glVertexAttrib1dv_Delegate glVertexAttrib1dv;

		internal static glVertexAttrib1f_Delegate glVertexAttrib1f;

		internal static glVertexAttrib1fv_Delegate glVertexAttrib1fv;

		internal static glVertexAttrib1s_Delegate glVertexAttrib1s;

		internal static glVertexAttrib1sv_Delegate glVertexAttrib1sv;

		internal static glVertexAttrib2d_Delegate glVertexAttrib2d;

		internal static glVertexAttrib2dv_Delegate glVertexAttrib2dv;

		internal static glVertexAttrib2f_Delegate glVertexAttrib2f;

		internal static glVertexAttrib2fv_Delegate glVertexAttrib2fv;

		internal static glVertexAttrib2s_Delegate glVertexAttrib2s;

		internal static glVertexAttrib2sv_Delegate glVertexAttrib2sv;

		internal static glVertexAttrib3d_Delegate glVertexAttrib3d;

		internal static glVertexAttrib3dv_Delegate glVertexAttrib3dv;

		internal static glVertexAttrib3f_Delegate glVertexAttrib3f;

		internal static glVertexAttrib3fv_Delegate glVertexAttrib3fv;

		internal static glVertexAttrib3s_Delegate glVertexAttrib3s;

		internal static glVertexAttrib3sv_Delegate glVertexAttrib3sv;

		internal static glVertexAttrib4Nbv_Delegate glVertexAttrib4Nbv;

		internal static glVertexAttrib4Niv_Delegate glVertexAttrib4Niv;

		internal static glVertexAttrib4Nsv_Delegate glVertexAttrib4Nsv;

		internal static glVertexAttrib4Nub_Delegate glVertexAttrib4Nub;

		internal static glVertexAttrib4Nubv_Delegate glVertexAttrib4Nubv;

		internal static glVertexAttrib4Nuiv_Delegate glVertexAttrib4Nuiv;

		internal static glVertexAttrib4Nusv_Delegate glVertexAttrib4Nusv;

		internal static glVertexAttrib4bv_Delegate glVertexAttrib4bv;

		internal static glVertexAttrib4d_Delegate glVertexAttrib4d;

		internal static glVertexAttrib4dv_Delegate glVertexAttrib4dv;

		internal static glVertexAttrib4f_Delegate glVertexAttrib4f;

		internal static glVertexAttrib4fv_Delegate glVertexAttrib4fv;

		internal static glVertexAttrib4iv_Delegate glVertexAttrib4iv;

		internal static glVertexAttrib4s_Delegate glVertexAttrib4s;

		internal static glVertexAttrib4sv_Delegate glVertexAttrib4sv;

		internal static glVertexAttrib4ubv_Delegate glVertexAttrib4ubv;

		internal static glVertexAttrib4uiv_Delegate glVertexAttrib4uiv;

		internal static glVertexAttrib4usv_Delegate glVertexAttrib4usv;

		internal static glVertexAttribPointer_Delegate glVertexAttribPointer;

		#endregion
		#region GL_VERSION_2_1
		internal static glUniformMatrix2x3fv_Delegate glUniformMatrix2x3fv;

		internal static glUniformMatrix3x2fv_Delegate glUniformMatrix3x2fv;

		internal static glUniformMatrix2x4fv_Delegate glUniformMatrix2x4fv;

		internal static glUniformMatrix4x2fv_Delegate glUniformMatrix4x2fv;

		internal static glUniformMatrix3x4fv_Delegate glUniformMatrix3x4fv;

		internal static glUniformMatrix4x3fv_Delegate glUniformMatrix4x3fv;

		#endregion
		#region GL_VERSION_3_0
		internal static glColorMaski_Delegate glColorMaski;

		internal static glGetBooleani_v_Delegate glGetBooleani_v;

		internal static glGetIntegeri_v_Delegate glGetIntegeri_v;

		internal static glEnablei_Delegate glEnablei;

		internal static glDisablei_Delegate glDisablei;

		internal static glIsEnabledi_Delegate glIsEnabledi;

		internal static glBeginTransformFeedback_Delegate glBeginTransformFeedback;

		internal static glEndTransformFeedback_Delegate glEndTransformFeedback;

		internal static glBindBufferRange_Delegate glBindBufferRange;

		internal static glBindBufferBase_Delegate glBindBufferBase;

		internal static glTransformFeedbackVaryings_Delegate glTransformFeedbackVaryings;

		internal static glGetTransformFeedbackVarying_Delegate glGetTransformFeedbackVarying;

		internal static glClampColor_Delegate glClampColor;

		internal static glBeginConditionalRender_Delegate glBeginConditionalRender;

		internal static glEndConditionalRender_Delegate glEndConditionalRender;

		internal static glVertexAttribIPointer_Delegate glVertexAttribIPointer;

		internal static glGetVertexAttribIiv_Delegate glGetVertexAttribIiv;

		internal static glGetVertexAttribIuiv_Delegate glGetVertexAttribIuiv;

		internal static glVertexAttribI1i_Delegate glVertexAttribI1i;

		internal static glVertexAttribI2i_Delegate glVertexAttribI2i;

		internal static glVertexAttribI3i_Delegate glVertexAttribI3i;

		internal static glVertexAttribI4i_Delegate glVertexAttribI4i;

		internal static glVertexAttribI1ui_Delegate glVertexAttribI1ui;

		internal static glVertexAttribI2ui_Delegate glVertexAttribI2ui;

		internal static glVertexAttribI3ui_Delegate glVertexAttribI3ui;

		internal static glVertexAttribI4ui_Delegate glVertexAttribI4ui;

		internal static glVertexAttribI1iv_Delegate glVertexAttribI1iv;

		internal static glVertexAttribI2iv_Delegate glVertexAttribI2iv;

		internal static glVertexAttribI3iv_Delegate glVertexAttribI3iv;

		internal static glVertexAttribI4iv_Delegate glVertexAttribI4iv;

		internal static glVertexAttribI1uiv_Delegate glVertexAttribI1uiv;

		internal static glVertexAttribI2uiv_Delegate glVertexAttribI2uiv;

		internal static glVertexAttribI3uiv_Delegate glVertexAttribI3uiv;

		internal static glVertexAttribI4uiv_Delegate glVertexAttribI4uiv;

		internal static glVertexAttribI4bv_Delegate glVertexAttribI4bv;

		internal static glVertexAttribI4sv_Delegate glVertexAttribI4sv;

		internal static glVertexAttribI4ubv_Delegate glVertexAttribI4ubv;

		internal static glVertexAttribI4usv_Delegate glVertexAttribI4usv;

		internal static glGetUniformuiv_Delegate glGetUniformuiv;

		internal static glBindFragDataLocation_Delegate glBindFragDataLocation;

		internal static glGetFragDataLocation_Delegate glGetFragDataLocation;

		internal static glUniform1ui_Delegate glUniform1ui;

		internal static glUniform2ui_Delegate glUniform2ui;

		internal static glUniform3ui_Delegate glUniform3ui;

		internal static glUniform4ui_Delegate glUniform4ui;

		internal static glUniform1uiv_Delegate glUniform1uiv;

		internal static glUniform2uiv_Delegate glUniform2uiv;

		internal static glUniform3uiv_Delegate glUniform3uiv;

		internal static glUniform4uiv_Delegate glUniform4uiv;

		internal static glTexParameterIiv_Delegate glTexParameterIiv;

		internal static glTexParameterIuiv_Delegate glTexParameterIuiv;

		internal static glGetTexParameterIiv_Delegate glGetTexParameterIiv;

		internal static glGetTexParameterIuiv_Delegate glGetTexParameterIuiv;

		internal static glClearBufferiv_Delegate glClearBufferiv;

		internal static glClearBufferuiv_Delegate glClearBufferuiv;

		internal static glClearBufferfv_Delegate glClearBufferfv;

		internal static glClearBufferfi_Delegate glClearBufferfi;

		internal static glIsRenderbuffer_Delegate glIsRenderbuffer;

		internal static glBindRenderbuffer_Delegate glBindRenderbuffer;

		internal static glDeleteRenderbuffers_Delegate glDeleteRenderbuffers;

		internal static glGenRenderbuffers_Delegate glGenRenderbuffers;

		internal static glRenderbufferStorage_Delegate glRenderbufferStorage;

		internal static glGetRenderbufferParameteriv_Delegate glGetRenderbufferParameteriv;

		internal static glIsFramebuffer_Delegate glIsFramebuffer;

		internal static glBindFramebuffer_Delegate glBindFramebuffer;

		internal static glDeleteFramebuffers_Delegate glDeleteFramebuffers;

		internal static glGenFramebuffers_Delegate glGenFramebuffers;

		internal static glCheckFramebufferStatus_Delegate glCheckFramebufferStatus;

		internal static glFramebufferTexture1D_Delegate glFramebufferTexture1D;

		internal static glFramebufferTexture2D_Delegate glFramebufferTexture2D;

		internal static glFramebufferTexture3D_Delegate glFramebufferTexture3D;

		internal static glFramebufferRenderbuffer_Delegate glFramebufferRenderbuffer;

		internal static glGetFramebufferAttachmentParameteriv_Delegate glGetFramebufferAttachmentParameteriv;

		internal static glGenerateMipmap_Delegate glGenerateMipmap;

		internal static glBlitFramebuffer_Delegate glBlitFramebuffer;

		internal static glRenderbufferStorageMultisample_Delegate glRenderbufferStorageMultisample;

		internal static glFramebufferTextureLayer_Delegate glFramebufferTextureLayer;

		internal static glFlushMappedBufferRange_Delegate glFlushMappedBufferRange;

		internal static glBindVertexArray_Delegate glBindVertexArray;

		internal static glDeleteVertexArrays_Delegate glDeleteVertexArrays;

		internal static glGenVertexArrays_Delegate glGenVertexArrays;

		internal static glIsVertexArray_Delegate glIsVertexArray;

		#endregion
		#region GL_VERSION_3_1
		internal static glDrawArraysInstanced_Delegate glDrawArraysInstanced;

		internal static glDrawElementsInstanced_Delegate glDrawElementsInstanced;

		internal static glTexBuffer_Delegate glTexBuffer;

		internal static glPrimitiveRestartIndex_Delegate glPrimitiveRestartIndex;

		internal static glCopyBufferSubData_Delegate glCopyBufferSubData;

		internal static glGetUniformIndices_Delegate glGetUniformIndices;

		internal static glGetActiveUniformsiv_Delegate glGetActiveUniformsiv;

		internal static glGetActiveUniformName_Delegate glGetActiveUniformName;

		internal static glGetUniformBlockIndex_Delegate glGetUniformBlockIndex;

		internal static glGetActiveUniformBlockiv_Delegate glGetActiveUniformBlockiv;

		internal static glGetActiveUniformBlockName_Delegate glGetActiveUniformBlockName;

		internal static glUniformBlockBinding_Delegate glUniformBlockBinding;

		#endregion
		#region GL_VERSION_3_2
		internal static glDrawElementsBaseVertex_Delegate glDrawElementsBaseVertex;

		internal static glDrawRangeElementsBaseVertex_Delegate glDrawRangeElementsBaseVertex;

		internal static glDrawElementsInstancedBaseVertex_Delegate glDrawElementsInstancedBaseVertex;

		internal static glMultiDrawElementsBaseVertex_Delegate glMultiDrawElementsBaseVertex;

		internal static glProvokingVertex_Delegate glProvokingVertex;

		internal static glFenceSync_Delegate glFenceSync;

		internal static glIsSync_Delegate glIsSync;

		internal static glDeleteSync_Delegate glDeleteSync;

		internal static glClientWaitSync_Delegate glClientWaitSync;

		internal static glWaitSync_Delegate glWaitSync;

		internal static glGetInteger64v_Delegate glGetInteger64v;

		internal static glGetSynciv_Delegate glGetSynciv;

		internal static glGetInteger64i_v_Delegate glGetInteger64i_v;

		internal static glGetBufferParameteri64v_Delegate glGetBufferParameteri64v;

		internal static glFramebufferTexture_Delegate glFramebufferTexture;

		internal static glTexImage2DMultisample_Delegate glTexImage2DMultisample;

		internal static glTexImage3DMultisample_Delegate glTexImage3DMultisample;

		internal static glGetMultisamplefv_Delegate glGetMultisamplefv;

		internal static glSampleMaski_Delegate glSampleMaski;

		#endregion
		#region GL_VERSION_3_3
		internal static glBindFragDataLocationIndexed_Delegate glBindFragDataLocationIndexed;

		internal static glGetFragDataIndex_Delegate glGetFragDataIndex;

		internal static glGenSamplers_Delegate glGenSamplers;

		internal static glDeleteSamplers_Delegate glDeleteSamplers;

		internal static glIsSampler_Delegate glIsSampler;

		internal static glBindSampler_Delegate glBindSampler;

		internal static glSamplerParameteri_Delegate glSamplerParameteri;

		internal static glSamplerParameteriv_Delegate glSamplerParameteriv;

		internal static glSamplerParameterf_Delegate glSamplerParameterf;

		internal static glSamplerParameterfv_Delegate glSamplerParameterfv;

		internal static glSamplerParameterIiv_Delegate glSamplerParameterIiv;

		internal static glSamplerParameterIuiv_Delegate glSamplerParameterIuiv;

		internal static glGetSamplerParameteriv_Delegate glGetSamplerParameteriv;

		internal static glGetSamplerParameterIiv_Delegate glGetSamplerParameterIiv;

		internal static glGetSamplerParameterfv_Delegate glGetSamplerParameterfv;

		internal static glGetSamplerParameterIuiv_Delegate glGetSamplerParameterIuiv;

		internal static glQueryCounter_Delegate glQueryCounter;

		internal static glGetQueryObjecti64v_Delegate glGetQueryObjecti64v;

		internal static glGetQueryObjectui64v_Delegate glGetQueryObjectui64v;

		internal static glVertexAttribDivisor_Delegate glVertexAttribDivisor;

		internal static glVertexAttribP1ui_Delegate glVertexAttribP1ui;

		internal static glVertexAttribP1uiv_Delegate glVertexAttribP1uiv;

		internal static glVertexAttribP2ui_Delegate glVertexAttribP2ui;

		internal static glVertexAttribP2uiv_Delegate glVertexAttribP2uiv;

		internal static glVertexAttribP3ui_Delegate glVertexAttribP3ui;

		internal static glVertexAttribP3uiv_Delegate glVertexAttribP3uiv;

		internal static glVertexAttribP4ui_Delegate glVertexAttribP4ui;

		internal static glVertexAttribP4uiv_Delegate glVertexAttribP4uiv;

		#endregion
		#region GL_VERSION_4_0
		internal static glMinSampleShading_Delegate glMinSampleShading;

		internal static glBlendEquationi_Delegate glBlendEquationi;

		internal static glBlendEquationSeparatei_Delegate glBlendEquationSeparatei;

		internal static glBlendFunci_Delegate glBlendFunci;

		internal static glBlendFuncSeparatei_Delegate glBlendFuncSeparatei;

		internal static glDrawArraysIndirect_Delegate glDrawArraysIndirect;

		internal static glDrawElementsIndirect_Delegate glDrawElementsIndirect;

		internal static glUniform1d_Delegate glUniform1d;

		internal static glUniform2d_Delegate glUniform2d;

		internal static glUniform3d_Delegate glUniform3d;

		internal static glUniform4d_Delegate glUniform4d;

		internal static glUniform1dv_Delegate glUniform1dv;

		internal static glUniform2dv_Delegate glUniform2dv;

		internal static glUniform3dv_Delegate glUniform3dv;

		internal static glUniform4dv_Delegate glUniform4dv;

		internal static glUniformMatrix2dv_Delegate glUniformMatrix2dv;

		internal static glUniformMatrix3dv_Delegate glUniformMatrix3dv;

		internal static glUniformMatrix4dv_Delegate glUniformMatrix4dv;

		internal static glUniformMatrix2x3dv_Delegate glUniformMatrix2x3dv;

		internal static glUniformMatrix2x4dv_Delegate glUniformMatrix2x4dv;

		internal static glUniformMatrix3x2dv_Delegate glUniformMatrix3x2dv;

		internal static glUniformMatrix3x4dv_Delegate glUniformMatrix3x4dv;

		internal static glUniformMatrix4x2dv_Delegate glUniformMatrix4x2dv;

		internal static glUniformMatrix4x3dv_Delegate glUniformMatrix4x3dv;

		internal static glGetUniformdv_Delegate glGetUniformdv;

		internal static glGetSubroutineUniformLocation_Delegate glGetSubroutineUniformLocation;

		internal static glGetSubroutineIndex_Delegate glGetSubroutineIndex;

		internal static glGetActiveSubroutineUniformiv_Delegate glGetActiveSubroutineUniformiv;

		internal static glGetActiveSubroutineUniformName_Delegate glGetActiveSubroutineUniformName;

		internal static glGetActiveSubroutineName_Delegate glGetActiveSubroutineName;

		internal static glUniformSubroutinesuiv_Delegate glUniformSubroutinesuiv;

		internal static glGetUniformSubroutineuiv_Delegate glGetUniformSubroutineuiv;

		internal static glGetProgramStageiv_Delegate glGetProgramStageiv;

		internal static glPatchParameteri_Delegate glPatchParameteri;

		internal static glPatchParameterfv_Delegate glPatchParameterfv;

		internal static glBindTransformFeedback_Delegate glBindTransformFeedback;

		internal static glDeleteTransformFeedbacks_Delegate glDeleteTransformFeedbacks;

		internal static glGenTransformFeedbacks_Delegate glGenTransformFeedbacks;

		internal static glIsTransformFeedback_Delegate glIsTransformFeedback;

		internal static glPauseTransformFeedback_Delegate glPauseTransformFeedback;

		internal static glResumeTransformFeedback_Delegate glResumeTransformFeedback;

		internal static glDrawTransformFeedback_Delegate glDrawTransformFeedback;

		internal static glDrawTransformFeedbackStream_Delegate glDrawTransformFeedbackStream;

		internal static glBeginQueryIndexed_Delegate glBeginQueryIndexed;

		internal static glEndQueryIndexed_Delegate glEndQueryIndexed;

		internal static glGetQueryIndexediv_Delegate glGetQueryIndexediv;

		#endregion
		#region GL_VERSION_4_1
		internal static glReleaseShaderCompiler_Delegate glReleaseShaderCompiler;

		internal static glShaderBinary_Delegate glShaderBinary;

		internal static glGetShaderPrecisionFormat_Delegate glGetShaderPrecisionFormat;

		internal static glDepthRangef_Delegate glDepthRangef;

		internal static glClearDepthf_Delegate glClearDepthf;

		internal static glGetProgramBinary_Delegate glGetProgramBinary;

		internal static glProgramBinary_Delegate glProgramBinary;

		internal static glProgramParameteri_Delegate glProgramParameteri;

		internal static glUseProgramStages_Delegate glUseProgramStages;

		internal static glActiveShaderProgram_Delegate glActiveShaderProgram;

		internal static glCreateShaderProgramv_Delegate glCreateShaderProgramv;

		internal static glBindProgramPipeline_Delegate glBindProgramPipeline;

		internal static glDeleteProgramPipelines_Delegate glDeleteProgramPipelines;

		internal static glGenProgramPipelines_Delegate glGenProgramPipelines;

		internal static glIsProgramPipeline_Delegate glIsProgramPipeline;

		internal static glGetProgramPipelineiv_Delegate glGetProgramPipelineiv;

		internal static glProgramUniform1i_Delegate glProgramUniform1i;

		internal static glProgramUniform1iv_Delegate glProgramUniform1iv;

		internal static glProgramUniform1f_Delegate glProgramUniform1f;

		internal static glProgramUniform1fv_Delegate glProgramUniform1fv;

		internal static glProgramUniform1d_Delegate glProgramUniform1d;

		internal static glProgramUniform1dv_Delegate glProgramUniform1dv;

		internal static glProgramUniform1ui_Delegate glProgramUniform1ui;

		internal static glProgramUniform1uiv_Delegate glProgramUniform1uiv;

		internal static glProgramUniform2i_Delegate glProgramUniform2i;

		internal static glProgramUniform2iv_Delegate glProgramUniform2iv;

		internal static glProgramUniform2f_Delegate glProgramUniform2f;

		internal static glProgramUniform2fv_Delegate glProgramUniform2fv;

		internal static glProgramUniform2d_Delegate glProgramUniform2d;

		internal static glProgramUniform2dv_Delegate glProgramUniform2dv;

		internal static glProgramUniform2ui_Delegate glProgramUniform2ui;

		internal static glProgramUniform2uiv_Delegate glProgramUniform2uiv;

		internal static glProgramUniform3i_Delegate glProgramUniform3i;

		internal static glProgramUniform3iv_Delegate glProgramUniform3iv;

		internal static glProgramUniform3f_Delegate glProgramUniform3f;

		internal static glProgramUniform3fv_Delegate glProgramUniform3fv;

		internal static glProgramUniform3d_Delegate glProgramUniform3d;

		internal static glProgramUniform3dv_Delegate glProgramUniform3dv;

		internal static glProgramUniform3ui_Delegate glProgramUniform3ui;

		internal static glProgramUniform3uiv_Delegate glProgramUniform3uiv;

		internal static glProgramUniform4i_Delegate glProgramUniform4i;

		internal static glProgramUniform4iv_Delegate glProgramUniform4iv;

		internal static glProgramUniform4f_Delegate glProgramUniform4f;

		internal static glProgramUniform4fv_Delegate glProgramUniform4fv;

		internal static glProgramUniform4d_Delegate glProgramUniform4d;

		internal static glProgramUniform4dv_Delegate glProgramUniform4dv;

		internal static glProgramUniform4ui_Delegate glProgramUniform4ui;

		internal static glProgramUniform4uiv_Delegate glProgramUniform4uiv;

		internal static glProgramUniformMatrix2fv_Delegate glProgramUniformMatrix2fv;

		internal static glProgramUniformMatrix3fv_Delegate glProgramUniformMatrix3fv;

		internal static glProgramUniformMatrix4fv_Delegate glProgramUniformMatrix4fv;

		internal static glProgramUniformMatrix2dv_Delegate glProgramUniformMatrix2dv;

		internal static glProgramUniformMatrix3dv_Delegate glProgramUniformMatrix3dv;

		internal static glProgramUniformMatrix4dv_Delegate glProgramUniformMatrix4dv;

		internal static glProgramUniformMatrix2x3fv_Delegate glProgramUniformMatrix2x3fv;

		internal static glProgramUniformMatrix3x2fv_Delegate glProgramUniformMatrix3x2fv;

		internal static glProgramUniformMatrix2x4fv_Delegate glProgramUniformMatrix2x4fv;

		internal static glProgramUniformMatrix4x2fv_Delegate glProgramUniformMatrix4x2fv;

		internal static glProgramUniformMatrix3x4fv_Delegate glProgramUniformMatrix3x4fv;

		internal static glProgramUniformMatrix4x3fv_Delegate glProgramUniformMatrix4x3fv;

		internal static glProgramUniformMatrix2x3dv_Delegate glProgramUniformMatrix2x3dv;

		internal static glProgramUniformMatrix3x2dv_Delegate glProgramUniformMatrix3x2dv;

		internal static glProgramUniformMatrix2x4dv_Delegate glProgramUniformMatrix2x4dv;

		internal static glProgramUniformMatrix4x2dv_Delegate glProgramUniformMatrix4x2dv;

		internal static glProgramUniformMatrix3x4dv_Delegate glProgramUniformMatrix3x4dv;

		internal static glProgramUniformMatrix4x3dv_Delegate glProgramUniformMatrix4x3dv;

		internal static glValidateProgramPipeline_Delegate glValidateProgramPipeline;

		internal static glGetProgramPipelineInfoLog_Delegate glGetProgramPipelineInfoLog;

		internal static glVertexAttribL1d_Delegate glVertexAttribL1d;

		internal static glVertexAttribL2d_Delegate glVertexAttribL2d;

		internal static glVertexAttribL3d_Delegate glVertexAttribL3d;

		internal static glVertexAttribL4d_Delegate glVertexAttribL4d;

		internal static glVertexAttribL1dv_Delegate glVertexAttribL1dv;

		internal static glVertexAttribL2dv_Delegate glVertexAttribL2dv;

		internal static glVertexAttribL3dv_Delegate glVertexAttribL3dv;

		internal static glVertexAttribL4dv_Delegate glVertexAttribL4dv;

		internal static glVertexAttribLPointer_Delegate glVertexAttribLPointer;

		internal static glGetVertexAttribLdv_Delegate glGetVertexAttribLdv;

		internal static glViewportArrayv_Delegate glViewportArrayv;

		internal static glViewportIndexedf_Delegate glViewportIndexedf;

		internal static glViewportIndexedfv_Delegate glViewportIndexedfv;

		internal static glScissorArrayv_Delegate glScissorArrayv;

		internal static glScissorIndexed_Delegate glScissorIndexed;

		internal static glScissorIndexedv_Delegate glScissorIndexedv;

		internal static glDepthRangeArrayv_Delegate glDepthRangeArrayv;

		internal static glDepthRangeIndexed_Delegate glDepthRangeIndexed;

		internal static glGetFloati_v_Delegate glGetFloati_v;

		internal static glGetDoublei_v_Delegate glGetDoublei_v;

		#endregion
		#region GL_VERSION_4_2
		internal static glDrawArraysInstancedBaseInstance_Delegate glDrawArraysInstancedBaseInstance;

		internal static glDrawElementsInstancedBaseInstance_Delegate glDrawElementsInstancedBaseInstance;

		internal static glDrawElementsInstancedBaseVertexBaseInstance_Delegate glDrawElementsInstancedBaseVertexBaseInstance;

		internal static glGetInternalformativ_Delegate glGetInternalformativ;

		internal static glGetActiveAtomicCounterBufferiv_Delegate glGetActiveAtomicCounterBufferiv;

		internal static glBindImageTexture_Delegate glBindImageTexture;

		internal static glMemoryBarrier_Delegate glMemoryBarrier;

		internal static glTexStorage1D_Delegate glTexStorage1D;

		internal static glTexStorage2D_Delegate glTexStorage2D;

		internal static glTexStorage3D_Delegate glTexStorage3D;

		internal static glDrawTransformFeedbackInstanced_Delegate glDrawTransformFeedbackInstanced;

		internal static glDrawTransformFeedbackStreamInstanced_Delegate glDrawTransformFeedbackStreamInstanced;

		#endregion
		#region GL_VERSION_4_3
		internal static glClearBufferData_Delegate glClearBufferData;

		internal static glClearBufferSubData_Delegate glClearBufferSubData;

		internal static glDispatchCompute_Delegate glDispatchCompute;

		internal static glDispatchComputeIndirect_Delegate glDispatchComputeIndirect;

		internal static glCopyImageSubData_Delegate glCopyImageSubData;

		internal static glFramebufferParameteri_Delegate glFramebufferParameteri;

		internal static glGetFramebufferParameteriv_Delegate glGetFramebufferParameteriv;

		internal static glGetInternalformati64v_Delegate glGetInternalformati64v;

		internal static glInvalidateTexSubImage_Delegate glInvalidateTexSubImage;

		internal static glInvalidateTexImage_Delegate glInvalidateTexImage;

		internal static glInvalidateBufferSubData_Delegate glInvalidateBufferSubData;

		internal static glInvalidateBufferData_Delegate glInvalidateBufferData;

		internal static glInvalidateFramebuffer_Delegate glInvalidateFramebuffer;

		internal static glInvalidateSubFramebuffer_Delegate glInvalidateSubFramebuffer;

		internal static glMultiDrawArraysIndirect_Delegate glMultiDrawArraysIndirect;

		internal static glMultiDrawElementsIndirect_Delegate glMultiDrawElementsIndirect;

		internal static glGetProgramInterfaceiv_Delegate glGetProgramInterfaceiv;

		internal static glGetProgramResourceIndex_Delegate glGetProgramResourceIndex;

		internal static glGetProgramResourceName_Delegate glGetProgramResourceName;

		internal static glGetProgramResourceiv_Delegate glGetProgramResourceiv;

		internal static glGetProgramResourceLocation_Delegate glGetProgramResourceLocation;

		internal static glGetProgramResourceLocationIndex_Delegate glGetProgramResourceLocationIndex;

		internal static glShaderStorageBlockBinding_Delegate glShaderStorageBlockBinding;

		internal static glTexBufferRange_Delegate glTexBufferRange;

		internal static glTexStorage2DMultisample_Delegate glTexStorage2DMultisample;

		internal static glTexStorage3DMultisample_Delegate glTexStorage3DMultisample;

		internal static glTextureView_Delegate glTextureView;

		internal static glBindVertexBuffer_Delegate glBindVertexBuffer;

		internal static glVertexAttribFormat_Delegate glVertexAttribFormat;

		internal static glVertexAttribIFormat_Delegate glVertexAttribIFormat;

		internal static glVertexAttribLFormat_Delegate glVertexAttribLFormat;

		internal static glVertexAttribBinding_Delegate glVertexAttribBinding;

		internal static glVertexBindingDivisor_Delegate glVertexBindingDivisor;

		internal static glDebugMessageControl_Delegate glDebugMessageControl;

		internal static glDebugMessageInsert_Delegate glDebugMessageInsert;

		internal static glDebugMessageCallback_Delegate glDebugMessageCallback;

		internal static glGetDebugMessageLog_Delegate glGetDebugMessageLog;

		internal static glPushDebugGroup_Delegate glPushDebugGroup;

		internal static glPopDebugGroup_Delegate glPopDebugGroup;

		internal static glObjectLabel_Delegate glObjectLabel;

		internal static glGetObjectLabel_Delegate glGetObjectLabel;

		internal static glObjectPtrLabel_Delegate glObjectPtrLabel;

		internal static glGetObjectPtrLabel_Delegate glGetObjectPtrLabel;

		#endregion
		#region GL_VERSION_4_4
		internal static glBufferStorage_Delegate glBufferStorage;

		internal static glClearTexImage_Delegate glClearTexImage;

		internal static glClearTexSubImage_Delegate glClearTexSubImage;

		internal static glBindBuffersBase_Delegate glBindBuffersBase;

		internal static glBindBuffersRange_Delegate glBindBuffersRange;

		internal static glBindTextures_Delegate glBindTextures;

		internal static glBindSamplers_Delegate glBindSamplers;

		internal static glBindImageTextures_Delegate glBindImageTextures;

		internal static glBindVertexBuffers_Delegate glBindVertexBuffers;

		#endregion
		#region GL_VERSION_4_5
		internal static glClipControl_Delegate glClipControl;

		internal static glCreateTransformFeedbacks_Delegate glCreateTransformFeedbacks;

		internal static glTransformFeedbackBufferBase_Delegate glTransformFeedbackBufferBase;

		internal static glTransformFeedbackBufferRange_Delegate glTransformFeedbackBufferRange;

		internal static glGetTransformFeedbackiv_Delegate glGetTransformFeedbackiv;

		internal static glGetTransformFeedbacki_v_Delegate glGetTransformFeedbacki_v;

		internal static glGetTransformFeedbacki64_v_Delegate glGetTransformFeedbacki64_v;

		internal static glCreateBuffers_Delegate glCreateBuffers;

		internal static glNamedBufferStorage_Delegate glNamedBufferStorage;

		internal static glNamedBufferData_Delegate glNamedBufferData;

		internal static glNamedBufferSubData_Delegate glNamedBufferSubData;

		internal static glCopyNamedBufferSubData_Delegate glCopyNamedBufferSubData;

		internal static glClearNamedBufferData_Delegate glClearNamedBufferData;

		internal static glClearNamedBufferSubData_Delegate glClearNamedBufferSubData;

		internal static glUnmapNamedBuffer_Delegate glUnmapNamedBuffer;

		internal static glFlushMappedNamedBufferRange_Delegate glFlushMappedNamedBufferRange;

		internal static glGetNamedBufferParameteriv_Delegate glGetNamedBufferParameteriv;

		internal static glGetNamedBufferParameteri64v_Delegate glGetNamedBufferParameteri64v;

		internal static glGetNamedBufferPointerv_Delegate glGetNamedBufferPointerv;

		internal static glGetNamedBufferSubData_Delegate glGetNamedBufferSubData;

		internal static glCreateFramebuffers_Delegate glCreateFramebuffers;

		internal static glNamedFramebufferRenderbuffer_Delegate glNamedFramebufferRenderbuffer;

		internal static glNamedFramebufferParameteri_Delegate glNamedFramebufferParameteri;

		internal static glNamedFramebufferTexture_Delegate glNamedFramebufferTexture;

		internal static glNamedFramebufferTextureLayer_Delegate glNamedFramebufferTextureLayer;

		internal static glNamedFramebufferDrawBuffer_Delegate glNamedFramebufferDrawBuffer;

		internal static glNamedFramebufferDrawBuffers_Delegate glNamedFramebufferDrawBuffers;

		internal static glNamedFramebufferReadBuffer_Delegate glNamedFramebufferReadBuffer;

		internal static glInvalidateNamedFramebufferData_Delegate glInvalidateNamedFramebufferData;

		internal static glInvalidateNamedFramebufferSubData_Delegate glInvalidateNamedFramebufferSubData;

		internal static glClearNamedFramebufferiv_Delegate glClearNamedFramebufferiv;

		internal static glClearNamedFramebufferuiv_Delegate glClearNamedFramebufferuiv;

		internal static glClearNamedFramebufferfv_Delegate glClearNamedFramebufferfv;

		internal static glClearNamedFramebufferfi_Delegate glClearNamedFramebufferfi;

		internal static glBlitNamedFramebuffer_Delegate glBlitNamedFramebuffer;

		internal static glCheckNamedFramebufferStatus_Delegate glCheckNamedFramebufferStatus;

		internal static glGetNamedFramebufferParameteriv_Delegate glGetNamedFramebufferParameteriv;

		internal static glGetNamedFramebufferAttachmentParameteriv_Delegate glGetNamedFramebufferAttachmentParameteriv;

		internal static glCreateRenderbuffers_Delegate glCreateRenderbuffers;

		internal static glNamedRenderbufferStorage_Delegate glNamedRenderbufferStorage;

		internal static glNamedRenderbufferStorageMultisample_Delegate glNamedRenderbufferStorageMultisample;

		internal static glGetNamedRenderbufferParameteriv_Delegate glGetNamedRenderbufferParameteriv;

		internal static glCreateTextures_Delegate glCreateTextures;

		internal static glTextureBuffer_Delegate glTextureBuffer;

		internal static glTextureBufferRange_Delegate glTextureBufferRange;

		internal static glTextureStorage1D_Delegate glTextureStorage1D;

		internal static glTextureStorage2D_Delegate glTextureStorage2D;

		internal static glTextureStorage3D_Delegate glTextureStorage3D;

		internal static glTextureStorage2DMultisample_Delegate glTextureStorage2DMultisample;

		internal static glTextureStorage3DMultisample_Delegate glTextureStorage3DMultisample;

		internal static glTextureSubImage1D_Delegate glTextureSubImage1D;

		internal static glTextureSubImage2D_Delegate glTextureSubImage2D;

		internal static glTextureSubImage3D_Delegate glTextureSubImage3D;

		internal static glCompressedTextureSubImage1D_Delegate glCompressedTextureSubImage1D;

		internal static glCompressedTextureSubImage2D_Delegate glCompressedTextureSubImage2D;

		internal static glCompressedTextureSubImage3D_Delegate glCompressedTextureSubImage3D;

		internal static glCopyTextureSubImage1D_Delegate glCopyTextureSubImage1D;

		internal static glCopyTextureSubImage2D_Delegate glCopyTextureSubImage2D;

		internal static glCopyTextureSubImage3D_Delegate glCopyTextureSubImage3D;

		internal static glTextureParameterf_Delegate glTextureParameterf;

		internal static glTextureParameterfv_Delegate glTextureParameterfv;

		internal static glTextureParameteri_Delegate glTextureParameteri;

		internal static glTextureParameterIiv_Delegate glTextureParameterIiv;

		internal static glTextureParameterIuiv_Delegate glTextureParameterIuiv;

		internal static glTextureParameteriv_Delegate glTextureParameteriv;

		internal static glGenerateTextureMipmap_Delegate glGenerateTextureMipmap;

		internal static glBindTextureUnit_Delegate glBindTextureUnit;

		internal static glGetTextureImage_Delegate glGetTextureImage;

		internal static glGetCompressedTextureImage_Delegate glGetCompressedTextureImage;

		internal static glGetTextureLevelParameterfv_Delegate glGetTextureLevelParameterfv;

		internal static glGetTextureLevelParameteriv_Delegate glGetTextureLevelParameteriv;

		internal static glGetTextureParameterfv_Delegate glGetTextureParameterfv;

		internal static glGetTextureParameterIiv_Delegate glGetTextureParameterIiv;

		internal static glGetTextureParameterIuiv_Delegate glGetTextureParameterIuiv;

		internal static glGetTextureParameteriv_Delegate glGetTextureParameteriv;

		internal static glCreateVertexArrays_Delegate glCreateVertexArrays;

		internal static glDisableVertexArrayAttrib_Delegate glDisableVertexArrayAttrib;

		internal static glEnableVertexArrayAttrib_Delegate glEnableVertexArrayAttrib;

		internal static glVertexArrayElementBuffer_Delegate glVertexArrayElementBuffer;

		internal static glVertexArrayVertexBuffer_Delegate glVertexArrayVertexBuffer;

		internal static glVertexArrayVertexBuffers_Delegate glVertexArrayVertexBuffers;

		internal static glVertexArrayAttribBinding_Delegate glVertexArrayAttribBinding;

		internal static glVertexArrayAttribFormat_Delegate glVertexArrayAttribFormat;

		internal static glVertexArrayAttribIFormat_Delegate glVertexArrayAttribIFormat;

		internal static glVertexArrayAttribLFormat_Delegate glVertexArrayAttribLFormat;

		internal static glVertexArrayBindingDivisor_Delegate glVertexArrayBindingDivisor;

		internal static glGetVertexArrayiv_Delegate glGetVertexArrayiv;

		internal static glGetVertexArrayIndexediv_Delegate glGetVertexArrayIndexediv;

		internal static glGetVertexArrayIndexed64iv_Delegate glGetVertexArrayIndexed64iv;

		internal static glCreateSamplers_Delegate glCreateSamplers;

		internal static glCreateProgramPipelines_Delegate glCreateProgramPipelines;

		internal static glCreateQueries_Delegate glCreateQueries;

		internal static glGetQueryBufferObjecti64v_Delegate glGetQueryBufferObjecti64v;

		internal static glGetQueryBufferObjectiv_Delegate glGetQueryBufferObjectiv;

		internal static glGetQueryBufferObjectui64v_Delegate glGetQueryBufferObjectui64v;

		internal static glGetQueryBufferObjectuiv_Delegate glGetQueryBufferObjectuiv;

		internal static glMemoryBarrierByRegion_Delegate glMemoryBarrierByRegion;

		internal static glGetTextureSubImage_Delegate glGetTextureSubImage;

		internal static glGetCompressedTextureSubImage_Delegate glGetCompressedTextureSubImage;

		internal static glGetGraphicsResetStatus_Delegate glGetGraphicsResetStatus;

		internal static glGetnCompressedTexImage_Delegate glGetnCompressedTexImage;

		internal static glGetnTexImage_Delegate glGetnTexImage;

		internal static glGetnUniformdv_Delegate glGetnUniformdv;

		internal static glGetnUniformfv_Delegate glGetnUniformfv;

		internal static glGetnUniformiv_Delegate glGetnUniformiv;

		internal static glGetnUniformuiv_Delegate glGetnUniformuiv;

		internal static glReadnPixels_Delegate glReadnPixels;

		internal static glTextureBarrier_Delegate glTextureBarrier;

		#endregion
		#region GL_VERSION_4_6
		internal static glSpecializeShader_Delegate glSpecializeShader;

		internal static glMultiDrawArraysIndirectCount_Delegate glMultiDrawArraysIndirectCount;

		internal static glMultiDrawElementsIndirectCount_Delegate glMultiDrawElementsIndirectCount;

		internal static glPolygonOffsetClamp_Delegate glPolygonOffsetClamp;

		#endregion
		public static void Init(int major_version, int minor_version) {
			Console.WriteLine("Binding OpenGL functions...");
			#region GL_VERSION_1_0
			if (major_version >= 1 && minor_version >= 0) {
				glCullFace = Marshal.GetDelegateForFunctionPointer<glCullFace_Delegate>(Loader.GetProcAddress("glCullFace", 1, 0));

				glFrontFace = Marshal.GetDelegateForFunctionPointer<glFrontFace_Delegate>(Loader.GetProcAddress("glFrontFace", 1, 0));

				glHint = Marshal.GetDelegateForFunctionPointer<glHint_Delegate>(Loader.GetProcAddress("glHint", 1, 0));

				glLineWidth = Marshal.GetDelegateForFunctionPointer<glLineWidth_Delegate>(Loader.GetProcAddress("glLineWidth", 1, 0));

				glPointSize = Marshal.GetDelegateForFunctionPointer<glPointSize_Delegate>(Loader.GetProcAddress("glPointSize", 1, 0));

				glPolygonMode = Marshal.GetDelegateForFunctionPointer<glPolygonMode_Delegate>(Loader.GetProcAddress("glPolygonMode", 1, 0));

				glScissor = Marshal.GetDelegateForFunctionPointer<glScissor_Delegate>(Loader.GetProcAddress("glScissor", 1, 0));

				glTexParameterf = Marshal.GetDelegateForFunctionPointer<glTexParameterf_Delegate>(Loader.GetProcAddress("glTexParameterf", 1, 0));

				glTexParameterfv = Marshal.GetDelegateForFunctionPointer<glTexParameterfv_Delegate>(Loader.GetProcAddress("glTexParameterfv", 1, 0));

				glTexParameteri = Marshal.GetDelegateForFunctionPointer<glTexParameteri_Delegate>(Loader.GetProcAddress("glTexParameteri", 1, 0));

				glTexParameteriv = Marshal.GetDelegateForFunctionPointer<glTexParameteriv_Delegate>(Loader.GetProcAddress("glTexParameteriv", 1, 0));

				glTexImage1D = Marshal.GetDelegateForFunctionPointer<glTexImage1D_Delegate>(Loader.GetProcAddress("glTexImage1D", 1, 0));

				glTexImage2D = Marshal.GetDelegateForFunctionPointer<glTexImage2D_Delegate>(Loader.GetProcAddress("glTexImage2D", 1, 0));

				glDrawBuffer = Marshal.GetDelegateForFunctionPointer<glDrawBuffer_Delegate>(Loader.GetProcAddress("glDrawBuffer", 1, 0));

				glClear = Marshal.GetDelegateForFunctionPointer<glClear_Delegate>(Loader.GetProcAddress("glClear", 1, 0));

				glClearColor = Marshal.GetDelegateForFunctionPointer<glClearColor_Delegate>(Loader.GetProcAddress("glClearColor", 1, 0));

				glClearStencil = Marshal.GetDelegateForFunctionPointer<glClearStencil_Delegate>(Loader.GetProcAddress("glClearStencil", 1, 0));

				glClearDepth = Marshal.GetDelegateForFunctionPointer<glClearDepth_Delegate>(Loader.GetProcAddress("glClearDepth", 1, 0));

				glStencilMask = Marshal.GetDelegateForFunctionPointer<glStencilMask_Delegate>(Loader.GetProcAddress("glStencilMask", 1, 0));

				glColorMask = Marshal.GetDelegateForFunctionPointer<glColorMask_Delegate>(Loader.GetProcAddress("glColorMask", 1, 0));

				glDepthMask = Marshal.GetDelegateForFunctionPointer<glDepthMask_Delegate>(Loader.GetProcAddress("glDepthMask", 1, 0));

				glDisable = Marshal.GetDelegateForFunctionPointer<glDisable_Delegate>(Loader.GetProcAddress("glDisable", 1, 0));

				glEnable = Marshal.GetDelegateForFunctionPointer<glEnable_Delegate>(Loader.GetProcAddress("glEnable", 1, 0));

				glFinish = Marshal.GetDelegateForFunctionPointer<glFinish_Delegate>(Loader.GetProcAddress("glFinish", 1, 0));

				glFlush = Marshal.GetDelegateForFunctionPointer<glFlush_Delegate>(Loader.GetProcAddress("glFlush", 1, 0));

				glBlendFunc = Marshal.GetDelegateForFunctionPointer<glBlendFunc_Delegate>(Loader.GetProcAddress("glBlendFunc", 1, 0));

				glLogicOp = Marshal.GetDelegateForFunctionPointer<glLogicOp_Delegate>(Loader.GetProcAddress("glLogicOp", 1, 0));

				glStencilFunc = Marshal.GetDelegateForFunctionPointer<glStencilFunc_Delegate>(Loader.GetProcAddress("glStencilFunc", 1, 0));

				glStencilOp = Marshal.GetDelegateForFunctionPointer<glStencilOp_Delegate>(Loader.GetProcAddress("glStencilOp", 1, 0));

				glDepthFunc = Marshal.GetDelegateForFunctionPointer<glDepthFunc_Delegate>(Loader.GetProcAddress("glDepthFunc", 1, 0));

				glPixelStoref = Marshal.GetDelegateForFunctionPointer<glPixelStoref_Delegate>(Loader.GetProcAddress("glPixelStoref", 1, 0));

				glPixelStorei = Marshal.GetDelegateForFunctionPointer<glPixelStorei_Delegate>(Loader.GetProcAddress("glPixelStorei", 1, 0));

				glReadBuffer = Marshal.GetDelegateForFunctionPointer<glReadBuffer_Delegate>(Loader.GetProcAddress("glReadBuffer", 1, 0));

				glReadPixels = Marshal.GetDelegateForFunctionPointer<glReadPixels_Delegate>(Loader.GetProcAddress("glReadPixels", 1, 0));

				glGetBooleanv = Marshal.GetDelegateForFunctionPointer<glGetBooleanv_Delegate>(Loader.GetProcAddress("glGetBooleanv", 1, 0));

				glGetDoublev = Marshal.GetDelegateForFunctionPointer<glGetDoublev_Delegate>(Loader.GetProcAddress("glGetDoublev", 1, 0));

				glGetError = Marshal.GetDelegateForFunctionPointer<glGetError_Delegate>(Loader.GetProcAddress("glGetError", 1, 0));

				glGetFloatv = Marshal.GetDelegateForFunctionPointer<glGetFloatv_Delegate>(Loader.GetProcAddress("glGetFloatv", 1, 0));

				glGetIntegerv = Marshal.GetDelegateForFunctionPointer<glGetIntegerv_Delegate>(Loader.GetProcAddress("glGetIntegerv", 1, 0));

				glGetTexImage = Marshal.GetDelegateForFunctionPointer<glGetTexImage_Delegate>(Loader.GetProcAddress("glGetTexImage", 1, 0));

				glGetTexParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTexParameterfv_Delegate>(Loader.GetProcAddress("glGetTexParameterfv", 1, 0));

				glGetTexParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTexParameteriv_Delegate>(Loader.GetProcAddress("glGetTexParameteriv", 1, 0));

				glGetTexLevelParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTexLevelParameterfv_Delegate>(Loader.GetProcAddress("glGetTexLevelParameterfv", 1, 0));

				glGetTexLevelParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTexLevelParameteriv_Delegate>(Loader.GetProcAddress("glGetTexLevelParameteriv", 1, 0));

				glIsEnabled = Marshal.GetDelegateForFunctionPointer<glIsEnabled_Delegate>(Loader.GetProcAddress("glIsEnabled", 1, 0));

				glDepthRange = Marshal.GetDelegateForFunctionPointer<glDepthRange_Delegate>(Loader.GetProcAddress("glDepthRange", 1, 0));

				glViewport = Marshal.GetDelegateForFunctionPointer<glViewport_Delegate>(Loader.GetProcAddress("glViewport", 1, 0));

			}
			#endregion
			#region GL_VERSION_1_1
			if (major_version >= 1 && minor_version >= 1) {
				glDrawArrays = Marshal.GetDelegateForFunctionPointer<glDrawArrays_Delegate>(Loader.GetProcAddress("glDrawArrays", 1, 1));

				glDrawElements = Marshal.GetDelegateForFunctionPointer<glDrawElements_Delegate>(Loader.GetProcAddress("glDrawElements", 1, 1));

				glGetPointerv = Marshal.GetDelegateForFunctionPointer<glGetPointerv_Delegate>(Loader.GetProcAddress("glGetPointerv", 1, 1));

				glPolygonOffset = Marshal.GetDelegateForFunctionPointer<glPolygonOffset_Delegate>(Loader.GetProcAddress("glPolygonOffset", 1, 1));

				glCopyTexImage1D = Marshal.GetDelegateForFunctionPointer<glCopyTexImage1D_Delegate>(Loader.GetProcAddress("glCopyTexImage1D", 1, 1));

				glCopyTexImage2D = Marshal.GetDelegateForFunctionPointer<glCopyTexImage2D_Delegate>(Loader.GetProcAddress("glCopyTexImage2D", 1, 1));

				glCopyTexSubImage1D = Marshal.GetDelegateForFunctionPointer<glCopyTexSubImage1D_Delegate>(Loader.GetProcAddress("glCopyTexSubImage1D", 1, 1));

				glCopyTexSubImage2D = Marshal.GetDelegateForFunctionPointer<glCopyTexSubImage2D_Delegate>(Loader.GetProcAddress("glCopyTexSubImage2D", 1, 1));

				glTexSubImage1D = Marshal.GetDelegateForFunctionPointer<glTexSubImage1D_Delegate>(Loader.GetProcAddress("glTexSubImage1D", 1, 1));

				glTexSubImage2D = Marshal.GetDelegateForFunctionPointer<glTexSubImage2D_Delegate>(Loader.GetProcAddress("glTexSubImage2D", 1, 1));

				glBindTexture = Marshal.GetDelegateForFunctionPointer<glBindTexture_Delegate>(Loader.GetProcAddress("glBindTexture", 1, 1));

				glDeleteTextures = Marshal.GetDelegateForFunctionPointer<glDeleteTextures_Delegate>(Loader.GetProcAddress("glDeleteTextures", 1, 1));

				glGenTextures = Marshal.GetDelegateForFunctionPointer<glGenTextures_Delegate>(Loader.GetProcAddress("glGenTextures", 1, 1));

				glIsTexture = Marshal.GetDelegateForFunctionPointer<glIsTexture_Delegate>(Loader.GetProcAddress("glIsTexture", 1, 1));

			}
			#endregion
			#region GL_VERSION_1_2
			if (major_version >= 1 && minor_version >= 2) {
				glDrawRangeElements = Marshal.GetDelegateForFunctionPointer<glDrawRangeElements_Delegate>(Loader.GetProcAddress("glDrawRangeElements", 1, 2));

				glTexImage3D = Marshal.GetDelegateForFunctionPointer<glTexImage3D_Delegate>(Loader.GetProcAddress("glTexImage3D", 1, 2));

				glTexSubImage3D = Marshal.GetDelegateForFunctionPointer<glTexSubImage3D_Delegate>(Loader.GetProcAddress("glTexSubImage3D", 1, 2));

				glCopyTexSubImage3D = Marshal.GetDelegateForFunctionPointer<glCopyTexSubImage3D_Delegate>(Loader.GetProcAddress("glCopyTexSubImage3D", 1, 2));

			}
			#endregion
			#region GL_VERSION_1_3
			if (major_version >= 1 && minor_version >= 3) {
				glActiveTexture = Marshal.GetDelegateForFunctionPointer<glActiveTexture_Delegate>(Loader.GetProcAddress("glActiveTexture", 1, 3));

				glSampleCoverage = Marshal.GetDelegateForFunctionPointer<glSampleCoverage_Delegate>(Loader.GetProcAddress("glSampleCoverage", 1, 3));

				glCompressedTexImage3D = Marshal.GetDelegateForFunctionPointer<glCompressedTexImage3D_Delegate>(Loader.GetProcAddress("glCompressedTexImage3D", 1, 3));

				glCompressedTexImage2D = Marshal.GetDelegateForFunctionPointer<glCompressedTexImage2D_Delegate>(Loader.GetProcAddress("glCompressedTexImage2D", 1, 3));

				glCompressedTexImage1D = Marshal.GetDelegateForFunctionPointer<glCompressedTexImage1D_Delegate>(Loader.GetProcAddress("glCompressedTexImage1D", 1, 3));

				glCompressedTexSubImage3D = Marshal.GetDelegateForFunctionPointer<glCompressedTexSubImage3D_Delegate>(Loader.GetProcAddress("glCompressedTexSubImage3D", 1, 3));

				glCompressedTexSubImage2D = Marshal.GetDelegateForFunctionPointer<glCompressedTexSubImage2D_Delegate>(Loader.GetProcAddress("glCompressedTexSubImage2D", 1, 3));

				glCompressedTexSubImage1D = Marshal.GetDelegateForFunctionPointer<glCompressedTexSubImage1D_Delegate>(Loader.GetProcAddress("glCompressedTexSubImage1D", 1, 3));

				glGetCompressedTexImage = Marshal.GetDelegateForFunctionPointer<glGetCompressedTexImage_Delegate>(Loader.GetProcAddress("glGetCompressedTexImage", 1, 3));

			}
			#endregion
			#region GL_VERSION_1_4
			if (major_version >= 1 && minor_version >= 4) {
				glBlendFuncSeparate = Marshal.GetDelegateForFunctionPointer<glBlendFuncSeparate_Delegate>(Loader.GetProcAddress("glBlendFuncSeparate", 1, 4));

				glMultiDrawArrays = Marshal.GetDelegateForFunctionPointer<glMultiDrawArrays_Delegate>(Loader.GetProcAddress("glMultiDrawArrays", 1, 4));

				glMultiDrawElements = Marshal.GetDelegateForFunctionPointer<glMultiDrawElements_Delegate>(Loader.GetProcAddress("glMultiDrawElements", 1, 4));

				glPointParameterf = Marshal.GetDelegateForFunctionPointer<glPointParameterf_Delegate>(Loader.GetProcAddress("glPointParameterf", 1, 4));

				glPointParameterfv = Marshal.GetDelegateForFunctionPointer<glPointParameterfv_Delegate>(Loader.GetProcAddress("glPointParameterfv", 1, 4));

				glPointParameteri = Marshal.GetDelegateForFunctionPointer<glPointParameteri_Delegate>(Loader.GetProcAddress("glPointParameteri", 1, 4));

				glPointParameteriv = Marshal.GetDelegateForFunctionPointer<glPointParameteriv_Delegate>(Loader.GetProcAddress("glPointParameteriv", 1, 4));

				glBlendColor = Marshal.GetDelegateForFunctionPointer<glBlendColor_Delegate>(Loader.GetProcAddress("glBlendColor", 1, 4));

				glBlendEquation = Marshal.GetDelegateForFunctionPointer<glBlendEquation_Delegate>(Loader.GetProcAddress("glBlendEquation", 1, 4));

			}
			#endregion
			#region GL_VERSION_1_5
			if (major_version >= 1 && minor_version >= 5) {
				glGenQueries = Marshal.GetDelegateForFunctionPointer<glGenQueries_Delegate>(Loader.GetProcAddress("glGenQueries", 1, 5));

				glDeleteQueries = Marshal.GetDelegateForFunctionPointer<glDeleteQueries_Delegate>(Loader.GetProcAddress("glDeleteQueries", 1, 5));

				glIsQuery = Marshal.GetDelegateForFunctionPointer<glIsQuery_Delegate>(Loader.GetProcAddress("glIsQuery", 1, 5));

				glBeginQuery = Marshal.GetDelegateForFunctionPointer<glBeginQuery_Delegate>(Loader.GetProcAddress("glBeginQuery", 1, 5));

				glEndQuery = Marshal.GetDelegateForFunctionPointer<glEndQuery_Delegate>(Loader.GetProcAddress("glEndQuery", 1, 5));

				glGetQueryiv = Marshal.GetDelegateForFunctionPointer<glGetQueryiv_Delegate>(Loader.GetProcAddress("glGetQueryiv", 1, 5));

				glGetQueryObjectiv = Marshal.GetDelegateForFunctionPointer<glGetQueryObjectiv_Delegate>(Loader.GetProcAddress("glGetQueryObjectiv", 1, 5));

				glGetQueryObjectuiv = Marshal.GetDelegateForFunctionPointer<glGetQueryObjectuiv_Delegate>(Loader.GetProcAddress("glGetQueryObjectuiv", 1, 5));

				glBindBuffer = Marshal.GetDelegateForFunctionPointer<glBindBuffer_Delegate>(Loader.GetProcAddress("glBindBuffer", 1, 5));

				glDeleteBuffers = Marshal.GetDelegateForFunctionPointer<glDeleteBuffers_Delegate>(Loader.GetProcAddress("glDeleteBuffers", 1, 5));

				glGenBuffers = Marshal.GetDelegateForFunctionPointer<glGenBuffers_Delegate>(Loader.GetProcAddress("glGenBuffers", 1, 5));

				glIsBuffer = Marshal.GetDelegateForFunctionPointer<glIsBuffer_Delegate>(Loader.GetProcAddress("glIsBuffer", 1, 5));

				glBufferData = Marshal.GetDelegateForFunctionPointer<glBufferData_Delegate>(Loader.GetProcAddress("glBufferData", 1, 5));

				glBufferSubData = Marshal.GetDelegateForFunctionPointer<glBufferSubData_Delegate>(Loader.GetProcAddress("glBufferSubData", 1, 5));

				glGetBufferSubData = Marshal.GetDelegateForFunctionPointer<glGetBufferSubData_Delegate>(Loader.GetProcAddress("glGetBufferSubData", 1, 5));

				glUnmapBuffer = Marshal.GetDelegateForFunctionPointer<glUnmapBuffer_Delegate>(Loader.GetProcAddress("glUnmapBuffer", 1, 5));

				glGetBufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetBufferParameteriv_Delegate>(Loader.GetProcAddress("glGetBufferParameteriv", 1, 5));

				glGetBufferPointerv = Marshal.GetDelegateForFunctionPointer<glGetBufferPointerv_Delegate>(Loader.GetProcAddress("glGetBufferPointerv", 1, 5));

			}
			#endregion
			#region GL_VERSION_2_0
			if (major_version >= 2 && minor_version >= 0) {
				glBlendEquationSeparate = Marshal.GetDelegateForFunctionPointer<glBlendEquationSeparate_Delegate>(Loader.GetProcAddress("glBlendEquationSeparate", 2, 0));

				glDrawBuffers = Marshal.GetDelegateForFunctionPointer<glDrawBuffers_Delegate>(Loader.GetProcAddress("glDrawBuffers", 2, 0));

				glStencilOpSeparate = Marshal.GetDelegateForFunctionPointer<glStencilOpSeparate_Delegate>(Loader.GetProcAddress("glStencilOpSeparate", 2, 0));

				glStencilFuncSeparate = Marshal.GetDelegateForFunctionPointer<glStencilFuncSeparate_Delegate>(Loader.GetProcAddress("glStencilFuncSeparate", 2, 0));

				glStencilMaskSeparate = Marshal.GetDelegateForFunctionPointer<glStencilMaskSeparate_Delegate>(Loader.GetProcAddress("glStencilMaskSeparate", 2, 0));

				glAttachShader = Marshal.GetDelegateForFunctionPointer<glAttachShader_Delegate>(Loader.GetProcAddress("glAttachShader", 2, 0));

				glBindAttribLocation = Marshal.GetDelegateForFunctionPointer<glBindAttribLocation_Delegate>(Loader.GetProcAddress("glBindAttribLocation", 2, 0));

				glCompileShader = Marshal.GetDelegateForFunctionPointer<glCompileShader_Delegate>(Loader.GetProcAddress("glCompileShader", 2, 0));

				glCreateProgram = Marshal.GetDelegateForFunctionPointer<glCreateProgram_Delegate>(Loader.GetProcAddress("glCreateProgram", 2, 0));

				glCreateShader = Marshal.GetDelegateForFunctionPointer<glCreateShader_Delegate>(Loader.GetProcAddress("glCreateShader", 2, 0));

				glDeleteProgram = Marshal.GetDelegateForFunctionPointer<glDeleteProgram_Delegate>(Loader.GetProcAddress("glDeleteProgram", 2, 0));

				glDeleteShader = Marshal.GetDelegateForFunctionPointer<glDeleteShader_Delegate>(Loader.GetProcAddress("glDeleteShader", 2, 0));

				glDetachShader = Marshal.GetDelegateForFunctionPointer<glDetachShader_Delegate>(Loader.GetProcAddress("glDetachShader", 2, 0));

				glDisableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<glDisableVertexAttribArray_Delegate>(Loader.GetProcAddress("glDisableVertexAttribArray", 2, 0));

				glEnableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<glEnableVertexAttribArray_Delegate>(Loader.GetProcAddress("glEnableVertexAttribArray", 2, 0));

				glGetActiveAttrib = Marshal.GetDelegateForFunctionPointer<glGetActiveAttrib_Delegate>(Loader.GetProcAddress("glGetActiveAttrib", 2, 0));

				glGetActiveUniform = Marshal.GetDelegateForFunctionPointer<glGetActiveUniform_Delegate>(Loader.GetProcAddress("glGetActiveUniform", 2, 0));

				glGetAttachedShaders = Marshal.GetDelegateForFunctionPointer<glGetAttachedShaders_Delegate>(Loader.GetProcAddress("glGetAttachedShaders", 2, 0));

				glGetAttribLocation = Marshal.GetDelegateForFunctionPointer<glGetAttribLocation_Delegate>(Loader.GetProcAddress("glGetAttribLocation", 2, 0));

				glGetProgramiv = Marshal.GetDelegateForFunctionPointer<glGetProgramiv_Delegate>(Loader.GetProcAddress("glGetProgramiv", 2, 0));

				glGetProgramInfoLog = Marshal.GetDelegateForFunctionPointer<glGetProgramInfoLog_Delegate>(Loader.GetProcAddress("glGetProgramInfoLog", 2, 0));

				glGetShaderiv = Marshal.GetDelegateForFunctionPointer<glGetShaderiv_Delegate>(Loader.GetProcAddress("glGetShaderiv", 2, 0));

				glGetShaderInfoLog = Marshal.GetDelegateForFunctionPointer<glGetShaderInfoLog_Delegate>(Loader.GetProcAddress("glGetShaderInfoLog", 2, 0));

				glGetShaderSource = Marshal.GetDelegateForFunctionPointer<glGetShaderSource_Delegate>(Loader.GetProcAddress("glGetShaderSource", 2, 0));

				glGetUniformLocation = Marshal.GetDelegateForFunctionPointer<glGetUniformLocation_Delegate>(Loader.GetProcAddress("glGetUniformLocation", 2, 0));

				glGetUniformfv = Marshal.GetDelegateForFunctionPointer<glGetUniformfv_Delegate>(Loader.GetProcAddress("glGetUniformfv", 2, 0));

				glGetUniformiv = Marshal.GetDelegateForFunctionPointer<glGetUniformiv_Delegate>(Loader.GetProcAddress("glGetUniformiv", 2, 0));

				glGetVertexAttribdv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribdv_Delegate>(Loader.GetProcAddress("glGetVertexAttribdv", 2, 0));

				glGetVertexAttribfv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribfv_Delegate>(Loader.GetProcAddress("glGetVertexAttribfv", 2, 0));

				glGetVertexAttribiv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribiv_Delegate>(Loader.GetProcAddress("glGetVertexAttribiv", 2, 0));

				glGetVertexAttribPointerv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribPointerv_Delegate>(Loader.GetProcAddress("glGetVertexAttribPointerv", 2, 0));

				glIsProgram = Marshal.GetDelegateForFunctionPointer<glIsProgram_Delegate>(Loader.GetProcAddress("glIsProgram", 2, 0));

				glIsShader = Marshal.GetDelegateForFunctionPointer<glIsShader_Delegate>(Loader.GetProcAddress("glIsShader", 2, 0));

				glLinkProgram = Marshal.GetDelegateForFunctionPointer<glLinkProgram_Delegate>(Loader.GetProcAddress("glLinkProgram", 2, 0));

				glShaderSource = Marshal.GetDelegateForFunctionPointer<glShaderSource_Delegate>(Loader.GetProcAddress("glShaderSource", 2, 0));

				glUseProgram = Marshal.GetDelegateForFunctionPointer<glUseProgram_Delegate>(Loader.GetProcAddress("glUseProgram", 2, 0));

				glUniform1f = Marshal.GetDelegateForFunctionPointer<glUniform1f_Delegate>(Loader.GetProcAddress("glUniform1f", 2, 0));

				glUniform2f = Marshal.GetDelegateForFunctionPointer<glUniform2f_Delegate>(Loader.GetProcAddress("glUniform2f", 2, 0));

				glUniform3f = Marshal.GetDelegateForFunctionPointer<glUniform3f_Delegate>(Loader.GetProcAddress("glUniform3f", 2, 0));

				glUniform4f = Marshal.GetDelegateForFunctionPointer<glUniform4f_Delegate>(Loader.GetProcAddress("glUniform4f", 2, 0));

				glUniform1i = Marshal.GetDelegateForFunctionPointer<glUniform1i_Delegate>(Loader.GetProcAddress("glUniform1i", 2, 0));

				glUniform2i = Marshal.GetDelegateForFunctionPointer<glUniform2i_Delegate>(Loader.GetProcAddress("glUniform2i", 2, 0));

				glUniform3i = Marshal.GetDelegateForFunctionPointer<glUniform3i_Delegate>(Loader.GetProcAddress("glUniform3i", 2, 0));

				glUniform4i = Marshal.GetDelegateForFunctionPointer<glUniform4i_Delegate>(Loader.GetProcAddress("glUniform4i", 2, 0));

				glUniform1fv = Marshal.GetDelegateForFunctionPointer<glUniform1fv_Delegate>(Loader.GetProcAddress("glUniform1fv", 2, 0));

				glUniform2fv = Marshal.GetDelegateForFunctionPointer<glUniform2fv_Delegate>(Loader.GetProcAddress("glUniform2fv", 2, 0));

				glUniform3fv = Marshal.GetDelegateForFunctionPointer<glUniform3fv_Delegate>(Loader.GetProcAddress("glUniform3fv", 2, 0));

				glUniform4fv = Marshal.GetDelegateForFunctionPointer<glUniform4fv_Delegate>(Loader.GetProcAddress("glUniform4fv", 2, 0));

				glUniform1iv = Marshal.GetDelegateForFunctionPointer<glUniform1iv_Delegate>(Loader.GetProcAddress("glUniform1iv", 2, 0));

				glUniform2iv = Marshal.GetDelegateForFunctionPointer<glUniform2iv_Delegate>(Loader.GetProcAddress("glUniform2iv", 2, 0));

				glUniform3iv = Marshal.GetDelegateForFunctionPointer<glUniform3iv_Delegate>(Loader.GetProcAddress("glUniform3iv", 2, 0));

				glUniform4iv = Marshal.GetDelegateForFunctionPointer<glUniform4iv_Delegate>(Loader.GetProcAddress("glUniform4iv", 2, 0));

				glUniformMatrix2fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2fv_Delegate>(Loader.GetProcAddress("glUniformMatrix2fv", 2, 0));

				glUniformMatrix3fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3fv_Delegate>(Loader.GetProcAddress("glUniformMatrix3fv", 2, 0));

				glUniformMatrix4fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4fv_Delegate>(Loader.GetProcAddress("glUniformMatrix4fv", 2, 0));

				glValidateProgram = Marshal.GetDelegateForFunctionPointer<glValidateProgram_Delegate>(Loader.GetProcAddress("glValidateProgram", 2, 0));

				glVertexAttrib1d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1d_Delegate>(Loader.GetProcAddress("glVertexAttrib1d", 2, 0));

				glVertexAttrib1dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1dv_Delegate>(Loader.GetProcAddress("glVertexAttrib1dv", 2, 0));

				glVertexAttrib1f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1f_Delegate>(Loader.GetProcAddress("glVertexAttrib1f", 2, 0));

				glVertexAttrib1fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1fv_Delegate>(Loader.GetProcAddress("glVertexAttrib1fv", 2, 0));

				glVertexAttrib1s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1s_Delegate>(Loader.GetProcAddress("glVertexAttrib1s", 2, 0));

				glVertexAttrib1sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1sv_Delegate>(Loader.GetProcAddress("glVertexAttrib1sv", 2, 0));

				glVertexAttrib2d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2d_Delegate>(Loader.GetProcAddress("glVertexAttrib2d", 2, 0));

				glVertexAttrib2dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2dv_Delegate>(Loader.GetProcAddress("glVertexAttrib2dv", 2, 0));

				glVertexAttrib2f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2f_Delegate>(Loader.GetProcAddress("glVertexAttrib2f", 2, 0));

				glVertexAttrib2fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2fv_Delegate>(Loader.GetProcAddress("glVertexAttrib2fv", 2, 0));

				glVertexAttrib2s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2s_Delegate>(Loader.GetProcAddress("glVertexAttrib2s", 2, 0));

				glVertexAttrib2sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2sv_Delegate>(Loader.GetProcAddress("glVertexAttrib2sv", 2, 0));

				glVertexAttrib3d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3d_Delegate>(Loader.GetProcAddress("glVertexAttrib3d", 2, 0));

				glVertexAttrib3dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3dv_Delegate>(Loader.GetProcAddress("glVertexAttrib3dv", 2, 0));

				glVertexAttrib3f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3f_Delegate>(Loader.GetProcAddress("glVertexAttrib3f", 2, 0));

				glVertexAttrib3fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3fv_Delegate>(Loader.GetProcAddress("glVertexAttrib3fv", 2, 0));

				glVertexAttrib3s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3s_Delegate>(Loader.GetProcAddress("glVertexAttrib3s", 2, 0));

				glVertexAttrib3sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3sv_Delegate>(Loader.GetProcAddress("glVertexAttrib3sv", 2, 0));

				glVertexAttrib4Nbv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4Nbv_Delegate>(Loader.GetProcAddress("glVertexAttrib4Nbv", 2, 0));

				glVertexAttrib4Niv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4Niv_Delegate>(Loader.GetProcAddress("glVertexAttrib4Niv", 2, 0));

				glVertexAttrib4Nsv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4Nsv_Delegate>(Loader.GetProcAddress("glVertexAttrib4Nsv", 2, 0));

				glVertexAttrib4Nub = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4Nub_Delegate>(Loader.GetProcAddress("glVertexAttrib4Nub", 2, 0));

				glVertexAttrib4Nubv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4Nubv_Delegate>(Loader.GetProcAddress("glVertexAttrib4Nubv", 2, 0));

				glVertexAttrib4Nuiv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4Nuiv_Delegate>(Loader.GetProcAddress("glVertexAttrib4Nuiv", 2, 0));

				glVertexAttrib4Nusv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4Nusv_Delegate>(Loader.GetProcAddress("glVertexAttrib4Nusv", 2, 0));

				glVertexAttrib4bv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4bv_Delegate>(Loader.GetProcAddress("glVertexAttrib4bv", 2, 0));

				glVertexAttrib4d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4d_Delegate>(Loader.GetProcAddress("glVertexAttrib4d", 2, 0));

				glVertexAttrib4dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4dv_Delegate>(Loader.GetProcAddress("glVertexAttrib4dv", 2, 0));

				glVertexAttrib4f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4f_Delegate>(Loader.GetProcAddress("glVertexAttrib4f", 2, 0));

				glVertexAttrib4fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4fv_Delegate>(Loader.GetProcAddress("glVertexAttrib4fv", 2, 0));

				glVertexAttrib4iv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4iv_Delegate>(Loader.GetProcAddress("glVertexAttrib4iv", 2, 0));

				glVertexAttrib4s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4s_Delegate>(Loader.GetProcAddress("glVertexAttrib4s", 2, 0));

				glVertexAttrib4sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4sv_Delegate>(Loader.GetProcAddress("glVertexAttrib4sv", 2, 0));

				glVertexAttrib4ubv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4ubv_Delegate>(Loader.GetProcAddress("glVertexAttrib4ubv", 2, 0));

				glVertexAttrib4uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4uiv_Delegate>(Loader.GetProcAddress("glVertexAttrib4uiv", 2, 0));

				glVertexAttrib4usv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4usv_Delegate>(Loader.GetProcAddress("glVertexAttrib4usv", 2, 0));

				glVertexAttribPointer = Marshal.GetDelegateForFunctionPointer<glVertexAttribPointer_Delegate>(Loader.GetProcAddress("glVertexAttribPointer", 2, 0));

			}
			#endregion
			#region GL_VERSION_2_1
			if (major_version >= 2 && minor_version >= 1) {
				glUniformMatrix2x3fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2x3fv_Delegate>(Loader.GetProcAddress("glUniformMatrix2x3fv", 2, 1));

				glUniformMatrix3x2fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3x2fv_Delegate>(Loader.GetProcAddress("glUniformMatrix3x2fv", 2, 1));

				glUniformMatrix2x4fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2x4fv_Delegate>(Loader.GetProcAddress("glUniformMatrix2x4fv", 2, 1));

				glUniformMatrix4x2fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4x2fv_Delegate>(Loader.GetProcAddress("glUniformMatrix4x2fv", 2, 1));

				glUniformMatrix3x4fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3x4fv_Delegate>(Loader.GetProcAddress("glUniformMatrix3x4fv", 2, 1));

				glUniformMatrix4x3fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4x3fv_Delegate>(Loader.GetProcAddress("glUniformMatrix4x3fv", 2, 1));

			}
			#endregion
			#region GL_VERSION_3_0
			if (major_version >= 3 && minor_version >= 0) {
				glColorMaski = Marshal.GetDelegateForFunctionPointer<glColorMaski_Delegate>(Loader.GetProcAddress("glColorMaski", 3, 0));

				glGetBooleani_v = Marshal.GetDelegateForFunctionPointer<glGetBooleani_v_Delegate>(Loader.GetProcAddress("glGetBooleani_v", 3, 0));

				glGetIntegeri_v = Marshal.GetDelegateForFunctionPointer<glGetIntegeri_v_Delegate>(Loader.GetProcAddress("glGetIntegeri_v", 3, 0));

				glEnablei = Marshal.GetDelegateForFunctionPointer<glEnablei_Delegate>(Loader.GetProcAddress("glEnablei", 3, 0));

				glDisablei = Marshal.GetDelegateForFunctionPointer<glDisablei_Delegate>(Loader.GetProcAddress("glDisablei", 3, 0));

				glIsEnabledi = Marshal.GetDelegateForFunctionPointer<glIsEnabledi_Delegate>(Loader.GetProcAddress("glIsEnabledi", 3, 0));

				glBeginTransformFeedback = Marshal.GetDelegateForFunctionPointer<glBeginTransformFeedback_Delegate>(Loader.GetProcAddress("glBeginTransformFeedback", 3, 0));

				glEndTransformFeedback = Marshal.GetDelegateForFunctionPointer<glEndTransformFeedback_Delegate>(Loader.GetProcAddress("glEndTransformFeedback", 3, 0));

				glBindBufferRange = Marshal.GetDelegateForFunctionPointer<glBindBufferRange_Delegate>(Loader.GetProcAddress("glBindBufferRange", 3, 0));

				glBindBufferBase = Marshal.GetDelegateForFunctionPointer<glBindBufferBase_Delegate>(Loader.GetProcAddress("glBindBufferBase", 3, 0));

				glTransformFeedbackVaryings = Marshal.GetDelegateForFunctionPointer<glTransformFeedbackVaryings_Delegate>(Loader.GetProcAddress("glTransformFeedbackVaryings", 3, 0));

				glGetTransformFeedbackVarying = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbackVarying_Delegate>(Loader.GetProcAddress("glGetTransformFeedbackVarying", 3, 0));

				glClampColor = Marshal.GetDelegateForFunctionPointer<glClampColor_Delegate>(Loader.GetProcAddress("glClampColor", 3, 0));

				glBeginConditionalRender = Marshal.GetDelegateForFunctionPointer<glBeginConditionalRender_Delegate>(Loader.GetProcAddress("glBeginConditionalRender", 3, 0));

				glEndConditionalRender = Marshal.GetDelegateForFunctionPointer<glEndConditionalRender_Delegate>(Loader.GetProcAddress("glEndConditionalRender", 3, 0));

				glVertexAttribIPointer = Marshal.GetDelegateForFunctionPointer<glVertexAttribIPointer_Delegate>(Loader.GetProcAddress("glVertexAttribIPointer", 3, 0));

				glGetVertexAttribIiv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribIiv_Delegate>(Loader.GetProcAddress("glGetVertexAttribIiv", 3, 0));

				glGetVertexAttribIuiv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribIuiv_Delegate>(Loader.GetProcAddress("glGetVertexAttribIuiv", 3, 0));

				glVertexAttribI1i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1i_Delegate>(Loader.GetProcAddress("glVertexAttribI1i", 3, 0));

				glVertexAttribI2i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2i_Delegate>(Loader.GetProcAddress("glVertexAttribI2i", 3, 0));

				glVertexAttribI3i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3i_Delegate>(Loader.GetProcAddress("glVertexAttribI3i", 3, 0));

				glVertexAttribI4i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4i_Delegate>(Loader.GetProcAddress("glVertexAttribI4i", 3, 0));

				glVertexAttribI1ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1ui_Delegate>(Loader.GetProcAddress("glVertexAttribI1ui", 3, 0));

				glVertexAttribI2ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2ui_Delegate>(Loader.GetProcAddress("glVertexAttribI2ui", 3, 0));

				glVertexAttribI3ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3ui_Delegate>(Loader.GetProcAddress("glVertexAttribI3ui", 3, 0));

				glVertexAttribI4ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4ui_Delegate>(Loader.GetProcAddress("glVertexAttribI4ui", 3, 0));

				glVertexAttribI1iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1iv_Delegate>(Loader.GetProcAddress("glVertexAttribI1iv", 3, 0));

				glVertexAttribI2iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2iv_Delegate>(Loader.GetProcAddress("glVertexAttribI2iv", 3, 0));

				glVertexAttribI3iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3iv_Delegate>(Loader.GetProcAddress("glVertexAttribI3iv", 3, 0));

				glVertexAttribI4iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4iv_Delegate>(Loader.GetProcAddress("glVertexAttribI4iv", 3, 0));

				glVertexAttribI1uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1uiv_Delegate>(Loader.GetProcAddress("glVertexAttribI1uiv", 3, 0));

				glVertexAttribI2uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2uiv_Delegate>(Loader.GetProcAddress("glVertexAttribI2uiv", 3, 0));

				glVertexAttribI3uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3uiv_Delegate>(Loader.GetProcAddress("glVertexAttribI3uiv", 3, 0));

				glVertexAttribI4uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4uiv_Delegate>(Loader.GetProcAddress("glVertexAttribI4uiv", 3, 0));

				glVertexAttribI4bv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4bv_Delegate>(Loader.GetProcAddress("glVertexAttribI4bv", 3, 0));

				glVertexAttribI4sv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4sv_Delegate>(Loader.GetProcAddress("glVertexAttribI4sv", 3, 0));

				glVertexAttribI4ubv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4ubv_Delegate>(Loader.GetProcAddress("glVertexAttribI4ubv", 3, 0));

				glVertexAttribI4usv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4usv_Delegate>(Loader.GetProcAddress("glVertexAttribI4usv", 3, 0));

				glGetUniformuiv = Marshal.GetDelegateForFunctionPointer<glGetUniformuiv_Delegate>(Loader.GetProcAddress("glGetUniformuiv", 3, 0));

				glBindFragDataLocation = Marshal.GetDelegateForFunctionPointer<glBindFragDataLocation_Delegate>(Loader.GetProcAddress("glBindFragDataLocation", 3, 0));

				glGetFragDataLocation = Marshal.GetDelegateForFunctionPointer<glGetFragDataLocation_Delegate>(Loader.GetProcAddress("glGetFragDataLocation", 3, 0));

				glUniform1ui = Marshal.GetDelegateForFunctionPointer<glUniform1ui_Delegate>(Loader.GetProcAddress("glUniform1ui", 3, 0));

				glUniform2ui = Marshal.GetDelegateForFunctionPointer<glUniform2ui_Delegate>(Loader.GetProcAddress("glUniform2ui", 3, 0));

				glUniform3ui = Marshal.GetDelegateForFunctionPointer<glUniform3ui_Delegate>(Loader.GetProcAddress("glUniform3ui", 3, 0));

				glUniform4ui = Marshal.GetDelegateForFunctionPointer<glUniform4ui_Delegate>(Loader.GetProcAddress("glUniform4ui", 3, 0));

				glUniform1uiv = Marshal.GetDelegateForFunctionPointer<glUniform1uiv_Delegate>(Loader.GetProcAddress("glUniform1uiv", 3, 0));

				glUniform2uiv = Marshal.GetDelegateForFunctionPointer<glUniform2uiv_Delegate>(Loader.GetProcAddress("glUniform2uiv", 3, 0));

				glUniform3uiv = Marshal.GetDelegateForFunctionPointer<glUniform3uiv_Delegate>(Loader.GetProcAddress("glUniform3uiv", 3, 0));

				glUniform4uiv = Marshal.GetDelegateForFunctionPointer<glUniform4uiv_Delegate>(Loader.GetProcAddress("glUniform4uiv", 3, 0));

				glTexParameterIiv = Marshal.GetDelegateForFunctionPointer<glTexParameterIiv_Delegate>(Loader.GetProcAddress("glTexParameterIiv", 3, 0));

				glTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<glTexParameterIuiv_Delegate>(Loader.GetProcAddress("glTexParameterIuiv", 3, 0));

				glGetTexParameterIiv = Marshal.GetDelegateForFunctionPointer<glGetTexParameterIiv_Delegate>(Loader.GetProcAddress("glGetTexParameterIiv", 3, 0));

				glGetTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<glGetTexParameterIuiv_Delegate>(Loader.GetProcAddress("glGetTexParameterIuiv", 3, 0));

				glClearBufferiv = Marshal.GetDelegateForFunctionPointer<glClearBufferiv_Delegate>(Loader.GetProcAddress("glClearBufferiv", 3, 0));

				glClearBufferuiv = Marshal.GetDelegateForFunctionPointer<glClearBufferuiv_Delegate>(Loader.GetProcAddress("glClearBufferuiv", 3, 0));

				glClearBufferfv = Marshal.GetDelegateForFunctionPointer<glClearBufferfv_Delegate>(Loader.GetProcAddress("glClearBufferfv", 3, 0));

				glClearBufferfi = Marshal.GetDelegateForFunctionPointer<glClearBufferfi_Delegate>(Loader.GetProcAddress("glClearBufferfi", 3, 0));

				glIsRenderbuffer = Marshal.GetDelegateForFunctionPointer<glIsRenderbuffer_Delegate>(Loader.GetProcAddress("glIsRenderbuffer", 3, 0));

				glBindRenderbuffer = Marshal.GetDelegateForFunctionPointer<glBindRenderbuffer_Delegate>(Loader.GetProcAddress("glBindRenderbuffer", 3, 0));

				glDeleteRenderbuffers = Marshal.GetDelegateForFunctionPointer<glDeleteRenderbuffers_Delegate>(Loader.GetProcAddress("glDeleteRenderbuffers", 3, 0));

				glGenRenderbuffers = Marshal.GetDelegateForFunctionPointer<glGenRenderbuffers_Delegate>(Loader.GetProcAddress("glGenRenderbuffers", 3, 0));

				glRenderbufferStorage = Marshal.GetDelegateForFunctionPointer<glRenderbufferStorage_Delegate>(Loader.GetProcAddress("glRenderbufferStorage", 3, 0));

				glGetRenderbufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetRenderbufferParameteriv_Delegate>(Loader.GetProcAddress("glGetRenderbufferParameteriv", 3, 0));

				glIsFramebuffer = Marshal.GetDelegateForFunctionPointer<glIsFramebuffer_Delegate>(Loader.GetProcAddress("glIsFramebuffer", 3, 0));

				glBindFramebuffer = Marshal.GetDelegateForFunctionPointer<glBindFramebuffer_Delegate>(Loader.GetProcAddress("glBindFramebuffer", 3, 0));

				glDeleteFramebuffers = Marshal.GetDelegateForFunctionPointer<glDeleteFramebuffers_Delegate>(Loader.GetProcAddress("glDeleteFramebuffers", 3, 0));

				glGenFramebuffers = Marshal.GetDelegateForFunctionPointer<glGenFramebuffers_Delegate>(Loader.GetProcAddress("glGenFramebuffers", 3, 0));

				glCheckFramebufferStatus = Marshal.GetDelegateForFunctionPointer<glCheckFramebufferStatus_Delegate>(Loader.GetProcAddress("glCheckFramebufferStatus", 3, 0));

				glFramebufferTexture1D = Marshal.GetDelegateForFunctionPointer<glFramebufferTexture1D_Delegate>(Loader.GetProcAddress("glFramebufferTexture1D", 3, 0));

				glFramebufferTexture2D = Marshal.GetDelegateForFunctionPointer<glFramebufferTexture2D_Delegate>(Loader.GetProcAddress("glFramebufferTexture2D", 3, 0));

				glFramebufferTexture3D = Marshal.GetDelegateForFunctionPointer<glFramebufferTexture3D_Delegate>(Loader.GetProcAddress("glFramebufferTexture3D", 3, 0));

				glFramebufferRenderbuffer = Marshal.GetDelegateForFunctionPointer<glFramebufferRenderbuffer_Delegate>(Loader.GetProcAddress("glFramebufferRenderbuffer", 3, 0));

				glGetFramebufferAttachmentParameteriv = Marshal.GetDelegateForFunctionPointer<glGetFramebufferAttachmentParameteriv_Delegate>(Loader.GetProcAddress("glGetFramebufferAttachmentParameteriv", 3, 0));

				glGenerateMipmap = Marshal.GetDelegateForFunctionPointer<glGenerateMipmap_Delegate>(Loader.GetProcAddress("glGenerateMipmap", 3, 0));

				glBlitFramebuffer = Marshal.GetDelegateForFunctionPointer<glBlitFramebuffer_Delegate>(Loader.GetProcAddress("glBlitFramebuffer", 3, 0));

				glRenderbufferStorageMultisample = Marshal.GetDelegateForFunctionPointer<glRenderbufferStorageMultisample_Delegate>(Loader.GetProcAddress("glRenderbufferStorageMultisample", 3, 0));

				glFramebufferTextureLayer = Marshal.GetDelegateForFunctionPointer<glFramebufferTextureLayer_Delegate>(Loader.GetProcAddress("glFramebufferTextureLayer", 3, 0));

				glFlushMappedBufferRange = Marshal.GetDelegateForFunctionPointer<glFlushMappedBufferRange_Delegate>(Loader.GetProcAddress("glFlushMappedBufferRange", 3, 0));

				glBindVertexArray = Marshal.GetDelegateForFunctionPointer<glBindVertexArray_Delegate>(Loader.GetProcAddress("glBindVertexArray", 3, 0));

				glDeleteVertexArrays = Marshal.GetDelegateForFunctionPointer<glDeleteVertexArrays_Delegate>(Loader.GetProcAddress("glDeleteVertexArrays", 3, 0));

				glGenVertexArrays = Marshal.GetDelegateForFunctionPointer<glGenVertexArrays_Delegate>(Loader.GetProcAddress("glGenVertexArrays", 3, 0));

				glIsVertexArray = Marshal.GetDelegateForFunctionPointer<glIsVertexArray_Delegate>(Loader.GetProcAddress("glIsVertexArray", 3, 0));

			}
			#endregion
			#region GL_VERSION_3_1
			if (major_version >= 3 && minor_version >= 1) {
				glDrawArraysInstanced = Marshal.GetDelegateForFunctionPointer<glDrawArraysInstanced_Delegate>(Loader.GetProcAddress("glDrawArraysInstanced", 3, 1));

				glDrawElementsInstanced = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstanced_Delegate>(Loader.GetProcAddress("glDrawElementsInstanced", 3, 1));

				glTexBuffer = Marshal.GetDelegateForFunctionPointer<glTexBuffer_Delegate>(Loader.GetProcAddress("glTexBuffer", 3, 1));

				glPrimitiveRestartIndex = Marshal.GetDelegateForFunctionPointer<glPrimitiveRestartIndex_Delegate>(Loader.GetProcAddress("glPrimitiveRestartIndex", 3, 1));

				glCopyBufferSubData = Marshal.GetDelegateForFunctionPointer<glCopyBufferSubData_Delegate>(Loader.GetProcAddress("glCopyBufferSubData", 3, 1));

				glGetUniformIndices = Marshal.GetDelegateForFunctionPointer<glGetUniformIndices_Delegate>(Loader.GetProcAddress("glGetUniformIndices", 3, 1));

				glGetActiveUniformsiv = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformsiv_Delegate>(Loader.GetProcAddress("glGetActiveUniformsiv", 3, 1));

				glGetActiveUniformName = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformName_Delegate>(Loader.GetProcAddress("glGetActiveUniformName", 3, 1));

				glGetUniformBlockIndex = Marshal.GetDelegateForFunctionPointer<glGetUniformBlockIndex_Delegate>(Loader.GetProcAddress("glGetUniformBlockIndex", 3, 1));

				glGetActiveUniformBlockiv = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformBlockiv_Delegate>(Loader.GetProcAddress("glGetActiveUniformBlockiv", 3, 1));

				glGetActiveUniformBlockName = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformBlockName_Delegate>(Loader.GetProcAddress("glGetActiveUniformBlockName", 3, 1));

				glUniformBlockBinding = Marshal.GetDelegateForFunctionPointer<glUniformBlockBinding_Delegate>(Loader.GetProcAddress("glUniformBlockBinding", 3, 1));

			}
			#endregion
			#region GL_VERSION_3_2
			if (major_version >= 3 && minor_version >= 2) {
				glDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<glDrawElementsBaseVertex_Delegate>(Loader.GetProcAddress("glDrawElementsBaseVertex", 3, 2));

				glDrawRangeElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<glDrawRangeElementsBaseVertex_Delegate>(Loader.GetProcAddress("glDrawRangeElementsBaseVertex", 3, 2));

				glDrawElementsInstancedBaseVertex = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstancedBaseVertex_Delegate>(Loader.GetProcAddress("glDrawElementsInstancedBaseVertex", 3, 2));

				glMultiDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<glMultiDrawElementsBaseVertex_Delegate>(Loader.GetProcAddress("glMultiDrawElementsBaseVertex", 3, 2));

				glProvokingVertex = Marshal.GetDelegateForFunctionPointer<glProvokingVertex_Delegate>(Loader.GetProcAddress("glProvokingVertex", 3, 2));

				glFenceSync = Marshal.GetDelegateForFunctionPointer<glFenceSync_Delegate>(Loader.GetProcAddress("glFenceSync", 3, 2));

				glIsSync = Marshal.GetDelegateForFunctionPointer<glIsSync_Delegate>(Loader.GetProcAddress("glIsSync", 3, 2));

				glDeleteSync = Marshal.GetDelegateForFunctionPointer<glDeleteSync_Delegate>(Loader.GetProcAddress("glDeleteSync", 3, 2));

				glClientWaitSync = Marshal.GetDelegateForFunctionPointer<glClientWaitSync_Delegate>(Loader.GetProcAddress("glClientWaitSync", 3, 2));

				glWaitSync = Marshal.GetDelegateForFunctionPointer<glWaitSync_Delegate>(Loader.GetProcAddress("glWaitSync", 3, 2));

				glGetInteger64v = Marshal.GetDelegateForFunctionPointer<glGetInteger64v_Delegate>(Loader.GetProcAddress("glGetInteger64v", 3, 2));

				glGetSynciv = Marshal.GetDelegateForFunctionPointer<glGetSynciv_Delegate>(Loader.GetProcAddress("glGetSynciv", 3, 2));

				glGetInteger64i_v = Marshal.GetDelegateForFunctionPointer<glGetInteger64i_v_Delegate>(Loader.GetProcAddress("glGetInteger64i_v", 3, 2));

				glGetBufferParameteri64v = Marshal.GetDelegateForFunctionPointer<glGetBufferParameteri64v_Delegate>(Loader.GetProcAddress("glGetBufferParameteri64v", 3, 2));

				glFramebufferTexture = Marshal.GetDelegateForFunctionPointer<glFramebufferTexture_Delegate>(Loader.GetProcAddress("glFramebufferTexture", 3, 2));

				glTexImage2DMultisample = Marshal.GetDelegateForFunctionPointer<glTexImage2DMultisample_Delegate>(Loader.GetProcAddress("glTexImage2DMultisample", 3, 2));

				glTexImage3DMultisample = Marshal.GetDelegateForFunctionPointer<glTexImage3DMultisample_Delegate>(Loader.GetProcAddress("glTexImage3DMultisample", 3, 2));

				glGetMultisamplefv = Marshal.GetDelegateForFunctionPointer<glGetMultisamplefv_Delegate>(Loader.GetProcAddress("glGetMultisamplefv", 3, 2));

				glSampleMaski = Marshal.GetDelegateForFunctionPointer<glSampleMaski_Delegate>(Loader.GetProcAddress("glSampleMaski", 3, 2));

			}
			#endregion
			#region GL_VERSION_3_3
			if (major_version >= 3 && minor_version >= 3) {
				glBindFragDataLocationIndexed = Marshal.GetDelegateForFunctionPointer<glBindFragDataLocationIndexed_Delegate>(Loader.GetProcAddress("glBindFragDataLocationIndexed", 3, 3));

				glGetFragDataIndex = Marshal.GetDelegateForFunctionPointer<glGetFragDataIndex_Delegate>(Loader.GetProcAddress("glGetFragDataIndex", 3, 3));

				glGenSamplers = Marshal.GetDelegateForFunctionPointer<glGenSamplers_Delegate>(Loader.GetProcAddress("glGenSamplers", 3, 3));

				glDeleteSamplers = Marshal.GetDelegateForFunctionPointer<glDeleteSamplers_Delegate>(Loader.GetProcAddress("glDeleteSamplers", 3, 3));

				glIsSampler = Marshal.GetDelegateForFunctionPointer<glIsSampler_Delegate>(Loader.GetProcAddress("glIsSampler", 3, 3));

				glBindSampler = Marshal.GetDelegateForFunctionPointer<glBindSampler_Delegate>(Loader.GetProcAddress("glBindSampler", 3, 3));

				glSamplerParameteri = Marshal.GetDelegateForFunctionPointer<glSamplerParameteri_Delegate>(Loader.GetProcAddress("glSamplerParameteri", 3, 3));

				glSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<glSamplerParameteriv_Delegate>(Loader.GetProcAddress("glSamplerParameteriv", 3, 3));

				glSamplerParameterf = Marshal.GetDelegateForFunctionPointer<glSamplerParameterf_Delegate>(Loader.GetProcAddress("glSamplerParameterf", 3, 3));

				glSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<glSamplerParameterfv_Delegate>(Loader.GetProcAddress("glSamplerParameterfv", 3, 3));

				glSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<glSamplerParameterIiv_Delegate>(Loader.GetProcAddress("glSamplerParameterIiv", 3, 3));

				glSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<glSamplerParameterIuiv_Delegate>(Loader.GetProcAddress("glSamplerParameterIuiv", 3, 3));

				glGetSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameteriv_Delegate>(Loader.GetProcAddress("glGetSamplerParameteriv", 3, 3));

				glGetSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameterIiv_Delegate>(Loader.GetProcAddress("glGetSamplerParameterIiv", 3, 3));

				glGetSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameterfv_Delegate>(Loader.GetProcAddress("glGetSamplerParameterfv", 3, 3));

				glGetSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameterIuiv_Delegate>(Loader.GetProcAddress("glGetSamplerParameterIuiv", 3, 3));

				glQueryCounter = Marshal.GetDelegateForFunctionPointer<glQueryCounter_Delegate>(Loader.GetProcAddress("glQueryCounter", 3, 3));

				glGetQueryObjecti64v = Marshal.GetDelegateForFunctionPointer<glGetQueryObjecti64v_Delegate>(Loader.GetProcAddress("glGetQueryObjecti64v", 3, 3));

				glGetQueryObjectui64v = Marshal.GetDelegateForFunctionPointer<glGetQueryObjectui64v_Delegate>(Loader.GetProcAddress("glGetQueryObjectui64v", 3, 3));

				glVertexAttribDivisor = Marshal.GetDelegateForFunctionPointer<glVertexAttribDivisor_Delegate>(Loader.GetProcAddress("glVertexAttribDivisor", 3, 3));

				glVertexAttribP1ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP1ui_Delegate>(Loader.GetProcAddress("glVertexAttribP1ui", 3, 3));

				glVertexAttribP1uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribP1uiv_Delegate>(Loader.GetProcAddress("glVertexAttribP1uiv", 3, 3));

				glVertexAttribP2ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP2ui_Delegate>(Loader.GetProcAddress("glVertexAttribP2ui", 3, 3));

				glVertexAttribP2uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribP2uiv_Delegate>(Loader.GetProcAddress("glVertexAttribP2uiv", 3, 3));

				glVertexAttribP3ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP3ui_Delegate>(Loader.GetProcAddress("glVertexAttribP3ui", 3, 3));

				glVertexAttribP3uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribP3uiv_Delegate>(Loader.GetProcAddress("glVertexAttribP3uiv", 3, 3));

				glVertexAttribP4ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP4ui_Delegate>(Loader.GetProcAddress("glVertexAttribP4ui", 3, 3));

				glVertexAttribP4uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribP4uiv_Delegate>(Loader.GetProcAddress("glVertexAttribP4uiv", 3, 3));

			}
			#endregion
			#region GL_VERSION_4_0
			if (major_version >= 4 && minor_version >= 0) {
				glMinSampleShading = Marshal.GetDelegateForFunctionPointer<glMinSampleShading_Delegate>(Loader.GetProcAddress("glMinSampleShading", 4, 0));

				glBlendEquationi = Marshal.GetDelegateForFunctionPointer<glBlendEquationi_Delegate>(Loader.GetProcAddress("glBlendEquationi", 4, 0));

				glBlendEquationSeparatei = Marshal.GetDelegateForFunctionPointer<glBlendEquationSeparatei_Delegate>(Loader.GetProcAddress("glBlendEquationSeparatei", 4, 0));

				glBlendFunci = Marshal.GetDelegateForFunctionPointer<glBlendFunci_Delegate>(Loader.GetProcAddress("glBlendFunci", 4, 0));

				glBlendFuncSeparatei = Marshal.GetDelegateForFunctionPointer<glBlendFuncSeparatei_Delegate>(Loader.GetProcAddress("glBlendFuncSeparatei", 4, 0));

				glDrawArraysIndirect = Marshal.GetDelegateForFunctionPointer<glDrawArraysIndirect_Delegate>(Loader.GetProcAddress("glDrawArraysIndirect", 4, 0));

				glDrawElementsIndirect = Marshal.GetDelegateForFunctionPointer<glDrawElementsIndirect_Delegate>(Loader.GetProcAddress("glDrawElementsIndirect", 4, 0));

				glUniform1d = Marshal.GetDelegateForFunctionPointer<glUniform1d_Delegate>(Loader.GetProcAddress("glUniform1d", 4, 0));

				glUniform2d = Marshal.GetDelegateForFunctionPointer<glUniform2d_Delegate>(Loader.GetProcAddress("glUniform2d", 4, 0));

				glUniform3d = Marshal.GetDelegateForFunctionPointer<glUniform3d_Delegate>(Loader.GetProcAddress("glUniform3d", 4, 0));

				glUniform4d = Marshal.GetDelegateForFunctionPointer<glUniform4d_Delegate>(Loader.GetProcAddress("glUniform4d", 4, 0));

				glUniform1dv = Marshal.GetDelegateForFunctionPointer<glUniform1dv_Delegate>(Loader.GetProcAddress("glUniform1dv", 4, 0));

				glUniform2dv = Marshal.GetDelegateForFunctionPointer<glUniform2dv_Delegate>(Loader.GetProcAddress("glUniform2dv", 4, 0));

				glUniform3dv = Marshal.GetDelegateForFunctionPointer<glUniform3dv_Delegate>(Loader.GetProcAddress("glUniform3dv", 4, 0));

				glUniform4dv = Marshal.GetDelegateForFunctionPointer<glUniform4dv_Delegate>(Loader.GetProcAddress("glUniform4dv", 4, 0));

				glUniformMatrix2dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2dv_Delegate>(Loader.GetProcAddress("glUniformMatrix2dv", 4, 0));

				glUniformMatrix3dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3dv_Delegate>(Loader.GetProcAddress("glUniformMatrix3dv", 4, 0));

				glUniformMatrix4dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4dv_Delegate>(Loader.GetProcAddress("glUniformMatrix4dv", 4, 0));

				glUniformMatrix2x3dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2x3dv_Delegate>(Loader.GetProcAddress("glUniformMatrix2x3dv", 4, 0));

				glUniformMatrix2x4dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2x4dv_Delegate>(Loader.GetProcAddress("glUniformMatrix2x4dv", 4, 0));

				glUniformMatrix3x2dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3x2dv_Delegate>(Loader.GetProcAddress("glUniformMatrix3x2dv", 4, 0));

				glUniformMatrix3x4dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3x4dv_Delegate>(Loader.GetProcAddress("glUniformMatrix3x4dv", 4, 0));

				glUniformMatrix4x2dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4x2dv_Delegate>(Loader.GetProcAddress("glUniformMatrix4x2dv", 4, 0));

				glUniformMatrix4x3dv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4x3dv_Delegate>(Loader.GetProcAddress("glUniformMatrix4x3dv", 4, 0));

				glGetUniformdv = Marshal.GetDelegateForFunctionPointer<glGetUniformdv_Delegate>(Loader.GetProcAddress("glGetUniformdv", 4, 0));

				glGetSubroutineUniformLocation = Marshal.GetDelegateForFunctionPointer<glGetSubroutineUniformLocation_Delegate>(Loader.GetProcAddress("glGetSubroutineUniformLocation", 4, 0));

				glGetSubroutineIndex = Marshal.GetDelegateForFunctionPointer<glGetSubroutineIndex_Delegate>(Loader.GetProcAddress("glGetSubroutineIndex", 4, 0));

				glGetActiveSubroutineUniformiv = Marshal.GetDelegateForFunctionPointer<glGetActiveSubroutineUniformiv_Delegate>(Loader.GetProcAddress("glGetActiveSubroutineUniformiv", 4, 0));

				glGetActiveSubroutineUniformName = Marshal.GetDelegateForFunctionPointer<glGetActiveSubroutineUniformName_Delegate>(Loader.GetProcAddress("glGetActiveSubroutineUniformName", 4, 0));

				glGetActiveSubroutineName = Marshal.GetDelegateForFunctionPointer<glGetActiveSubroutineName_Delegate>(Loader.GetProcAddress("glGetActiveSubroutineName", 4, 0));

				glUniformSubroutinesuiv = Marshal.GetDelegateForFunctionPointer<glUniformSubroutinesuiv_Delegate>(Loader.GetProcAddress("glUniformSubroutinesuiv", 4, 0));

				glGetUniformSubroutineuiv = Marshal.GetDelegateForFunctionPointer<glGetUniformSubroutineuiv_Delegate>(Loader.GetProcAddress("glGetUniformSubroutineuiv", 4, 0));

				glGetProgramStageiv = Marshal.GetDelegateForFunctionPointer<glGetProgramStageiv_Delegate>(Loader.GetProcAddress("glGetProgramStageiv", 4, 0));

				glPatchParameteri = Marshal.GetDelegateForFunctionPointer<glPatchParameteri_Delegate>(Loader.GetProcAddress("glPatchParameteri", 4, 0));

				glPatchParameterfv = Marshal.GetDelegateForFunctionPointer<glPatchParameterfv_Delegate>(Loader.GetProcAddress("glPatchParameterfv", 4, 0));

				glBindTransformFeedback = Marshal.GetDelegateForFunctionPointer<glBindTransformFeedback_Delegate>(Loader.GetProcAddress("glBindTransformFeedback", 4, 0));

				glDeleteTransformFeedbacks = Marshal.GetDelegateForFunctionPointer<glDeleteTransformFeedbacks_Delegate>(Loader.GetProcAddress("glDeleteTransformFeedbacks", 4, 0));

				glGenTransformFeedbacks = Marshal.GetDelegateForFunctionPointer<glGenTransformFeedbacks_Delegate>(Loader.GetProcAddress("glGenTransformFeedbacks", 4, 0));

				glIsTransformFeedback = Marshal.GetDelegateForFunctionPointer<glIsTransformFeedback_Delegate>(Loader.GetProcAddress("glIsTransformFeedback", 4, 0));

				glPauseTransformFeedback = Marshal.GetDelegateForFunctionPointer<glPauseTransformFeedback_Delegate>(Loader.GetProcAddress("glPauseTransformFeedback", 4, 0));

				glResumeTransformFeedback = Marshal.GetDelegateForFunctionPointer<glResumeTransformFeedback_Delegate>(Loader.GetProcAddress("glResumeTransformFeedback", 4, 0));

				glDrawTransformFeedback = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedback_Delegate>(Loader.GetProcAddress("glDrawTransformFeedback", 4, 0));

				glDrawTransformFeedbackStream = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedbackStream_Delegate>(Loader.GetProcAddress("glDrawTransformFeedbackStream", 4, 0));

				glBeginQueryIndexed = Marshal.GetDelegateForFunctionPointer<glBeginQueryIndexed_Delegate>(Loader.GetProcAddress("glBeginQueryIndexed", 4, 0));

				glEndQueryIndexed = Marshal.GetDelegateForFunctionPointer<glEndQueryIndexed_Delegate>(Loader.GetProcAddress("glEndQueryIndexed", 4, 0));

				glGetQueryIndexediv = Marshal.GetDelegateForFunctionPointer<glGetQueryIndexediv_Delegate>(Loader.GetProcAddress("glGetQueryIndexediv", 4, 0));

			}
			#endregion
			#region GL_VERSION_4_1
			if (major_version >= 4 && minor_version >= 1) {
				glReleaseShaderCompiler = Marshal.GetDelegateForFunctionPointer<glReleaseShaderCompiler_Delegate>(Loader.GetProcAddress("glReleaseShaderCompiler", 4, 1));

				glShaderBinary = Marshal.GetDelegateForFunctionPointer<glShaderBinary_Delegate>(Loader.GetProcAddress("glShaderBinary", 4, 1));

				glGetShaderPrecisionFormat = Marshal.GetDelegateForFunctionPointer<glGetShaderPrecisionFormat_Delegate>(Loader.GetProcAddress("glGetShaderPrecisionFormat", 4, 1));

				glDepthRangef = Marshal.GetDelegateForFunctionPointer<glDepthRangef_Delegate>(Loader.GetProcAddress("glDepthRangef", 4, 1));

				glClearDepthf = Marshal.GetDelegateForFunctionPointer<glClearDepthf_Delegate>(Loader.GetProcAddress("glClearDepthf", 4, 1));

				glGetProgramBinary = Marshal.GetDelegateForFunctionPointer<glGetProgramBinary_Delegate>(Loader.GetProcAddress("glGetProgramBinary", 4, 1));

				glProgramBinary = Marshal.GetDelegateForFunctionPointer<glProgramBinary_Delegate>(Loader.GetProcAddress("glProgramBinary", 4, 1));

				glProgramParameteri = Marshal.GetDelegateForFunctionPointer<glProgramParameteri_Delegate>(Loader.GetProcAddress("glProgramParameteri", 4, 1));

				glUseProgramStages = Marshal.GetDelegateForFunctionPointer<glUseProgramStages_Delegate>(Loader.GetProcAddress("glUseProgramStages", 4, 1));

				glActiveShaderProgram = Marshal.GetDelegateForFunctionPointer<glActiveShaderProgram_Delegate>(Loader.GetProcAddress("glActiveShaderProgram", 4, 1));

				glCreateShaderProgramv = Marshal.GetDelegateForFunctionPointer<glCreateShaderProgramv_Delegate>(Loader.GetProcAddress("glCreateShaderProgramv", 4, 1));

				glBindProgramPipeline = Marshal.GetDelegateForFunctionPointer<glBindProgramPipeline_Delegate>(Loader.GetProcAddress("glBindProgramPipeline", 4, 1));

				glDeleteProgramPipelines = Marshal.GetDelegateForFunctionPointer<glDeleteProgramPipelines_Delegate>(Loader.GetProcAddress("glDeleteProgramPipelines", 4, 1));

				glGenProgramPipelines = Marshal.GetDelegateForFunctionPointer<glGenProgramPipelines_Delegate>(Loader.GetProcAddress("glGenProgramPipelines", 4, 1));

				glIsProgramPipeline = Marshal.GetDelegateForFunctionPointer<glIsProgramPipeline_Delegate>(Loader.GetProcAddress("glIsProgramPipeline", 4, 1));

				glGetProgramPipelineiv = Marshal.GetDelegateForFunctionPointer<glGetProgramPipelineiv_Delegate>(Loader.GetProcAddress("glGetProgramPipelineiv", 4, 1));

				glProgramUniform1i = Marshal.GetDelegateForFunctionPointer<glProgramUniform1i_Delegate>(Loader.GetProcAddress("glProgramUniform1i", 4, 1));

				glProgramUniform1iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform1iv_Delegate>(Loader.GetProcAddress("glProgramUniform1iv", 4, 1));

				glProgramUniform1f = Marshal.GetDelegateForFunctionPointer<glProgramUniform1f_Delegate>(Loader.GetProcAddress("glProgramUniform1f", 4, 1));

				glProgramUniform1fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform1fv_Delegate>(Loader.GetProcAddress("glProgramUniform1fv", 4, 1));

				glProgramUniform1d = Marshal.GetDelegateForFunctionPointer<glProgramUniform1d_Delegate>(Loader.GetProcAddress("glProgramUniform1d", 4, 1));

				glProgramUniform1dv = Marshal.GetDelegateForFunctionPointer<glProgramUniform1dv_Delegate>(Loader.GetProcAddress("glProgramUniform1dv", 4, 1));

				glProgramUniform1ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform1ui_Delegate>(Loader.GetProcAddress("glProgramUniform1ui", 4, 1));

				glProgramUniform1uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform1uiv_Delegate>(Loader.GetProcAddress("glProgramUniform1uiv", 4, 1));

				glProgramUniform2i = Marshal.GetDelegateForFunctionPointer<glProgramUniform2i_Delegate>(Loader.GetProcAddress("glProgramUniform2i", 4, 1));

				glProgramUniform2iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform2iv_Delegate>(Loader.GetProcAddress("glProgramUniform2iv", 4, 1));

				glProgramUniform2f = Marshal.GetDelegateForFunctionPointer<glProgramUniform2f_Delegate>(Loader.GetProcAddress("glProgramUniform2f", 4, 1));

				glProgramUniform2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform2fv_Delegate>(Loader.GetProcAddress("glProgramUniform2fv", 4, 1));

				glProgramUniform2d = Marshal.GetDelegateForFunctionPointer<glProgramUniform2d_Delegate>(Loader.GetProcAddress("glProgramUniform2d", 4, 1));

				glProgramUniform2dv = Marshal.GetDelegateForFunctionPointer<glProgramUniform2dv_Delegate>(Loader.GetProcAddress("glProgramUniform2dv", 4, 1));

				glProgramUniform2ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform2ui_Delegate>(Loader.GetProcAddress("glProgramUniform2ui", 4, 1));

				glProgramUniform2uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform2uiv_Delegate>(Loader.GetProcAddress("glProgramUniform2uiv", 4, 1));

				glProgramUniform3i = Marshal.GetDelegateForFunctionPointer<glProgramUniform3i_Delegate>(Loader.GetProcAddress("glProgramUniform3i", 4, 1));

				glProgramUniform3iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform3iv_Delegate>(Loader.GetProcAddress("glProgramUniform3iv", 4, 1));

				glProgramUniform3f = Marshal.GetDelegateForFunctionPointer<glProgramUniform3f_Delegate>(Loader.GetProcAddress("glProgramUniform3f", 4, 1));

				glProgramUniform3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform3fv_Delegate>(Loader.GetProcAddress("glProgramUniform3fv", 4, 1));

				glProgramUniform3d = Marshal.GetDelegateForFunctionPointer<glProgramUniform3d_Delegate>(Loader.GetProcAddress("glProgramUniform3d", 4, 1));

				glProgramUniform3dv = Marshal.GetDelegateForFunctionPointer<glProgramUniform3dv_Delegate>(Loader.GetProcAddress("glProgramUniform3dv", 4, 1));

				glProgramUniform3ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform3ui_Delegate>(Loader.GetProcAddress("glProgramUniform3ui", 4, 1));

				glProgramUniform3uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform3uiv_Delegate>(Loader.GetProcAddress("glProgramUniform3uiv", 4, 1));

				glProgramUniform4i = Marshal.GetDelegateForFunctionPointer<glProgramUniform4i_Delegate>(Loader.GetProcAddress("glProgramUniform4i", 4, 1));

				glProgramUniform4iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform4iv_Delegate>(Loader.GetProcAddress("glProgramUniform4iv", 4, 1));

				glProgramUniform4f = Marshal.GetDelegateForFunctionPointer<glProgramUniform4f_Delegate>(Loader.GetProcAddress("glProgramUniform4f", 4, 1));

				glProgramUniform4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform4fv_Delegate>(Loader.GetProcAddress("glProgramUniform4fv", 4, 1));

				glProgramUniform4d = Marshal.GetDelegateForFunctionPointer<glProgramUniform4d_Delegate>(Loader.GetProcAddress("glProgramUniform4d", 4, 1));

				glProgramUniform4dv = Marshal.GetDelegateForFunctionPointer<glProgramUniform4dv_Delegate>(Loader.GetProcAddress("glProgramUniform4dv", 4, 1));

				glProgramUniform4ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform4ui_Delegate>(Loader.GetProcAddress("glProgramUniform4ui", 4, 1));

				glProgramUniform4uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform4uiv_Delegate>(Loader.GetProcAddress("glProgramUniform4uiv", 4, 1));

				glProgramUniformMatrix2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix2fv", 4, 1));

				glProgramUniformMatrix3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix3fv", 4, 1));

				glProgramUniformMatrix4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix4fv", 4, 1));

				glProgramUniformMatrix2dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix2dv", 4, 1));

				glProgramUniformMatrix3dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix3dv", 4, 1));

				glProgramUniformMatrix4dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix4dv", 4, 1));

				glProgramUniformMatrix2x3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2x3fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix2x3fv", 4, 1));

				glProgramUniformMatrix3x2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3x2fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix3x2fv", 4, 1));

				glProgramUniformMatrix2x4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2x4fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix2x4fv", 4, 1));

				glProgramUniformMatrix4x2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4x2fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix4x2fv", 4, 1));

				glProgramUniformMatrix3x4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3x4fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix3x4fv", 4, 1));

				glProgramUniformMatrix4x3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4x3fv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix4x3fv", 4, 1));

				glProgramUniformMatrix2x3dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2x3dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix2x3dv", 4, 1));

				glProgramUniformMatrix3x2dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3x2dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix3x2dv", 4, 1));

				glProgramUniformMatrix2x4dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2x4dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix2x4dv", 4, 1));

				glProgramUniformMatrix4x2dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4x2dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix4x2dv", 4, 1));

				glProgramUniformMatrix3x4dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3x4dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix3x4dv", 4, 1));

				glProgramUniformMatrix4x3dv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4x3dv_Delegate>(Loader.GetProcAddress("glProgramUniformMatrix4x3dv", 4, 1));

				glValidateProgramPipeline = Marshal.GetDelegateForFunctionPointer<glValidateProgramPipeline_Delegate>(Loader.GetProcAddress("glValidateProgramPipeline", 4, 1));

				glGetProgramPipelineInfoLog = Marshal.GetDelegateForFunctionPointer<glGetProgramPipelineInfoLog_Delegate>(Loader.GetProcAddress("glGetProgramPipelineInfoLog", 4, 1));

				glVertexAttribL1d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL1d_Delegate>(Loader.GetProcAddress("glVertexAttribL1d", 4, 1));

				glVertexAttribL2d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL2d_Delegate>(Loader.GetProcAddress("glVertexAttribL2d", 4, 1));

				glVertexAttribL3d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL3d_Delegate>(Loader.GetProcAddress("glVertexAttribL3d", 4, 1));

				glVertexAttribL4d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL4d_Delegate>(Loader.GetProcAddress("glVertexAttribL4d", 4, 1));

				glVertexAttribL1dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL1dv_Delegate>(Loader.GetProcAddress("glVertexAttribL1dv", 4, 1));

				glVertexAttribL2dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL2dv_Delegate>(Loader.GetProcAddress("glVertexAttribL2dv", 4, 1));

				glVertexAttribL3dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL3dv_Delegate>(Loader.GetProcAddress("glVertexAttribL3dv", 4, 1));

				glVertexAttribL4dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL4dv_Delegate>(Loader.GetProcAddress("glVertexAttribL4dv", 4, 1));

				glVertexAttribLPointer = Marshal.GetDelegateForFunctionPointer<glVertexAttribLPointer_Delegate>(Loader.GetProcAddress("glVertexAttribLPointer", 4, 1));

				glGetVertexAttribLdv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribLdv_Delegate>(Loader.GetProcAddress("glGetVertexAttribLdv", 4, 1));

				glViewportArrayv = Marshal.GetDelegateForFunctionPointer<glViewportArrayv_Delegate>(Loader.GetProcAddress("glViewportArrayv", 4, 1));

				glViewportIndexedf = Marshal.GetDelegateForFunctionPointer<glViewportIndexedf_Delegate>(Loader.GetProcAddress("glViewportIndexedf", 4, 1));

				glViewportIndexedfv = Marshal.GetDelegateForFunctionPointer<glViewportIndexedfv_Delegate>(Loader.GetProcAddress("glViewportIndexedfv", 4, 1));

				glScissorArrayv = Marshal.GetDelegateForFunctionPointer<glScissorArrayv_Delegate>(Loader.GetProcAddress("glScissorArrayv", 4, 1));

				glScissorIndexed = Marshal.GetDelegateForFunctionPointer<glScissorIndexed_Delegate>(Loader.GetProcAddress("glScissorIndexed", 4, 1));

				glScissorIndexedv = Marshal.GetDelegateForFunctionPointer<glScissorIndexedv_Delegate>(Loader.GetProcAddress("glScissorIndexedv", 4, 1));

				glDepthRangeArrayv = Marshal.GetDelegateForFunctionPointer<glDepthRangeArrayv_Delegate>(Loader.GetProcAddress("glDepthRangeArrayv", 4, 1));

				glDepthRangeIndexed = Marshal.GetDelegateForFunctionPointer<glDepthRangeIndexed_Delegate>(Loader.GetProcAddress("glDepthRangeIndexed", 4, 1));

				glGetFloati_v = Marshal.GetDelegateForFunctionPointer<glGetFloati_v_Delegate>(Loader.GetProcAddress("glGetFloati_v", 4, 1));

				glGetDoublei_v = Marshal.GetDelegateForFunctionPointer<glGetDoublei_v_Delegate>(Loader.GetProcAddress("glGetDoublei_v", 4, 1));

			}
			#endregion
			#region GL_VERSION_4_2
			if (major_version >= 4 && minor_version >= 2) {
				glDrawArraysInstancedBaseInstance = Marshal.GetDelegateForFunctionPointer<glDrawArraysInstancedBaseInstance_Delegate>(Loader.GetProcAddress("glDrawArraysInstancedBaseInstance", 4, 2));

				glDrawElementsInstancedBaseInstance = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstancedBaseInstance_Delegate>(Loader.GetProcAddress("glDrawElementsInstancedBaseInstance", 4, 2));

				glDrawElementsInstancedBaseVertexBaseInstance = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstancedBaseVertexBaseInstance_Delegate>(Loader.GetProcAddress("glDrawElementsInstancedBaseVertexBaseInstance", 4, 2));

				glGetInternalformativ = Marshal.GetDelegateForFunctionPointer<glGetInternalformativ_Delegate>(Loader.GetProcAddress("glGetInternalformativ", 4, 2));

				glGetActiveAtomicCounterBufferiv = Marshal.GetDelegateForFunctionPointer<glGetActiveAtomicCounterBufferiv_Delegate>(Loader.GetProcAddress("glGetActiveAtomicCounterBufferiv", 4, 2));

				glBindImageTexture = Marshal.GetDelegateForFunctionPointer<glBindImageTexture_Delegate>(Loader.GetProcAddress("glBindImageTexture", 4, 2));

				glMemoryBarrier = Marshal.GetDelegateForFunctionPointer<glMemoryBarrier_Delegate>(Loader.GetProcAddress("glMemoryBarrier", 4, 2));

				glTexStorage1D = Marshal.GetDelegateForFunctionPointer<glTexStorage1D_Delegate>(Loader.GetProcAddress("glTexStorage1D", 4, 2));

				glTexStorage2D = Marshal.GetDelegateForFunctionPointer<glTexStorage2D_Delegate>(Loader.GetProcAddress("glTexStorage2D", 4, 2));

				glTexStorage3D = Marshal.GetDelegateForFunctionPointer<glTexStorage3D_Delegate>(Loader.GetProcAddress("glTexStorage3D", 4, 2));

				glDrawTransformFeedbackInstanced = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedbackInstanced_Delegate>(Loader.GetProcAddress("glDrawTransformFeedbackInstanced", 4, 2));

				glDrawTransformFeedbackStreamInstanced = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedbackStreamInstanced_Delegate>(Loader.GetProcAddress("glDrawTransformFeedbackStreamInstanced", 4, 2));

			}
			#endregion
			#region GL_VERSION_4_3
			if (major_version >= 4 && minor_version >= 3) {
				glClearBufferData = Marshal.GetDelegateForFunctionPointer<glClearBufferData_Delegate>(Loader.GetProcAddress("glClearBufferData", 4, 3));

				glClearBufferSubData = Marshal.GetDelegateForFunctionPointer<glClearBufferSubData_Delegate>(Loader.GetProcAddress("glClearBufferSubData", 4, 3));

				glDispatchCompute = Marshal.GetDelegateForFunctionPointer<glDispatchCompute_Delegate>(Loader.GetProcAddress("glDispatchCompute", 4, 3));

				glDispatchComputeIndirect = Marshal.GetDelegateForFunctionPointer<glDispatchComputeIndirect_Delegate>(Loader.GetProcAddress("glDispatchComputeIndirect", 4, 3));

				glCopyImageSubData = Marshal.GetDelegateForFunctionPointer<glCopyImageSubData_Delegate>(Loader.GetProcAddress("glCopyImageSubData", 4, 3));

				glFramebufferParameteri = Marshal.GetDelegateForFunctionPointer<glFramebufferParameteri_Delegate>(Loader.GetProcAddress("glFramebufferParameteri", 4, 3));

				glGetFramebufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetFramebufferParameteriv_Delegate>(Loader.GetProcAddress("glGetFramebufferParameteriv", 4, 3));

				glGetInternalformati64v = Marshal.GetDelegateForFunctionPointer<glGetInternalformati64v_Delegate>(Loader.GetProcAddress("glGetInternalformati64v", 4, 3));

				glInvalidateTexSubImage = Marshal.GetDelegateForFunctionPointer<glInvalidateTexSubImage_Delegate>(Loader.GetProcAddress("glInvalidateTexSubImage", 4, 3));

				glInvalidateTexImage = Marshal.GetDelegateForFunctionPointer<glInvalidateTexImage_Delegate>(Loader.GetProcAddress("glInvalidateTexImage", 4, 3));

				glInvalidateBufferSubData = Marshal.GetDelegateForFunctionPointer<glInvalidateBufferSubData_Delegate>(Loader.GetProcAddress("glInvalidateBufferSubData", 4, 3));

				glInvalidateBufferData = Marshal.GetDelegateForFunctionPointer<glInvalidateBufferData_Delegate>(Loader.GetProcAddress("glInvalidateBufferData", 4, 3));

				glInvalidateFramebuffer = Marshal.GetDelegateForFunctionPointer<glInvalidateFramebuffer_Delegate>(Loader.GetProcAddress("glInvalidateFramebuffer", 4, 3));

				glInvalidateSubFramebuffer = Marshal.GetDelegateForFunctionPointer<glInvalidateSubFramebuffer_Delegate>(Loader.GetProcAddress("glInvalidateSubFramebuffer", 4, 3));

				glMultiDrawArraysIndirect = Marshal.GetDelegateForFunctionPointer<glMultiDrawArraysIndirect_Delegate>(Loader.GetProcAddress("glMultiDrawArraysIndirect", 4, 3));

				glMultiDrawElementsIndirect = Marshal.GetDelegateForFunctionPointer<glMultiDrawElementsIndirect_Delegate>(Loader.GetProcAddress("glMultiDrawElementsIndirect", 4, 3));

				glGetProgramInterfaceiv = Marshal.GetDelegateForFunctionPointer<glGetProgramInterfaceiv_Delegate>(Loader.GetProcAddress("glGetProgramInterfaceiv", 4, 3));

				glGetProgramResourceIndex = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceIndex_Delegate>(Loader.GetProcAddress("glGetProgramResourceIndex", 4, 3));

				glGetProgramResourceName = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceName_Delegate>(Loader.GetProcAddress("glGetProgramResourceName", 4, 3));

				glGetProgramResourceiv = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceiv_Delegate>(Loader.GetProcAddress("glGetProgramResourceiv", 4, 3));

				glGetProgramResourceLocation = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceLocation_Delegate>(Loader.GetProcAddress("glGetProgramResourceLocation", 4, 3));

				glGetProgramResourceLocationIndex = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceLocationIndex_Delegate>(Loader.GetProcAddress("glGetProgramResourceLocationIndex", 4, 3));

				glShaderStorageBlockBinding = Marshal.GetDelegateForFunctionPointer<glShaderStorageBlockBinding_Delegate>(Loader.GetProcAddress("glShaderStorageBlockBinding", 4, 3));

				glTexBufferRange = Marshal.GetDelegateForFunctionPointer<glTexBufferRange_Delegate>(Loader.GetProcAddress("glTexBufferRange", 4, 3));

				glTexStorage2DMultisample = Marshal.GetDelegateForFunctionPointer<glTexStorage2DMultisample_Delegate>(Loader.GetProcAddress("glTexStorage2DMultisample", 4, 3));

				glTexStorage3DMultisample = Marshal.GetDelegateForFunctionPointer<glTexStorage3DMultisample_Delegate>(Loader.GetProcAddress("glTexStorage3DMultisample", 4, 3));

				glTextureView = Marshal.GetDelegateForFunctionPointer<glTextureView_Delegate>(Loader.GetProcAddress("glTextureView", 4, 3));

				glBindVertexBuffer = Marshal.GetDelegateForFunctionPointer<glBindVertexBuffer_Delegate>(Loader.GetProcAddress("glBindVertexBuffer", 4, 3));

				glVertexAttribFormat = Marshal.GetDelegateForFunctionPointer<glVertexAttribFormat_Delegate>(Loader.GetProcAddress("glVertexAttribFormat", 4, 3));

				glVertexAttribIFormat = Marshal.GetDelegateForFunctionPointer<glVertexAttribIFormat_Delegate>(Loader.GetProcAddress("glVertexAttribIFormat", 4, 3));

				glVertexAttribLFormat = Marshal.GetDelegateForFunctionPointer<glVertexAttribLFormat_Delegate>(Loader.GetProcAddress("glVertexAttribLFormat", 4, 3));

				glVertexAttribBinding = Marshal.GetDelegateForFunctionPointer<glVertexAttribBinding_Delegate>(Loader.GetProcAddress("glVertexAttribBinding", 4, 3));

				glVertexBindingDivisor = Marshal.GetDelegateForFunctionPointer<glVertexBindingDivisor_Delegate>(Loader.GetProcAddress("glVertexBindingDivisor", 4, 3));

				glDebugMessageControl = Marshal.GetDelegateForFunctionPointer<glDebugMessageControl_Delegate>(Loader.GetProcAddress("glDebugMessageControl", 4, 3));

				glDebugMessageInsert = Marshal.GetDelegateForFunctionPointer<glDebugMessageInsert_Delegate>(Loader.GetProcAddress("glDebugMessageInsert", 4, 3));

				glDebugMessageCallback = Marshal.GetDelegateForFunctionPointer<glDebugMessageCallback_Delegate>(Loader.GetProcAddress("glDebugMessageCallback", 4, 3));

				glGetDebugMessageLog = Marshal.GetDelegateForFunctionPointer<glGetDebugMessageLog_Delegate>(Loader.GetProcAddress("glGetDebugMessageLog", 4, 3));

				glPushDebugGroup = Marshal.GetDelegateForFunctionPointer<glPushDebugGroup_Delegate>(Loader.GetProcAddress("glPushDebugGroup", 4, 3));

				glPopDebugGroup = Marshal.GetDelegateForFunctionPointer<glPopDebugGroup_Delegate>(Loader.GetProcAddress("glPopDebugGroup", 4, 3));

				glObjectLabel = Marshal.GetDelegateForFunctionPointer<glObjectLabel_Delegate>(Loader.GetProcAddress("glObjectLabel", 4, 3));

				glGetObjectLabel = Marshal.GetDelegateForFunctionPointer<glGetObjectLabel_Delegate>(Loader.GetProcAddress("glGetObjectLabel", 4, 3));

				glObjectPtrLabel = Marshal.GetDelegateForFunctionPointer<glObjectPtrLabel_Delegate>(Loader.GetProcAddress("glObjectPtrLabel", 4, 3));

				glGetObjectPtrLabel = Marshal.GetDelegateForFunctionPointer<glGetObjectPtrLabel_Delegate>(Loader.GetProcAddress("glGetObjectPtrLabel", 4, 3));

			}
			#endregion
			#region GL_VERSION_4_4
			if (major_version >= 4 && minor_version >= 4) {
				glBufferStorage = Marshal.GetDelegateForFunctionPointer<glBufferStorage_Delegate>(Loader.GetProcAddress("glBufferStorage", 4, 4));

				glClearTexImage = Marshal.GetDelegateForFunctionPointer<glClearTexImage_Delegate>(Loader.GetProcAddress("glClearTexImage", 4, 4));

				glClearTexSubImage = Marshal.GetDelegateForFunctionPointer<glClearTexSubImage_Delegate>(Loader.GetProcAddress("glClearTexSubImage", 4, 4));

				glBindBuffersBase = Marshal.GetDelegateForFunctionPointer<glBindBuffersBase_Delegate>(Loader.GetProcAddress("glBindBuffersBase", 4, 4));

				glBindBuffersRange = Marshal.GetDelegateForFunctionPointer<glBindBuffersRange_Delegate>(Loader.GetProcAddress("glBindBuffersRange", 4, 4));

				glBindTextures = Marshal.GetDelegateForFunctionPointer<glBindTextures_Delegate>(Loader.GetProcAddress("glBindTextures", 4, 4));

				glBindSamplers = Marshal.GetDelegateForFunctionPointer<glBindSamplers_Delegate>(Loader.GetProcAddress("glBindSamplers", 4, 4));

				glBindImageTextures = Marshal.GetDelegateForFunctionPointer<glBindImageTextures_Delegate>(Loader.GetProcAddress("glBindImageTextures", 4, 4));

				glBindVertexBuffers = Marshal.GetDelegateForFunctionPointer<glBindVertexBuffers_Delegate>(Loader.GetProcAddress("glBindVertexBuffers", 4, 4));

			}
			#endregion
			#region GL_VERSION_4_5
			if (major_version >= 4 && minor_version >= 5) {
				glClipControl = Marshal.GetDelegateForFunctionPointer<glClipControl_Delegate>(Loader.GetProcAddress("glClipControl", 4, 5));

				glCreateTransformFeedbacks = Marshal.GetDelegateForFunctionPointer<glCreateTransformFeedbacks_Delegate>(Loader.GetProcAddress("glCreateTransformFeedbacks", 4, 5));

				glTransformFeedbackBufferBase = Marshal.GetDelegateForFunctionPointer<glTransformFeedbackBufferBase_Delegate>(Loader.GetProcAddress("glTransformFeedbackBufferBase", 4, 5));

				glTransformFeedbackBufferRange = Marshal.GetDelegateForFunctionPointer<glTransformFeedbackBufferRange_Delegate>(Loader.GetProcAddress("glTransformFeedbackBufferRange", 4, 5));

				glGetTransformFeedbackiv = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbackiv_Delegate>(Loader.GetProcAddress("glGetTransformFeedbackiv", 4, 5));

				glGetTransformFeedbacki_v = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbacki_v_Delegate>(Loader.GetProcAddress("glGetTransformFeedbacki_v", 4, 5));

				glGetTransformFeedbacki64_v = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbacki64_v_Delegate>(Loader.GetProcAddress("glGetTransformFeedbacki64_v", 4, 5));

				glCreateBuffers = Marshal.GetDelegateForFunctionPointer<glCreateBuffers_Delegate>(Loader.GetProcAddress("glCreateBuffers", 4, 5));

				glNamedBufferStorage = Marshal.GetDelegateForFunctionPointer<glNamedBufferStorage_Delegate>(Loader.GetProcAddress("glNamedBufferStorage", 4, 5));

				glNamedBufferData = Marshal.GetDelegateForFunctionPointer<glNamedBufferData_Delegate>(Loader.GetProcAddress("glNamedBufferData", 4, 5));

				glNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glNamedBufferSubData_Delegate>(Loader.GetProcAddress("glNamedBufferSubData", 4, 5));

				glCopyNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glCopyNamedBufferSubData_Delegate>(Loader.GetProcAddress("glCopyNamedBufferSubData", 4, 5));

				glClearNamedBufferData = Marshal.GetDelegateForFunctionPointer<glClearNamedBufferData_Delegate>(Loader.GetProcAddress("glClearNamedBufferData", 4, 5));

				glClearNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glClearNamedBufferSubData_Delegate>(Loader.GetProcAddress("glClearNamedBufferSubData", 4, 5));

				glUnmapNamedBuffer = Marshal.GetDelegateForFunctionPointer<glUnmapNamedBuffer_Delegate>(Loader.GetProcAddress("glUnmapNamedBuffer", 4, 5));

				glFlushMappedNamedBufferRange = Marshal.GetDelegateForFunctionPointer<glFlushMappedNamedBufferRange_Delegate>(Loader.GetProcAddress("glFlushMappedNamedBufferRange", 4, 5));

				glGetNamedBufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferParameteriv_Delegate>(Loader.GetProcAddress("glGetNamedBufferParameteriv", 4, 5));

				glGetNamedBufferParameteri64v = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferParameteri64v_Delegate>(Loader.GetProcAddress("glGetNamedBufferParameteri64v", 4, 5));

				glGetNamedBufferPointerv = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferPointerv_Delegate>(Loader.GetProcAddress("glGetNamedBufferPointerv", 4, 5));

				glGetNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferSubData_Delegate>(Loader.GetProcAddress("glGetNamedBufferSubData", 4, 5));

				glCreateFramebuffers = Marshal.GetDelegateForFunctionPointer<glCreateFramebuffers_Delegate>(Loader.GetProcAddress("glCreateFramebuffers", 4, 5));

				glNamedFramebufferRenderbuffer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferRenderbuffer_Delegate>(Loader.GetProcAddress("glNamedFramebufferRenderbuffer", 4, 5));

				glNamedFramebufferParameteri = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferParameteri_Delegate>(Loader.GetProcAddress("glNamedFramebufferParameteri", 4, 5));

				glNamedFramebufferTexture = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferTexture_Delegate>(Loader.GetProcAddress("glNamedFramebufferTexture", 4, 5));

				glNamedFramebufferTextureLayer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferTextureLayer_Delegate>(Loader.GetProcAddress("glNamedFramebufferTextureLayer", 4, 5));

				glNamedFramebufferDrawBuffer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferDrawBuffer_Delegate>(Loader.GetProcAddress("glNamedFramebufferDrawBuffer", 4, 5));

				glNamedFramebufferDrawBuffers = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferDrawBuffers_Delegate>(Loader.GetProcAddress("glNamedFramebufferDrawBuffers", 4, 5));

				glNamedFramebufferReadBuffer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferReadBuffer_Delegate>(Loader.GetProcAddress("glNamedFramebufferReadBuffer", 4, 5));

				glInvalidateNamedFramebufferData = Marshal.GetDelegateForFunctionPointer<glInvalidateNamedFramebufferData_Delegate>(Loader.GetProcAddress("glInvalidateNamedFramebufferData", 4, 5));

				glInvalidateNamedFramebufferSubData = Marshal.GetDelegateForFunctionPointer<glInvalidateNamedFramebufferSubData_Delegate>(Loader.GetProcAddress("glInvalidateNamedFramebufferSubData", 4, 5));

				glClearNamedFramebufferiv = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferiv_Delegate>(Loader.GetProcAddress("glClearNamedFramebufferiv", 4, 5));

				glClearNamedFramebufferuiv = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferuiv_Delegate>(Loader.GetProcAddress("glClearNamedFramebufferuiv", 4, 5));

				glClearNamedFramebufferfv = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferfv_Delegate>(Loader.GetProcAddress("glClearNamedFramebufferfv", 4, 5));

				glClearNamedFramebufferfi = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferfi_Delegate>(Loader.GetProcAddress("glClearNamedFramebufferfi", 4, 5));

				glBlitNamedFramebuffer = Marshal.GetDelegateForFunctionPointer<glBlitNamedFramebuffer_Delegate>(Loader.GetProcAddress("glBlitNamedFramebuffer", 4, 5));

				glCheckNamedFramebufferStatus = Marshal.GetDelegateForFunctionPointer<glCheckNamedFramebufferStatus_Delegate>(Loader.GetProcAddress("glCheckNamedFramebufferStatus", 4, 5));

				glGetNamedFramebufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedFramebufferParameteriv_Delegate>(Loader.GetProcAddress("glGetNamedFramebufferParameteriv", 4, 5));

				glGetNamedFramebufferAttachmentParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedFramebufferAttachmentParameteriv_Delegate>(Loader.GetProcAddress("glGetNamedFramebufferAttachmentParameteriv", 4, 5));

				glCreateRenderbuffers = Marshal.GetDelegateForFunctionPointer<glCreateRenderbuffers_Delegate>(Loader.GetProcAddress("glCreateRenderbuffers", 4, 5));

				glNamedRenderbufferStorage = Marshal.GetDelegateForFunctionPointer<glNamedRenderbufferStorage_Delegate>(Loader.GetProcAddress("glNamedRenderbufferStorage", 4, 5));

				glNamedRenderbufferStorageMultisample = Marshal.GetDelegateForFunctionPointer<glNamedRenderbufferStorageMultisample_Delegate>(Loader.GetProcAddress("glNamedRenderbufferStorageMultisample", 4, 5));

				glGetNamedRenderbufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedRenderbufferParameteriv_Delegate>(Loader.GetProcAddress("glGetNamedRenderbufferParameteriv", 4, 5));

				glCreateTextures = Marshal.GetDelegateForFunctionPointer<glCreateTextures_Delegate>(Loader.GetProcAddress("glCreateTextures", 4, 5));

				glTextureBuffer = Marshal.GetDelegateForFunctionPointer<glTextureBuffer_Delegate>(Loader.GetProcAddress("glTextureBuffer", 4, 5));

				glTextureBufferRange = Marshal.GetDelegateForFunctionPointer<glTextureBufferRange_Delegate>(Loader.GetProcAddress("glTextureBufferRange", 4, 5));

				glTextureStorage1D = Marshal.GetDelegateForFunctionPointer<glTextureStorage1D_Delegate>(Loader.GetProcAddress("glTextureStorage1D", 4, 5));

				glTextureStorage2D = Marshal.GetDelegateForFunctionPointer<glTextureStorage2D_Delegate>(Loader.GetProcAddress("glTextureStorage2D", 4, 5));

				glTextureStorage3D = Marshal.GetDelegateForFunctionPointer<glTextureStorage3D_Delegate>(Loader.GetProcAddress("glTextureStorage3D", 4, 5));

				glTextureStorage2DMultisample = Marshal.GetDelegateForFunctionPointer<glTextureStorage2DMultisample_Delegate>(Loader.GetProcAddress("glTextureStorage2DMultisample", 4, 5));

				glTextureStorage3DMultisample = Marshal.GetDelegateForFunctionPointer<glTextureStorage3DMultisample_Delegate>(Loader.GetProcAddress("glTextureStorage3DMultisample", 4, 5));

				glTextureSubImage1D = Marshal.GetDelegateForFunctionPointer<glTextureSubImage1D_Delegate>(Loader.GetProcAddress("glTextureSubImage1D", 4, 5));

				glTextureSubImage2D = Marshal.GetDelegateForFunctionPointer<glTextureSubImage2D_Delegate>(Loader.GetProcAddress("glTextureSubImage2D", 4, 5));

				glTextureSubImage3D = Marshal.GetDelegateForFunctionPointer<glTextureSubImage3D_Delegate>(Loader.GetProcAddress("glTextureSubImage3D", 4, 5));

				glCompressedTextureSubImage1D = Marshal.GetDelegateForFunctionPointer<glCompressedTextureSubImage1D_Delegate>(Loader.GetProcAddress("glCompressedTextureSubImage1D", 4, 5));

				glCompressedTextureSubImage2D = Marshal.GetDelegateForFunctionPointer<glCompressedTextureSubImage2D_Delegate>(Loader.GetProcAddress("glCompressedTextureSubImage2D", 4, 5));

				glCompressedTextureSubImage3D = Marshal.GetDelegateForFunctionPointer<glCompressedTextureSubImage3D_Delegate>(Loader.GetProcAddress("glCompressedTextureSubImage3D", 4, 5));

				glCopyTextureSubImage1D = Marshal.GetDelegateForFunctionPointer<glCopyTextureSubImage1D_Delegate>(Loader.GetProcAddress("glCopyTextureSubImage1D", 4, 5));

				glCopyTextureSubImage2D = Marshal.GetDelegateForFunctionPointer<glCopyTextureSubImage2D_Delegate>(Loader.GetProcAddress("glCopyTextureSubImage2D", 4, 5));

				glCopyTextureSubImage3D = Marshal.GetDelegateForFunctionPointer<glCopyTextureSubImage3D_Delegate>(Loader.GetProcAddress("glCopyTextureSubImage3D", 4, 5));

				glTextureParameterf = Marshal.GetDelegateForFunctionPointer<glTextureParameterf_Delegate>(Loader.GetProcAddress("glTextureParameterf", 4, 5));

				glTextureParameterfv = Marshal.GetDelegateForFunctionPointer<glTextureParameterfv_Delegate>(Loader.GetProcAddress("glTextureParameterfv", 4, 5));

				glTextureParameteri = Marshal.GetDelegateForFunctionPointer<glTextureParameteri_Delegate>(Loader.GetProcAddress("glTextureParameteri", 4, 5));

				glTextureParameterIiv = Marshal.GetDelegateForFunctionPointer<glTextureParameterIiv_Delegate>(Loader.GetProcAddress("glTextureParameterIiv", 4, 5));

				glTextureParameterIuiv = Marshal.GetDelegateForFunctionPointer<glTextureParameterIuiv_Delegate>(Loader.GetProcAddress("glTextureParameterIuiv", 4, 5));

				glTextureParameteriv = Marshal.GetDelegateForFunctionPointer<glTextureParameteriv_Delegate>(Loader.GetProcAddress("glTextureParameteriv", 4, 5));

				glGenerateTextureMipmap = Marshal.GetDelegateForFunctionPointer<glGenerateTextureMipmap_Delegate>(Loader.GetProcAddress("glGenerateTextureMipmap", 4, 5));

				glBindTextureUnit = Marshal.GetDelegateForFunctionPointer<glBindTextureUnit_Delegate>(Loader.GetProcAddress("glBindTextureUnit", 4, 5));

				glGetTextureImage = Marshal.GetDelegateForFunctionPointer<glGetTextureImage_Delegate>(Loader.GetProcAddress("glGetTextureImage", 4, 5));

				glGetCompressedTextureImage = Marshal.GetDelegateForFunctionPointer<glGetCompressedTextureImage_Delegate>(Loader.GetProcAddress("glGetCompressedTextureImage", 4, 5));

				glGetTextureLevelParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTextureLevelParameterfv_Delegate>(Loader.GetProcAddress("glGetTextureLevelParameterfv", 4, 5));

				glGetTextureLevelParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTextureLevelParameteriv_Delegate>(Loader.GetProcAddress("glGetTextureLevelParameteriv", 4, 5));

				glGetTextureParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameterfv_Delegate>(Loader.GetProcAddress("glGetTextureParameterfv", 4, 5));

				glGetTextureParameterIiv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameterIiv_Delegate>(Loader.GetProcAddress("glGetTextureParameterIiv", 4, 5));

				glGetTextureParameterIuiv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameterIuiv_Delegate>(Loader.GetProcAddress("glGetTextureParameterIuiv", 4, 5));

				glGetTextureParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameteriv_Delegate>(Loader.GetProcAddress("glGetTextureParameteriv", 4, 5));

				glCreateVertexArrays = Marshal.GetDelegateForFunctionPointer<glCreateVertexArrays_Delegate>(Loader.GetProcAddress("glCreateVertexArrays", 4, 5));

				glDisableVertexArrayAttrib = Marshal.GetDelegateForFunctionPointer<glDisableVertexArrayAttrib_Delegate>(Loader.GetProcAddress("glDisableVertexArrayAttrib", 4, 5));

				glEnableVertexArrayAttrib = Marshal.GetDelegateForFunctionPointer<glEnableVertexArrayAttrib_Delegate>(Loader.GetProcAddress("glEnableVertexArrayAttrib", 4, 5));

				glVertexArrayElementBuffer = Marshal.GetDelegateForFunctionPointer<glVertexArrayElementBuffer_Delegate>(Loader.GetProcAddress("glVertexArrayElementBuffer", 4, 5));

				glVertexArrayVertexBuffer = Marshal.GetDelegateForFunctionPointer<glVertexArrayVertexBuffer_Delegate>(Loader.GetProcAddress("glVertexArrayVertexBuffer", 4, 5));

				glVertexArrayVertexBuffers = Marshal.GetDelegateForFunctionPointer<glVertexArrayVertexBuffers_Delegate>(Loader.GetProcAddress("glVertexArrayVertexBuffers", 4, 5));

				glVertexArrayAttribBinding = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribBinding_Delegate>(Loader.GetProcAddress("glVertexArrayAttribBinding", 4, 5));

				glVertexArrayAttribFormat = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribFormat_Delegate>(Loader.GetProcAddress("glVertexArrayAttribFormat", 4, 5));

				glVertexArrayAttribIFormat = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribIFormat_Delegate>(Loader.GetProcAddress("glVertexArrayAttribIFormat", 4, 5));

				glVertexArrayAttribLFormat = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribLFormat_Delegate>(Loader.GetProcAddress("glVertexArrayAttribLFormat", 4, 5));

				glVertexArrayBindingDivisor = Marshal.GetDelegateForFunctionPointer<glVertexArrayBindingDivisor_Delegate>(Loader.GetProcAddress("glVertexArrayBindingDivisor", 4, 5));

				glGetVertexArrayiv = Marshal.GetDelegateForFunctionPointer<glGetVertexArrayiv_Delegate>(Loader.GetProcAddress("glGetVertexArrayiv", 4, 5));

				glGetVertexArrayIndexediv = Marshal.GetDelegateForFunctionPointer<glGetVertexArrayIndexediv_Delegate>(Loader.GetProcAddress("glGetVertexArrayIndexediv", 4, 5));

				glGetVertexArrayIndexed64iv = Marshal.GetDelegateForFunctionPointer<glGetVertexArrayIndexed64iv_Delegate>(Loader.GetProcAddress("glGetVertexArrayIndexed64iv", 4, 5));

				glCreateSamplers = Marshal.GetDelegateForFunctionPointer<glCreateSamplers_Delegate>(Loader.GetProcAddress("glCreateSamplers", 4, 5));

				glCreateProgramPipelines = Marshal.GetDelegateForFunctionPointer<glCreateProgramPipelines_Delegate>(Loader.GetProcAddress("glCreateProgramPipelines", 4, 5));

				glCreateQueries = Marshal.GetDelegateForFunctionPointer<glCreateQueries_Delegate>(Loader.GetProcAddress("glCreateQueries", 4, 5));

				glGetQueryBufferObjecti64v = Marshal.GetDelegateForFunctionPointer<glGetQueryBufferObjecti64v_Delegate>(Loader.GetProcAddress("glGetQueryBufferObjecti64v", 4, 5));

				glGetQueryBufferObjectiv = Marshal.GetDelegateForFunctionPointer<glGetQueryBufferObjectiv_Delegate>(Loader.GetProcAddress("glGetQueryBufferObjectiv", 4, 5));

				glGetQueryBufferObjectui64v = Marshal.GetDelegateForFunctionPointer<glGetQueryBufferObjectui64v_Delegate>(Loader.GetProcAddress("glGetQueryBufferObjectui64v", 4, 5));

				glGetQueryBufferObjectuiv = Marshal.GetDelegateForFunctionPointer<glGetQueryBufferObjectuiv_Delegate>(Loader.GetProcAddress("glGetQueryBufferObjectuiv", 4, 5));

				glMemoryBarrierByRegion = Marshal.GetDelegateForFunctionPointer<glMemoryBarrierByRegion_Delegate>(Loader.GetProcAddress("glMemoryBarrierByRegion", 4, 5));

				glGetTextureSubImage = Marshal.GetDelegateForFunctionPointer<glGetTextureSubImage_Delegate>(Loader.GetProcAddress("glGetTextureSubImage", 4, 5));

				glGetCompressedTextureSubImage = Marshal.GetDelegateForFunctionPointer<glGetCompressedTextureSubImage_Delegate>(Loader.GetProcAddress("glGetCompressedTextureSubImage", 4, 5));

				glGetGraphicsResetStatus = Marshal.GetDelegateForFunctionPointer<glGetGraphicsResetStatus_Delegate>(Loader.GetProcAddress("glGetGraphicsResetStatus", 4, 5));

				glGetnCompressedTexImage = Marshal.GetDelegateForFunctionPointer<glGetnCompressedTexImage_Delegate>(Loader.GetProcAddress("glGetnCompressedTexImage", 4, 5));

				glGetnTexImage = Marshal.GetDelegateForFunctionPointer<glGetnTexImage_Delegate>(Loader.GetProcAddress("glGetnTexImage", 4, 5));

				glGetnUniformdv = Marshal.GetDelegateForFunctionPointer<glGetnUniformdv_Delegate>(Loader.GetProcAddress("glGetnUniformdv", 4, 5));

				glGetnUniformfv = Marshal.GetDelegateForFunctionPointer<glGetnUniformfv_Delegate>(Loader.GetProcAddress("glGetnUniformfv", 4, 5));

				glGetnUniformiv = Marshal.GetDelegateForFunctionPointer<glGetnUniformiv_Delegate>(Loader.GetProcAddress("glGetnUniformiv", 4, 5));

				glGetnUniformuiv = Marshal.GetDelegateForFunctionPointer<glGetnUniformuiv_Delegate>(Loader.GetProcAddress("glGetnUniformuiv", 4, 5));

				glReadnPixels = Marshal.GetDelegateForFunctionPointer<glReadnPixels_Delegate>(Loader.GetProcAddress("glReadnPixels", 4, 5));

				glTextureBarrier = Marshal.GetDelegateForFunctionPointer<glTextureBarrier_Delegate>(Loader.GetProcAddress("glTextureBarrier", 4, 5));

			}
			#endregion
			#region GL_VERSION_4_6
			if (major_version >= 4 && minor_version >= 6) {
				glSpecializeShader = Marshal.GetDelegateForFunctionPointer<glSpecializeShader_Delegate>(Loader.GetProcAddress("glSpecializeShader", 4, 6));

				glMultiDrawArraysIndirectCount = Marshal.GetDelegateForFunctionPointer<glMultiDrawArraysIndirectCount_Delegate>(Loader.GetProcAddress("glMultiDrawArraysIndirectCount", 4, 6));

				glMultiDrawElementsIndirectCount = Marshal.GetDelegateForFunctionPointer<glMultiDrawElementsIndirectCount_Delegate>(Loader.GetProcAddress("glMultiDrawElementsIndirectCount", 4, 6));

				glPolygonOffsetClamp = Marshal.GetDelegateForFunctionPointer<glPolygonOffsetClamp_Delegate>(Loader.GetProcAddress("glPolygonOffsetClamp", 4, 6));

			}
			#endregion
			Console.WriteLine("OpenGL functions bound successfully.");
		}
	}
}
