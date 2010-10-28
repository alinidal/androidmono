namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpEntityWrapper : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpEntityWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32547;
		public virtual global::java.io.InputStream getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContent32547)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContent32547)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32548;
		public virtual void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._writeTo32548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._writeTo32548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header ContentType
		{
			get
			{
				return getContentType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentType32549;
		public virtual global::org.apache.http.Header getContentType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContentType32549)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContentType32549)) as org.apache.http.Header;
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32550;
		public virtual long getContentLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContentLength32550);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContentLength32550);
		}
		public new global::org.apache.http.Header ContentEncoding
		{
			get
			{
				return getContentEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding32551;
		public virtual global::org.apache.http.Header getContentEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContentEncoding32551)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContentEncoding32551)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32552;
		public virtual bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._isRepeatable32552);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._isRepeatable32552);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked32553;
		public virtual bool isChunked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._isChunked32553);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._isChunked32553);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32554;
		public virtual bool isStreaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._isStreaming32554);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._isStreaming32554);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32555;
		public virtual void consumeContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._consumeContent32555);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._consumeContent32555);
		}
		internal static global::MonoJavaBridge.MethodId _HttpEntityWrapper32556;
		public HttpEntityWrapper(org.apache.http.HttpEntity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._HttpEntityWrapper32556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpEntityWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.HttpEntityWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/HttpEntityWrapper"));
			global::org.apache.http.entity.HttpEntityWrapper._getContent32547 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.HttpEntityWrapper._writeTo32548 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.HttpEntityWrapper._getContentType32549 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentType", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.HttpEntityWrapper._getContentLength32550 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.HttpEntityWrapper._getContentEncoding32551 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.HttpEntityWrapper._isRepeatable32552 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.HttpEntityWrapper._isChunked32553 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isChunked", "()Z");
			global::org.apache.http.entity.HttpEntityWrapper._isStreaming32554 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.HttpEntityWrapper._consumeContent32555 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.HttpEntityWrapper._HttpEntityWrapper32556 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}