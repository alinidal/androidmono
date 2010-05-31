namespace android.gesture
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class OrientedBoundingBox : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static OrientedBoundingBox()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.OrientedBoundingBox), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.gesture.OrientedBoundingBox(@__env);
			}
		}
		protected OrientedBoundingBox(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.FieldId _squareness2692;
		public float squareness
		{
			get
			{
				return default(float);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _width2693;
		public float width
		{
			get
			{
				return default(float);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _height2694;
		public float height
		{
			get
			{
				return default(float);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _orientation2695;
		public float orientation
		{
			get
			{
				return default(float);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _centerX2696;
		public float centerX
		{
			get
			{
				return default(float);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _centerY2697;
		public float centerY
		{
			get
			{
				return default(float);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.gesture.OrientedBoundingBox.staticClass = @__class;
		}
	}
}