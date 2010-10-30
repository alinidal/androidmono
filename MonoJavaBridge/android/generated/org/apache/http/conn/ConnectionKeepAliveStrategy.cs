namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ConnectionKeepAliveStrategy_))]
	public partial interface ConnectionKeepAliveStrategy  : global::MonoJavaBridge.IJavaObject 
	{
		long getKeepAliveDuration(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ConnectionKeepAliveStrategy))]
	internal sealed partial class ConnectionKeepAliveStrategy_ : java.lang.Object, ConnectionKeepAliveStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnectionKeepAliveStrategy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		long org.apache.http.conn.ConnectionKeepAliveStrategy.getKeepAliveDuration(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.conn.ConnectionKeepAliveStrategy_.staticClass, "getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J", ref global::org.apache.http.conn.ConnectionKeepAliveStrategy_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static ConnectionKeepAliveStrategy_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ConnectionKeepAliveStrategy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ConnectionKeepAliveStrategy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
