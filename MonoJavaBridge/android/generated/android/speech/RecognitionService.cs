namespace android.speech
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.speech.RecognitionService_))]
	public abstract partial class RecognitionService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RecognitionService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Callback : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Callback(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _error11655;
			public virtual void error(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._error11655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._error11655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _results11656;
			public virtual void results(android.os.Bundle arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._results11656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._results11656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _beginningOfSpeech11657;
			public virtual void beginningOfSpeech()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._beginningOfSpeech11657);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._beginningOfSpeech11657);
			}
			internal static global::MonoJavaBridge.MethodId _bufferReceived11658;
			public virtual void bufferReceived(byte[] arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._bufferReceived11658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._bufferReceived11658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _endOfSpeech11659;
			public virtual void endOfSpeech()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._endOfSpeech11659);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._endOfSpeech11659);
			}
			internal static global::MonoJavaBridge.MethodId _partialResults11660;
			public virtual void partialResults(android.os.Bundle arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._partialResults11660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._partialResults11660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _readyForSpeech11661;
			public virtual void readyForSpeech(android.os.Bundle arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._readyForSpeech11661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._readyForSpeech11661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _rmsChanged11662;
			public virtual void rmsChanged(float arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback._rmsChanged11662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._rmsChanged11662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Callback()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.RecognitionService.Callback.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService$Callback"));
				global::android.speech.RecognitionService.Callback._error11655 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "error", "(I)V");
				global::android.speech.RecognitionService.Callback._results11656 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "results", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._beginningOfSpeech11657 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "beginningOfSpeech", "()V");
				global::android.speech.RecognitionService.Callback._bufferReceived11658 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "bufferReceived", "([B)V");
				global::android.speech.RecognitionService.Callback._endOfSpeech11659 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "endOfSpeech", "()V");
				global::android.speech.RecognitionService.Callback._partialResults11660 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "partialResults", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._readyForSpeech11661 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "readyForSpeech", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._rmsChanged11662 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.Callback.staticClass, "rmsChanged", "(F)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onBind11663;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.speech.RecognitionService._onBind11663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._onBind11663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy11664;
		public override void onDestroy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService._onDestroy11664);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._onDestroy11664);
		}
		internal static global::MonoJavaBridge.MethodId _onCancel11665;
		protected abstract void onCancel(android.speech.RecognitionService.Callback arg0);
		internal static global::MonoJavaBridge.MethodId _onStartListening11666;
		protected abstract void onStartListening(android.content.Intent arg0, android.speech.RecognitionService.Callback arg1);
		internal static global::MonoJavaBridge.MethodId _onStopListening11667;
		protected abstract void onStopListening(android.speech.RecognitionService.Callback arg0);
		internal static global::MonoJavaBridge.MethodId _RecognitionService11668;
		public RecognitionService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._RecognitionService11668);
			Init(@__env, handle);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.speech.RecognitionService";
			}
		}
		public static global::java.lang.String SERVICE_META_DATA
		{
			get
			{
				return "android.speech";
			}
		}
		static RecognitionService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService"));
			global::android.speech.RecognitionService._onBind11663 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.speech.RecognitionService._onDestroy11664 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onDestroy", "()V");
			global::android.speech.RecognitionService._onCancel11665 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onCancel", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._onStartListening11666 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._onStopListening11667 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "onStopListening", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._RecognitionService11668 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.RecognitionService))]
	internal sealed partial class RecognitionService_ : android.speech.RecognitionService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RecognitionService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCancel11671;
		protected override void onCancel(android.speech.RecognitionService.Callback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_._onCancel11671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_.staticClass, global::android.speech.RecognitionService_._onCancel11671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStartListening11672;
		protected override void onStartListening(android.content.Intent arg0, android.speech.RecognitionService.Callback arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_._onStartListening11672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_.staticClass, global::android.speech.RecognitionService_._onStartListening11672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onStopListening11673;
		protected override void onStopListening(android.speech.RecognitionService.Callback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_._onStopListening11673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionService_.staticClass, global::android.speech.RecognitionService_._onStopListening11673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RecognitionService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService"));
			global::android.speech.RecognitionService_._onCancel11671 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService_.staticClass, "onCancel", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService_._onStartListening11672 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService_.staticClass, "onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService_._onStopListening11673 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService_.staticClass, "onStopListening", "(Landroid/speech/RecognitionService$Callback;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}