namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatWidthException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalFormatWidthException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26325;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException._getMessage26325)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException.staticClass, global::java.util.IllegalFormatWidthException._getMessage26325)) as java.lang.String;
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth26326;
		public virtual int getWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException._getWidth26326);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException.staticClass, global::java.util.IllegalFormatWidthException._getWidth26326);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalFormatWidthException26327;
		public IllegalFormatWidthException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatWidthException.staticClass, global::java.util.IllegalFormatWidthException._IllegalFormatWidthException26327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalFormatWidthException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatWidthException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatWidthException"));
			global::java.util.IllegalFormatWidthException._getMessage26325 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatWidthException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.IllegalFormatWidthException._getWidth26326 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatWidthException.staticClass, "getWidth", "()I");
			global::java.util.IllegalFormatWidthException._IllegalFormatWidthException26327 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatWidthException.staticClass, "<init>", "(I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}