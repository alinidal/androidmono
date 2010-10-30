namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.CookieSpec_))]
	public partial interface CookieSpec  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1);
		bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		int getVersion();
		void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		global::java.util.List formatCookies(java.util.List arg0);
		global::org.apache.http.Header getVersionHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.CookieSpec))]
	internal sealed partial class CookieSpec_ : java.lang.Object, CookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieSpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.List org.apache.http.cookie.CookieSpec.parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.cookie.CookieSpec_.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", ref global::org.apache.http.cookie.CookieSpec_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool org.apache.http.cookie.CookieSpec.match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.CookieSpec_.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", ref global::org.apache.http.cookie.CookieSpec_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int org.apache.http.cookie.CookieSpec.getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.CookieSpec_.staticClass, "getVersion", "()I", ref global::org.apache.http.cookie.CookieSpec_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.http.cookie.CookieSpec.validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.CookieSpec_.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", ref global::org.apache.http.cookie.CookieSpec_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.util.List org.apache.http.cookie.CookieSpec.formatCookies(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.cookie.CookieSpec_.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;", ref global::org.apache.http.cookie.CookieSpec_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.apache.http.Header org.apache.http.cookie.CookieSpec.getVersionHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.cookie.CookieSpec_.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;", ref global::org.apache.http.cookie.CookieSpec_._m5) as org.apache.http.Header;
		}
		static CookieSpec_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieSpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieSpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
