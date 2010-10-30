namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UriPatternMatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UriPatternMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void register(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, "register", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.apache.http.protocol.UriPatternMatcher._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object lookup(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, "lookup", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.protocol.UriPatternMatcher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, "unregister", "(Ljava/lang/String;)V", ref global::org.apache.http.protocol.UriPatternMatcher._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Map Handlers
		{
			set
			{
				setHandlers(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setHandlers(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, "setHandlers", "(Ljava/util/Map;)V", ref global::org.apache.http.protocol.UriPatternMatcher._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual bool matchUriRequestPattern(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, "matchUriRequestPattern", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.apache.http.protocol.UriPatternMatcher._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public UriPatternMatcher() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.UriPatternMatcher._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.UriPatternMatcher._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._m5);
			Init(@__env, handle);
		}
		static UriPatternMatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.UriPatternMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/UriPatternMatcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
