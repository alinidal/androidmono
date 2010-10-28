namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathPermission : android.os.PatternMatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3977;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PathPermission._writeToParcel3977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._writeToParcel3977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String ReadPermission
		{
			get
			{
				return getReadPermission();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadPermission3978;
		public virtual global::java.lang.String getReadPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission._getReadPermission3978)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._getReadPermission3978)) as java.lang.String;
		}
		public new global::java.lang.String WritePermission
		{
			get
			{
				return getWritePermission();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWritePermission3979;
		public virtual global::java.lang.String getWritePermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission._getWritePermission3979)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._getWritePermission3979)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PathPermission3980;
		public PathPermission(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._PathPermission3980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PathPermission3981;
		public PathPermission(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._PathPermission3981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3982;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PathPermission.staticClass, _CREATOR3982)) as android.os.Parcelable_Creator;
			}
		}
		static PathPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PathPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PathPermission"));
			global::android.content.pm.PathPermission._writeToParcel3977 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PathPermission._getReadPermission3978 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "getReadPermission", "()Ljava/lang/String;");
			global::android.content.pm.PathPermission._getWritePermission3979 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "getWritePermission", "()Ljava/lang/String;");
			global::android.content.pm.PathPermission._PathPermission3980 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::android.content.pm.PathPermission._PathPermission3981 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.PathPermission._CREATOR3982 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PathPermission.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}