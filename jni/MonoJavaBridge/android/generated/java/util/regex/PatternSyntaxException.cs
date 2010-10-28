namespace java.util.regex
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PatternSyntaxException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PatternSyntaxException()
		{
			InitJNI();
		}
		protected PatternSyntaxException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage28322;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException._getMessage28322)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException.staticClass, global::java.util.regex.PatternSyntaxException._getMessage28322)) as java.lang.String;
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28323;
		public virtual int getIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException._getIndex28323);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException.staticClass, global::java.util.regex.PatternSyntaxException._getIndex28323);
		}
		public new global::java.lang.String Description
		{
			get
			{
				return getDescription();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDescription28324;
		public virtual global::java.lang.String getDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException._getDescription28324)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException.staticClass, global::java.util.regex.PatternSyntaxException._getDescription28324)) as java.lang.String;
		}
		public new global::java.lang.String Pattern
		{
			get
			{
				return getPattern();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPattern28325;
		public virtual global::java.lang.String getPattern()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException._getPattern28325)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.regex.PatternSyntaxException.staticClass, global::java.util.regex.PatternSyntaxException._getPattern28325)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PatternSyntaxException28326;
		public PatternSyntaxException(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.regex.PatternSyntaxException.staticClass, global::java.util.regex.PatternSyntaxException._PatternSyntaxException28326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.PatternSyntaxException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/PatternSyntaxException"));
			global::java.util.regex.PatternSyntaxException._getMessage28322 = @__env.GetMethodIDNoThrow(global::java.util.regex.PatternSyntaxException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.regex.PatternSyntaxException._getIndex28323 = @__env.GetMethodIDNoThrow(global::java.util.regex.PatternSyntaxException.staticClass, "getIndex", "()I");
			global::java.util.regex.PatternSyntaxException._getDescription28324 = @__env.GetMethodIDNoThrow(global::java.util.regex.PatternSyntaxException.staticClass, "getDescription", "()Ljava/lang/String;");
			global::java.util.regex.PatternSyntaxException._getPattern28325 = @__env.GetMethodIDNoThrow(global::java.util.regex.PatternSyntaxException.staticClass, "getPattern", "()Ljava/lang/String;");
			global::java.util.regex.PatternSyntaxException._PatternSyntaxException28326 = @__env.GetMethodIDNoThrow(global::java.util.regex.PatternSyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
		}
	}
}
