namespace java.security.acl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LastOwnerException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LastOwnerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LastOwnerException23460;
		public LastOwnerException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.acl.LastOwnerException.staticClass, global::java.security.acl.LastOwnerException._LastOwnerException23460);
			Init(@__env, handle);
		}
		static LastOwnerException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.LastOwnerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/LastOwnerException"));
			global::java.security.acl.LastOwnerException._LastOwnerException23460 = @__env.GetMethodIDNoThrow(global::java.security.acl.LastOwnerException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}