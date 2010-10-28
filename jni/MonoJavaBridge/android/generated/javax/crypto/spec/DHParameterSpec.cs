namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DHParameterSpec()
		{
			InitJNI();
		}
		protected DHParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getP28770;
		public virtual global::java.math.BigInteger getP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHParameterSpec._getP28770)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHParameterSpec.staticClass, global::javax.crypto.spec.DHParameterSpec._getP28770)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG28771;
		public virtual global::java.math.BigInteger getG()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHParameterSpec._getG28771)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHParameterSpec.staticClass, global::javax.crypto.spec.DHParameterSpec._getG28771)) as java.math.BigInteger;
		}
		public new int L
		{
			get
			{
				return getL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getL28772;
		public virtual int getL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.DHParameterSpec._getL28772);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.DHParameterSpec.staticClass, global::javax.crypto.spec.DHParameterSpec._getL28772);
		}
		internal static global::MonoJavaBridge.MethodId _DHParameterSpec28773;
		public DHParameterSpec(java.math.BigInteger arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHParameterSpec.staticClass, global::javax.crypto.spec.DHParameterSpec._DHParameterSpec28773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DHParameterSpec28774;
		public DHParameterSpec(java.math.BigInteger arg0, java.math.BigInteger arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHParameterSpec.staticClass, global::javax.crypto.spec.DHParameterSpec._DHParameterSpec28774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHParameterSpec"));
			global::javax.crypto.spec.DHParameterSpec._getP28770 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHParameterSpec.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHParameterSpec._getG28771 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHParameterSpec.staticClass, "getG", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHParameterSpec._getL28772 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHParameterSpec.staticClass, "getL", "()I");
			global::javax.crypto.spec.DHParameterSpec._DHParameterSpec28773 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHParameterSpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::javax.crypto.spec.DHParameterSpec._DHParameterSpec28774 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHParameterSpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;I)V");
		}
	}
}
