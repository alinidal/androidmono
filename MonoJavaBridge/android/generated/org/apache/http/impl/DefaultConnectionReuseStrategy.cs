namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultConnectionReuseStrategy : java.lang.Object, ConnectionReuseStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultConnectionReuseStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool keepAlive(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, "keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", ref global::org.apache.http.impl.DefaultConnectionReuseStrategy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual global::org.apache.http.TokenIterator createTokenIterator(org.apache.http.HeaderIterator arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.TokenIterator>(this, global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, "createTokenIterator", "(Lorg/apache/http/HeaderIterator;)Lorg/apache/http/TokenIterator;", ref global::org.apache.http.impl.DefaultConnectionReuseStrategy._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.TokenIterator;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DefaultConnectionReuseStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultConnectionReuseStrategy._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultConnectionReuseStrategy._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, global::org.apache.http.impl.DefaultConnectionReuseStrategy._m2);
			Init(@__env, handle);
		}
		static DefaultConnectionReuseStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultConnectionReuseStrategy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
