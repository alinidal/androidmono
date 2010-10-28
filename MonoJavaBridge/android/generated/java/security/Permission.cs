namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Permission_))]
	public abstract partial class Permission : java.lang.Object, Guard, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Permission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23202;
		public abstract bool equals(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _toString23203;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Permission._toString23203)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Permission.staticClass, global::java.security.Permission._toString23203)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23204;
		public abstract int hashCode();
		internal static global::MonoJavaBridge.MethodId _getName23205;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Permission._getName23205)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Permission.staticClass, global::java.security.Permission._getName23205)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _implies23206;
		public abstract bool implies(java.security.Permission arg0);
		internal static global::MonoJavaBridge.MethodId _getActions23207;
		public abstract global::java.lang.String getActions();
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection23208;
		public virtual global::java.security.PermissionCollection newPermissionCollection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Permission._newPermissionCollection23208)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Permission.staticClass, global::java.security.Permission._newPermissionCollection23208)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _checkGuard23209;
		public virtual void checkGuard(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Permission._checkGuard23209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Permission.staticClass, global::java.security.Permission._checkGuard23209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Permission23210;
		public Permission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Permission.staticClass, global::java.security.Permission._Permission23210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Permission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Permission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Permission"));
			global::java.security.Permission._equals23202 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Permission._toString23203 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Permission._hashCode23204 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "hashCode", "()I");
			global::java.security.Permission._getName23205 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Permission._implies23206 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.Permission._getActions23207 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.security.Permission._newPermissionCollection23208 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.security.Permission._checkGuard23209 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "checkGuard", "(Ljava/lang/Object;)V");
			global::java.security.Permission._Permission23210 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Permission))]
	internal sealed partial class Permission_ : java.security.Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Permission_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23211;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Permission_._equals23211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Permission_.staticClass, global::java.security.Permission_._equals23211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23212;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.Permission_._hashCode23212);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.Permission_.staticClass, global::java.security.Permission_._hashCode23212);
		}
		internal static global::MonoJavaBridge.MethodId _implies23213;
		public override bool implies(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Permission_._implies23213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Permission_.staticClass, global::java.security.Permission_._implies23213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActions23214;
		public override global::java.lang.String getActions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Permission_._getActions23214)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Permission_.staticClass, global::java.security.Permission_._getActions23214)) as java.lang.String;
		}
		static Permission_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Permission_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Permission"));
			global::java.security.Permission_._equals23211 = @__env.GetMethodIDNoThrow(global::java.security.Permission_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Permission_._hashCode23212 = @__env.GetMethodIDNoThrow(global::java.security.Permission_.staticClass, "hashCode", "()I");
			global::java.security.Permission_._implies23213 = @__env.GetMethodIDNoThrow(global::java.security.Permission_.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.Permission_._getActions23214 = @__env.GetMethodIDNoThrow(global::java.security.Permission_.staticClass, "getActions", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}