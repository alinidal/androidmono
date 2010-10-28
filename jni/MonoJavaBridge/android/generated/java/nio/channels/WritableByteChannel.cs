namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.WritableByteChannel_))]
	public partial interface WritableByteChannel : Channel
	{
		int write(java.nio.ByteBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.WritableByteChannel))]
	internal sealed partial class WritableByteChannel_ : java.lang.Object, WritableByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WritableByteChannel_()
		{
			InitJNI();
		}
		internal WritableByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22657;
		int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_._write22657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_.staticClass, global::java.nio.channels.WritableByteChannel_._write22657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22658;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_._close22658);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_.staticClass, global::java.nio.channels.WritableByteChannel_._close22658);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22659;
		bool java.nio.channels.Channel.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_._isOpen22659);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_.staticClass, global::java.nio.channels.WritableByteChannel_._isOpen22659);
		}
		internal static global::MonoJavaBridge.MethodId _close22660;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_._close22660);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.WritableByteChannel_.staticClass, global::java.nio.channels.WritableByteChannel_._close22660);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.WritableByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/WritableByteChannel"));
			global::java.nio.channels.WritableByteChannel_._write22657 = @__env.GetMethodIDNoThrow(global::java.nio.channels.WritableByteChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.WritableByteChannel_._close22658 = @__env.GetMethodIDNoThrow(global::java.nio.channels.WritableByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.WritableByteChannel_._isOpen22659 = @__env.GetMethodIDNoThrow(global::java.nio.channels.WritableByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.WritableByteChannel_._close22660 = @__env.GetMethodIDNoThrow(global::java.nio.channels.WritableByteChannel_.staticClass, "close", "()V");
		}
	}
}
