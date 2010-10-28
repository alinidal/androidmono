namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthState : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthState()
		{
			InitJNI();
		}
		protected AuthState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString31808;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._toString31808)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._toString31808)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isValid31809;
		public virtual bool isValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._isValid31809);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._isValid31809);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate31810;
		public virtual void invalidate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._invalidate31810);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._invalidate31810);
		}
		public new global::org.apache.http.auth.AuthScheme AuthScheme
		{
			get
			{
				return getAuthScheme();
			}
			set
			{
				setAuthScheme(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthScheme31811;
		public virtual global::org.apache.http.auth.AuthScheme getAuthScheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._getAuthScheme31811)) as org.apache.http.auth.AuthScheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._getAuthScheme31811)) as org.apache.http.auth.AuthScheme;
		}
		internal static global::MonoJavaBridge.MethodId _setAuthScheme31812;
		public virtual void setAuthScheme(org.apache.http.auth.AuthScheme arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._setAuthScheme31812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._setAuthScheme31812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.auth.Credentials Credentials
		{
			get
			{
				return getCredentials();
			}
			set
			{
				setCredentials(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCredentials31813;
		public virtual global::org.apache.http.auth.Credentials getCredentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.Credentials>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._getCredentials31813)) as org.apache.http.auth.Credentials;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.Credentials>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._getCredentials31813)) as org.apache.http.auth.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _setCredentials31814;
		public virtual void setCredentials(org.apache.http.auth.Credentials arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._setCredentials31814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._setCredentials31814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.auth.AuthScope AuthScope
		{
			get
			{
				return getAuthScope();
			}
			set
			{
				setAuthScope(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthScope31815;
		public virtual global::org.apache.http.auth.AuthScope getAuthScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._getAuthScope31815)) as org.apache.http.auth.AuthScope;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._getAuthScope31815)) as org.apache.http.auth.AuthScope;
		}
		internal static global::MonoJavaBridge.MethodId _setAuthScope31816;
		public virtual void setAuthScope(org.apache.http.auth.AuthScope arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState._setAuthScope31816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._setAuthScope31816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AuthState31817;
		public AuthState() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._AuthState31817);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthState.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthState"));
			global::org.apache.http.auth.AuthState._toString31808 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthState._isValid31809 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "isValid", "()Z");
			global::org.apache.http.auth.AuthState._invalidate31810 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "invalidate", "()V");
			global::org.apache.http.auth.AuthState._getAuthScheme31811 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "getAuthScheme", "()Lorg/apache/http/auth/AuthScheme;");
			global::org.apache.http.auth.AuthState._setAuthScheme31812 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "setAuthScheme", "(Lorg/apache/http/auth/AuthScheme;)V");
			global::org.apache.http.auth.AuthState._getCredentials31813 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "getCredentials", "()Lorg/apache/http/auth/Credentials;");
			global::org.apache.http.auth.AuthState._setCredentials31814 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "setCredentials", "(Lorg/apache/http/auth/Credentials;)V");
			global::org.apache.http.auth.AuthState._getAuthScope31815 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "getAuthScope", "()Lorg/apache/http/auth/AuthScope;");
			global::org.apache.http.auth.AuthState._setAuthScope31816 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "setAuthScope", "(Lorg/apache/http/auth/AuthScope;)V");
			global::org.apache.http.auth.AuthState._AuthState31817 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "<init>", "()V");
		}
	}
}
