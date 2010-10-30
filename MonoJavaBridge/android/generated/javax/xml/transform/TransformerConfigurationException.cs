namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerConfigurationException : javax.xml.transform.TransformerException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransformerConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public TransformerConfigurationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._m0 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public TransformerConfigurationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._m1 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public TransformerConfigurationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._m2.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._m2 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public TransformerConfigurationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._m3.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._m3 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._m4.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._m4 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._m5.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._m5 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TransformerConfigurationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerConfigurationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
