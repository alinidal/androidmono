namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackgroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackgroundColorSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13442;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._writeToParcel13442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._writeToParcel13442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13443;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._describeContents13443);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._describeContents13443);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13444;
		public virtual int getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._getSpanTypeId13444);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._getSpanTypeId13444);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13445;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._updateDrawState13445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._updateDrawState13445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BackgroundColor
		{
			get
			{
				return getBackgroundColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackgroundColor13446;
		public virtual int getBackgroundColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._getBackgroundColor13446);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._getBackgroundColor13446);
		}
		internal static global::MonoJavaBridge.MethodId _BackgroundColorSpan13447;
		public BackgroundColorSpan(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._BackgroundColorSpan13447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BackgroundColorSpan13448;
		public BackgroundColorSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._BackgroundColorSpan13448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BackgroundColorSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.BackgroundColorSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/BackgroundColorSpan"));
			global::android.text.style.BackgroundColorSpan._writeToParcel13442 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.BackgroundColorSpan._describeContents13443 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "describeContents", "()I");
			global::android.text.style.BackgroundColorSpan._getSpanTypeId13444 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.BackgroundColorSpan._updateDrawState13445 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.BackgroundColorSpan._getBackgroundColor13446 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "getBackgroundColor", "()I");
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan13447 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan13448 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}