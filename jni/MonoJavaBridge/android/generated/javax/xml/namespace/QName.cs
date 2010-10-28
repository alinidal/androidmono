namespace javax.xml.@namespace
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class QName : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static QName()
		{
			InitJNI();
		}
		protected QName(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30822;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.@namespace.QName._equals30822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._equals30822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30823;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName._toString30823)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._toString30823)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30824;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.@namespace.QName._hashCode30824);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._hashCode30824);
		}
		internal static global::MonoJavaBridge.MethodId _valueOf30825;
		public static global::javax.xml.@namespace.QName valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._valueOf30825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.@namespace.QName;
		}
		public new global::java.lang.String Prefix
		{
			get
			{
				return getPrefix();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix30826;
		public virtual global::java.lang.String getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName._getPrefix30826)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._getPrefix30826)) as java.lang.String;
		}
		public new global::java.lang.String NamespaceURI
		{
			get
			{
				return getNamespaceURI();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI30827;
		public virtual global::java.lang.String getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName._getNamespaceURI30827)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._getNamespaceURI30827)) as java.lang.String;
		}
		public new global::java.lang.String LocalPart
		{
			get
			{
				return getLocalPart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPart30828;
		public virtual global::java.lang.String getLocalPart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName._getLocalPart30828)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._getLocalPart30828)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _QName30829;
		public QName(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._QName30829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QName30830;
		public QName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._QName30830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QName30831;
		public QName(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.@namespace.QName.staticClass, global::javax.xml.@namespace.QName._QName30831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.@namespace.QName.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/namespace/QName"));
			global::javax.xml.@namespace.QName._equals30822 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.xml.@namespace.QName._toString30823 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.xml.@namespace.QName._hashCode30824 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "hashCode", "()I");
			global::javax.xml.@namespace.QName._valueOf30825 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/xml/namespace/QName;");
			global::javax.xml.@namespace.QName._getPrefix30826 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::javax.xml.@namespace.QName._getNamespaceURI30827 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::javax.xml.@namespace.QName._getLocalPart30828 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "getLocalPart", "()Ljava/lang/String;");
			global::javax.xml.@namespace.QName._QName30829 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.@namespace.QName._QName30830 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.xml.@namespace.QName._QName30831 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.QName.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
