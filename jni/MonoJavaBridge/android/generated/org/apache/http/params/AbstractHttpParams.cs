namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.@params.AbstractHttpParams_))]
	public abstract partial class AbstractHttpParams : java.lang.Object, HttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpParams()
		{
			InitJNI();
		}
		protected AbstractHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy33714;
		public abstract global::org.apache.http.@params.HttpParams copy();
		internal static global::MonoJavaBridge.MethodId _setParameter33715;
		public abstract global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _getParameter33716;
		public abstract global::java.lang.Object getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removeParameter33717;
		public abstract bool removeParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getLongParameter33718;
		public virtual long getLongParameter(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getLongParameter33718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getLongParameter33718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLongParameter33719;
		public virtual global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setLongParameter33719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setLongParameter33719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getIntParameter33720;
		public virtual int getIntParameter(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getIntParameter33720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getIntParameter33720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIntParameter33721;
		public virtual global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setIntParameter33721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setIntParameter33721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleParameter33722;
		public virtual double getDoubleParameter(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getDoubleParameter33722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getDoubleParameter33722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDoubleParameter33723;
		public virtual global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setDoubleParameter33723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setDoubleParameter33723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanParameter33724;
		public virtual bool getBooleanParameter(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._getBooleanParameter33724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._getBooleanParameter33724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBooleanParameter33725;
		public virtual global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._setBooleanParameter33725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._setBooleanParameter33725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _isParameterTrue33726;
		public virtual bool isParameterTrue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._isParameterTrue33726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._isParameterTrue33726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterFalse33727;
		public virtual bool isParameterFalse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams._isParameterFalse33727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._isParameterFalse33727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpParams33728;
		protected AbstractHttpParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.AbstractHttpParams.staticClass, global::org.apache.http.@params.AbstractHttpParams._AbstractHttpParams33728);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.AbstractHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/AbstractHttpParams"));
			global::org.apache.http.@params.AbstractHttpParams._copy33714 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._setParameter33715 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getParameter33716 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.AbstractHttpParams._removeParameter33717 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.AbstractHttpParams._getLongParameter33718 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getLongParameter", "(Ljava/lang/String;J)J");
			global::org.apache.http.@params.AbstractHttpParams._setLongParameter33719 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getIntParameter33720 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getIntParameter", "(Ljava/lang/String;I)I");
			global::org.apache.http.@params.AbstractHttpParams._setIntParameter33721 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getDoubleParameter33722 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getDoubleParameter", "(Ljava/lang/String;D)D");
			global::org.apache.http.@params.AbstractHttpParams._setDoubleParameter33723 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._getBooleanParameter33724 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "getBooleanParameter", "(Ljava/lang/String;Z)Z");
			global::org.apache.http.@params.AbstractHttpParams._setBooleanParameter33725 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams._isParameterTrue33726 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterTrue", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.AbstractHttpParams._isParameterFalse33727 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "isParameterFalse", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.AbstractHttpParams._AbstractHttpParams33728 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.AbstractHttpParams))]
	internal sealed partial class AbstractHttpParams_ : org.apache.http.@params.AbstractHttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractHttpParams_()
		{
			InitJNI();
		}
		internal AbstractHttpParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy33729;
		public override global::org.apache.http.@params.HttpParams copy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._copy33729)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._copy33729)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter33730;
		public override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._setParameter33730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._setParameter33730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33731;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._getParameter33731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._getParameter33731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter33732;
		public override bool removeParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_._removeParameter33732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.AbstractHttpParams_.staticClass, global::org.apache.http.@params.AbstractHttpParams_._removeParameter33732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.AbstractHttpParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/AbstractHttpParams"));
			global::org.apache.http.@params.AbstractHttpParams_._copy33729 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams_._setParameter33730 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.AbstractHttpParams_._getParameter33731 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.AbstractHttpParams_._removeParameter33732 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.AbstractHttpParams_.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
		}
	}
}
