namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Ringtone : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Ringtone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _stop7443;
		public virtual void stop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._stop7443);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._stop7443);
		}
		internal static global::MonoJavaBridge.MethodId _getTitle7444;
		public virtual global::java.lang.String getTitle(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.media.Ringtone._getTitle7444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getTitle7444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _play7445;
		public virtual void play()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._play7445);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._play7445);
		}
		public new int StreamType
		{
			get
			{
				return getStreamType();
			}
			set
			{
				setStreamType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStreamType7446;
		public virtual int getStreamType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.Ringtone._getStreamType7446);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getStreamType7446);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying7447;
		public virtual bool isPlaying()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.Ringtone._isPlaying7447);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._isPlaying7447);
		}
		internal static global::MonoJavaBridge.MethodId _setStreamType7448;
		public virtual void setStreamType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._setStreamType7448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._setStreamType7448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Ringtone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.Ringtone.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/Ringtone"));
			global::android.media.Ringtone._stop7443 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "stop", "()V");
			global::android.media.Ringtone._getTitle7444 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "getTitle", "(Landroid/content/Context;)Ljava/lang/String;");
			global::android.media.Ringtone._play7445 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "play", "()V");
			global::android.media.Ringtone._getStreamType7446 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "getStreamType", "()I");
			global::android.media.Ringtone._isPlaying7447 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "isPlaying", "()Z");
			global::android.media.Ringtone._setStreamType7448 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "setStreamType", "(I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}