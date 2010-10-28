namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StrictMath : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StrictMath()
		{
			InitJNI();
		}
		internal StrictMath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abs20542;
		public static long abs(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20543;
		public static double abs(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20544;
		public static float abs(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20545;
		public static int abs(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sin20546;
		public static double sin(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sin20546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos20547;
		public static double cos(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cos20547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tan20548;
		public static double tan(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._tan20548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan220549;
		public static double atan2(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._atan220549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt20550;
		public static double sqrt(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sqrt20550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log20551;
		public static double log(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log20551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1020552;
		public static double log10(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log1020552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pow20553;
		public static double pow(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._pow20553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _exp20554;
		public static double exp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._exp20554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _min20555;
		public static double min(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20556;
		public static float min(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20557;
		public static long min(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20558;
		public static int min(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20559;
		public static float max(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20560;
		public static long max(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20561;
		public static int max(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20562;
		public static double max(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20563;
		public static float scalb(float arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._scalb20563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20564;
		public static double scalb(double arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._scalb20564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20565;
		public static int getExponent(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._getExponent20565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20566;
		public static int getExponent(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._getExponent20566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20567;
		public static float signum(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._signum20567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20568;
		public static double signum(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._signum20568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _asin20569;
		public static double asin(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._asin20569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acos20570;
		public static double acos(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._acos20570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan20571;
		public static double atan(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._atan20571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toRadians20572;
		public static double toRadians(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._toRadians20572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDegrees20573;
		public static double toDegrees(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._toDegrees20573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cbrt20574;
		public static double cbrt(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cbrt20574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IEEEremainder20575;
		public static double IEEEremainder(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._IEEEremainder20575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ceil20576;
		public static double ceil(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ceil20576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor20577;
		public static double floor(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._floor20577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rint20578;
		public static double rint(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._rint20578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20579;
		public static int round(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._round20579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20580;
		public static long round(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._round20580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _random20581;
		public static double random()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._random20581);
		}
		internal static global::MonoJavaBridge.MethodId _ulp20582;
		public static double ulp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ulp20582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ulp20583;
		public static float ulp(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ulp20583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sinh20584;
		public static double sinh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sinh20584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cosh20585;
		public static double cosh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cosh20585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tanh20586;
		public static double tanh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._tanh20586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hypot20587;
		public static double hypot(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._hypot20587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _expm120588;
		public static double expm1(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._expm120588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1p20589;
		public static double log1p(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log1p20589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20590;
		public static float copySign(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._copySign20590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20591;
		public static double copySign(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._copySign20591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20592;
		public static double nextAfter(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextAfter20592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20593;
		public static float nextAfter(float arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextAfter20593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20594;
		public static float nextUp(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextUp20594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20595;
		public static double nextUp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextUp20595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static double E
		{
			get
			{
				return 2.718281828459045;
			}
		}
		public static double PI
		{
			get
			{
				return 3.141592653589793;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StrictMath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StrictMath"));
			global::java.lang.StrictMath._abs20542 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(J)J");
			global::java.lang.StrictMath._abs20543 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(D)D");
			global::java.lang.StrictMath._abs20544 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(F)F");
			global::java.lang.StrictMath._abs20545 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(I)I");
			global::java.lang.StrictMath._sin20546 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sin", "(D)D");
			global::java.lang.StrictMath._cos20547 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cos", "(D)D");
			global::java.lang.StrictMath._tan20548 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "tan", "(D)D");
			global::java.lang.StrictMath._atan220549 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "atan2", "(DD)D");
			global::java.lang.StrictMath._sqrt20550 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sqrt", "(D)D");
			global::java.lang.StrictMath._log20551 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log", "(D)D");
			global::java.lang.StrictMath._log1020552 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log10", "(D)D");
			global::java.lang.StrictMath._pow20553 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "pow", "(DD)D");
			global::java.lang.StrictMath._exp20554 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "exp", "(D)D");
			global::java.lang.StrictMath._min20555 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(DD)D");
			global::java.lang.StrictMath._min20556 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(FF)F");
			global::java.lang.StrictMath._min20557 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(JJ)J");
			global::java.lang.StrictMath._min20558 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(II)I");
			global::java.lang.StrictMath._max20559 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(FF)F");
			global::java.lang.StrictMath._max20560 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(JJ)J");
			global::java.lang.StrictMath._max20561 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(II)I");
			global::java.lang.StrictMath._max20562 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(DD)D");
			global::java.lang.StrictMath._scalb20563 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "scalb", "(FI)F");
			global::java.lang.StrictMath._scalb20564 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "scalb", "(DI)D");
			global::java.lang.StrictMath._getExponent20565 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "getExponent", "(D)I");
			global::java.lang.StrictMath._getExponent20566 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "getExponent", "(F)I");
			global::java.lang.StrictMath._signum20567 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "signum", "(F)F");
			global::java.lang.StrictMath._signum20568 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "signum", "(D)D");
			global::java.lang.StrictMath._asin20569 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "asin", "(D)D");
			global::java.lang.StrictMath._acos20570 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "acos", "(D)D");
			global::java.lang.StrictMath._atan20571 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "atan", "(D)D");
			global::java.lang.StrictMath._toRadians20572 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "toRadians", "(D)D");
			global::java.lang.StrictMath._toDegrees20573 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "toDegrees", "(D)D");
			global::java.lang.StrictMath._cbrt20574 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cbrt", "(D)D");
			global::java.lang.StrictMath._IEEEremainder20575 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "IEEEremainder", "(DD)D");
			global::java.lang.StrictMath._ceil20576 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ceil", "(D)D");
			global::java.lang.StrictMath._floor20577 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "floor", "(D)D");
			global::java.lang.StrictMath._rint20578 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "rint", "(D)D");
			global::java.lang.StrictMath._round20579 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "round", "(F)I");
			global::java.lang.StrictMath._round20580 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "round", "(D)J");
			global::java.lang.StrictMath._random20581 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "random", "()D");
			global::java.lang.StrictMath._ulp20582 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ulp", "(D)D");
			global::java.lang.StrictMath._ulp20583 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ulp", "(F)F");
			global::java.lang.StrictMath._sinh20584 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sinh", "(D)D");
			global::java.lang.StrictMath._cosh20585 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cosh", "(D)D");
			global::java.lang.StrictMath._tanh20586 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "tanh", "(D)D");
			global::java.lang.StrictMath._hypot20587 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "hypot", "(DD)D");
			global::java.lang.StrictMath._expm120588 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "expm1", "(D)D");
			global::java.lang.StrictMath._log1p20589 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log1p", "(D)D");
			global::java.lang.StrictMath._copySign20590 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "copySign", "(FF)F");
			global::java.lang.StrictMath._copySign20591 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "copySign", "(DD)D");
			global::java.lang.StrictMath._nextAfter20592 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextAfter", "(DD)D");
			global::java.lang.StrictMath._nextAfter20593 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextAfter", "(FD)F");
			global::java.lang.StrictMath._nextUp20594 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextUp", "(F)F");
			global::java.lang.StrictMath._nextUp20595 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextUp", "(D)D");
		}
	}
}
