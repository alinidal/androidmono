namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpClientConnection : org.apache.http.impl.SocketHttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpClientConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32636;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpClientConnection._toString32636)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, global::org.apache.http.impl.DefaultHttpClientConnection._toString32636)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _bind32637;
		public virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpClientConnection._bind32637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, global::org.apache.http.impl.DefaultHttpClientConnection._bind32637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpClientConnection32638;
		public DefaultHttpClientConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpClientConnection.staticClass, global::org.apache.http.impl.DefaultHttpClientConnection._DefaultHttpClientConnection32638);
			Init(@__env, handle);
		}
		static DefaultHttpClientConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpClientConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpClientConnection"));
			global::org.apache.http.impl.DefaultHttpClientConnection._toString32636 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.impl.DefaultHttpClientConnection._bind32637 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.DefaultHttpClientConnection._DefaultHttpClientConnection32638 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpClientConnection.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}