namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalSelectorException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalSelectorException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalSelectorException22509;
		public IllegalSelectorException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.IllegalSelectorException.staticClass, global::java.nio.channels.IllegalSelectorException._IllegalSelectorException22509);
			Init(@__env, handle);
		}
		static IllegalSelectorException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.IllegalSelectorException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/IllegalSelectorException"));
			global::java.nio.channels.IllegalSelectorException._IllegalSelectorException22509 = @__env.GetMethodIDNoThrow(global::java.nio.channels.IllegalSelectorException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}