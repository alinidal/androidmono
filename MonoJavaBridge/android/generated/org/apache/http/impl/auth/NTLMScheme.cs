namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTLMScheme : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NTLMScheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.auth.NTLMScheme._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.NTLMScheme._m1) as java.lang.String;
		}
		public new global::java.lang.String Realm
		{
			get
			{
				return getRealm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String getRealm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getRealm", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.NTLMScheme._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.NTLMScheme.staticClass, "isConnectionBased", "()Z", ref global::org.apache.http.impl.auth.NTLMScheme._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.NTLMScheme.staticClass, "isComplete", "()Z", ref global::org.apache.http.impl.auth.NTLMScheme._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.auth.NTLMScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;", ref global::org.apache.http.impl.auth.NTLMScheme._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.NTLMScheme.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", ref global::org.apache.http.impl.auth.NTLMScheme._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public NTLMScheme(org.apache.http.impl.auth.NTLMEngine arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.NTLMScheme._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.NTLMScheme._m7 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "<init>", "(Lorg/apache/http/impl/auth/NTLMEngine;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NTLMScheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.NTLMScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/NTLMScheme"));
		}
		internal static void InitJNI()
		{
		}
	}
}
