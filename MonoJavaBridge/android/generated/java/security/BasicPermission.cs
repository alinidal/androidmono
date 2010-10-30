namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.BasicPermission_))]
	public abstract partial class BasicPermission : java.security.Permission, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.BasicPermission.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.BasicPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.BasicPermission.staticClass, "hashCode", "()I", ref global::java.security.BasicPermission._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.BasicPermission.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.BasicPermission._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String getActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.BasicPermission.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.security.BasicPermission._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.BasicPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.security.BasicPermission._m4) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public BasicPermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.BasicPermission._m5.native == global::System.IntPtr.Zero)
				global::java.security.BasicPermission._m5 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.BasicPermission.staticClass, global::java.security.BasicPermission._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public BasicPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.BasicPermission._m6.native == global::System.IntPtr.Zero)
				global::java.security.BasicPermission._m6 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.BasicPermission.staticClass, global::java.security.BasicPermission._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.BasicPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/BasicPermission"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.BasicPermission))]
	internal sealed partial class BasicPermission_ : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BasicPermission_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static BasicPermission_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.BasicPermission_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/BasicPermission"));
		}
		internal static void InitJNI()
		{
		}
	}
}
