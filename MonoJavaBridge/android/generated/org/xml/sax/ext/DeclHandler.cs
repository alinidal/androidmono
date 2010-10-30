namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.DeclHandler_))]
	public partial interface DeclHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void elementDecl(java.lang.String arg0, java.lang.String arg1);
		void attributeDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4);
		void internalEntityDecl(java.lang.String arg0, java.lang.String arg1);
		void externalEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.DeclHandler))]
	internal sealed partial class DeclHandler_ : java.lang.Object, DeclHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DeclHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.xml.sax.ext.DeclHandler.elementDecl(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DeclHandler_.staticClass, "elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DeclHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.xml.sax.ext.DeclHandler.attributeDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DeclHandler_.staticClass, "attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DeclHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.xml.sax.ext.DeclHandler.internalEntityDecl(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DeclHandler_.staticClass, "internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DeclHandler_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.xml.sax.ext.DeclHandler.externalEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DeclHandler_.staticClass, "externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DeclHandler_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static DeclHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.DeclHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/DeclHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
