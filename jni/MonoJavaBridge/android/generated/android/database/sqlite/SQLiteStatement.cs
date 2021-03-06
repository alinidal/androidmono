namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteStatement : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteStatement()
		{
			InitJNI();
		}
		protected SQLiteStatement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute2929;
		public virtual void execute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement._execute2929);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._execute2929);
		}
		internal static global::MonoJavaBridge.MethodId _executeInsert2930;
		public virtual long executeInsert() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement._executeInsert2930);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._executeInsert2930);
		}
		internal static global::MonoJavaBridge.MethodId _simpleQueryForLong2931;
		public virtual long simpleQueryForLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement._simpleQueryForLong2931);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._simpleQueryForLong2931);
		}
		internal static global::MonoJavaBridge.MethodId _simpleQueryForString2932;
		public virtual global::java.lang.String simpleQueryForString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement._simpleQueryForString2932)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._simpleQueryForString2932)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteStatement.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteStatement"));
			global::android.database.sqlite.SQLiteStatement._execute2929 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "execute", "()V");
			global::android.database.sqlite.SQLiteStatement._executeInsert2930 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "executeInsert", "()J");
			global::android.database.sqlite.SQLiteStatement._simpleQueryForLong2931 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForLong", "()J");
			global::android.database.sqlite.SQLiteStatement._simpleQueryForString2932 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForString", "()Ljava/lang/String;");
		}
	}
}
