namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseConnControl : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseConnControl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33948;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.ResponseConnControl._process33948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.ResponseConnControl.staticClass, global::org.apache.http.protocol.ResponseConnControl._process33948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseConnControl33949;
		public ResponseConnControl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.ResponseConnControl.staticClass, global::org.apache.http.protocol.ResponseConnControl._ResponseConnControl33949);
			Init(@__env, handle);
		}
		static ResponseConnControl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.ResponseConnControl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/ResponseConnControl"));
			global::org.apache.http.protocol.ResponseConnControl._process33948 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseConnControl.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.ResponseConnControl._ResponseConnControl33949 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseConnControl.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}