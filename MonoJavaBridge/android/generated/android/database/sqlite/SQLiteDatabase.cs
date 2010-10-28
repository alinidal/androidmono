namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDatabase : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteDatabase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteDatabase.CursorFactory_))]
		public partial interface CursorFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteDatabase.CursorFactory))]
		internal sealed partial class CursorFactory_ : java.lang.Object, CursorFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal CursorFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newCursor4733;
			global::android.database.Cursor android.database.sqlite.SQLiteDatabase.CursorFactory.newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.CursorFactory_._newCursor4733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass, global::android.database.sqlite.SQLiteDatabase.CursorFactory_._newCursor4733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
			}
			static CursorFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase$CursorFactory"));
				global::android.database.sqlite.SQLiteDatabase.CursorFactory_._newCursor4733 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass, "newCursor", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)Landroid/database/Cursor;");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate android.database.Cursor CursorFactoryDelegate(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3);

		internal partial class CursorFactoryDelegateWrapper : java.lang.Object, CursorFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CursorFactoryDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _CursorFactoryDelegateWrapper4734;
			public CursorFactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper.staticClass, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper._CursorFactoryDelegateWrapper4734);
				Init(@__env, handle);
			}
			static CursorFactoryDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase_CursorFactoryDelegateWrapper"));
				global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper._CursorFactoryDelegateWrapper4734 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class CursorFactoryDelegateWrapper
		{
			private CursorFactoryDelegate myDelegate;
			public android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3)
			{
				return myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator CursorFactoryDelegateWrapper(CursorFactoryDelegate d)
			{
				global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper ret = new global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4735;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._finalize4735);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._finalize4735);
		}
		internal static global::MonoJavaBridge.MethodId _replace4736;
		public virtual long replace(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._replace4736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._replace4736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close4737;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._close4737);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._close4737);
		}
		internal static global::MonoJavaBridge.MethodId _delete4738;
		public virtual int delete(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._delete4738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._delete4738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert4739;
		public virtual long insert(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._insert4739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insert4739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly4740;
		public virtual bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isReadOnly4740);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isReadOnly4740);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath4741;
		public virtual global::java.lang.String getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getPath4741)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getPath4741)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _query4742;
		public virtual global::android.database.Cursor query(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._query4742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query4742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _query4743;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._query4743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query4743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _query4744;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._query4744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query4744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _create4745;
		public static global::android.database.sqlite.SQLiteDatabase create(android.database.sqlite.SQLiteDatabase.CursorFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._create4745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase create(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0)
		{
			return create((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen4746;
		public virtual bool isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isOpen4746);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isOpen4746);
		}
		internal static global::MonoJavaBridge.MethodId _update4747;
		public virtual int update(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._update4747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._update4747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
			set
			{
				setVersion(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion4748;
		public virtual int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getVersion4748);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getVersion4748);
		}
		internal static global::MonoJavaBridge.MethodId _setVersion4749;
		public virtual void setVersion(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setVersion4749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setVersion4749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Locale Locale
		{
			set
			{
				setLocale(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLocale4750;
		public virtual void setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setLocale4750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setLocale4750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase4751;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase4751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg1)
		{
			return openOrCreateDatabase(arg0, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase4752;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.io.File arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase4752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.io.File arg0, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg1)
		{
			return openOrCreateDatabase(arg0, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4753;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased4753);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased4753);
		}
		internal static global::MonoJavaBridge.MethodId _releaseMemory4754;
		public static int releaseMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._releaseMemory4754);
		}
		public new bool LockingEnabled
		{
			set
			{
				setLockingEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLockingEnabled4755;
		public virtual void setLockingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setLockingEnabled4755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setLockingEnabled4755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _beginTransaction4756;
		public virtual void beginTransaction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._beginTransaction4756);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._beginTransaction4756);
		}
		internal static global::MonoJavaBridge.MethodId _beginTransactionWithListener4757;
		public virtual void beginTransactionWithListener(android.database.sqlite.SQLiteTransactionListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener4757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener4757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endTransaction4758;
		public virtual void endTransaction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._endTransaction4758);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._endTransaction4758);
		}
		internal static global::MonoJavaBridge.MethodId _setTransactionSuccessful4759;
		public virtual void setTransactionSuccessful()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful4759);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful4759);
		}
		internal static global::MonoJavaBridge.MethodId _inTransaction4760;
		public virtual bool inTransaction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._inTransaction4760);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._inTransaction4760);
		}
		internal static global::MonoJavaBridge.MethodId _isDbLockedByCurrentThread4761;
		public virtual bool isDbLockedByCurrentThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread4761);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread4761);
		}
		internal static global::MonoJavaBridge.MethodId _isDbLockedByOtherThreads4762;
		public virtual bool isDbLockedByOtherThreads()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads4762);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads4762);
		}
		internal static global::MonoJavaBridge.MethodId _yieldIfContended4763;
		public virtual bool yieldIfContended()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._yieldIfContended4763);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContended4763);
		}
		internal static global::MonoJavaBridge.MethodId _yieldIfContendedSafely4764;
		public virtual bool yieldIfContendedSafely(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely4764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely4764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _yieldIfContendedSafely4765;
		public virtual bool yieldIfContendedSafely()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely4765);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely4765);
		}
		public new global::java.util.Map SyncedTables
		{
			get
			{
				return getSyncedTables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSyncedTables4766;
		public virtual global::java.util.Map getSyncedTables()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getSyncedTables4766)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getSyncedTables4766)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _openDatabase4767;
		public static global::android.database.sqlite.SQLiteDatabase openDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openDatabase4767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase openDatabase(java.lang.String arg0, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg1, int arg2)
		{
			return openDatabase(arg0, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg1, arg2);
		}
		public new long MaximumSize
		{
			get
			{
				return getMaximumSize();
			}
			set
			{
				setMaximumSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumSize4768;
		public virtual long getMaximumSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getMaximumSize4768);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getMaximumSize4768);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumSize4769;
		public virtual long setMaximumSize(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setMaximumSize4769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setMaximumSize4769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long PageSize
		{
			get
			{
				return getPageSize();
			}
			set
			{
				setPageSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPageSize4770;
		public virtual long getPageSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getPageSize4770);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getPageSize4770);
		}
		internal static global::MonoJavaBridge.MethodId _setPageSize4771;
		public virtual void setPageSize(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setPageSize4771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setPageSize4771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markTableSyncable4772;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._markTableSyncable4772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._markTableSyncable4772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _markTableSyncable4773;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._markTableSyncable4773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._markTableSyncable4773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _findEditTable4774;
		public static global::java.lang.String findEditTable(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._findEditTable4774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compileStatement4775;
		public virtual global::android.database.sqlite.SQLiteStatement compileStatement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._compileStatement4775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.sqlite.SQLiteStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._compileStatement4775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.sqlite.SQLiteStatement;
		}
		internal static global::MonoJavaBridge.MethodId _queryWithFactory4776;
		public virtual global::android.database.Cursor queryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, bool arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8, java.lang.String arg9)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._queryWithFactory4776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._queryWithFactory4776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.database.Cursor;
		}
		public android.database.Cursor queryWithFactory(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0, bool arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8, java.lang.String arg9)
		{
			return queryWithFactory((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		internal static global::MonoJavaBridge.MethodId _rawQuery4777;
		public virtual global::android.database.Cursor rawQuery(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._rawQuery4777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._rawQuery4777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _rawQueryWithFactory4778;
		public virtual global::android.database.Cursor rawQueryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory4778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory4778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
		}
		public android.database.Cursor rawQueryWithFactory(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3)
		{
			return rawQueryWithFactory((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _insertOrThrow4779;
		public virtual long insertOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._insertOrThrow4779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insertOrThrow4779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _replaceOrThrow4780;
		public virtual long replaceOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._replaceOrThrow4780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._replaceOrThrow4780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insertWithOnConflict4781;
		public virtual long insertWithOnConflict(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict4781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict4781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _updateWithOnConflict4782;
		public virtual int updateWithOnConflict(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict4782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict4782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _execSQL4783;
		public virtual void execSQL(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._execSQL4783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._execSQL4783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execSQL4784;
		public virtual void execSQL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._execSQL4784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._execSQL4784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _needUpgrade4785;
		public virtual bool needUpgrade(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._needUpgrade4785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._needUpgrade4785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int CONFLICT_ROLLBACK
		{
			get
			{
				return 1;
			}
		}
		public static int CONFLICT_ABORT
		{
			get
			{
				return 2;
			}
		}
		public static int CONFLICT_FAIL
		{
			get
			{
				return 3;
			}
		}
		public static int CONFLICT_IGNORE
		{
			get
			{
				return 4;
			}
		}
		public static int CONFLICT_REPLACE
		{
			get
			{
				return 5;
			}
		}
		public static int CONFLICT_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int SQLITE_MAX_LIKE_PATTERN_LENGTH
		{
			get
			{
				return 50000;
			}
		}
		public static int OPEN_READWRITE
		{
			get
			{
				return 0;
			}
		}
		public static int OPEN_READONLY
		{
			get
			{
				return 1;
			}
		}
		public static int NO_LOCALIZED_COLLATORS
		{
			get
			{
				return 16;
			}
		}
		public static int CREATE_IF_NECESSARY
		{
			get
			{
				return 268435456;
			}
		}
		static SQLiteDatabase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase"));
			global::android.database.sqlite.SQLiteDatabase._finalize4735 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "finalize", "()V");
			global::android.database.sqlite.SQLiteDatabase._replace4736 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "replace", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._close4737 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteDatabase._delete4738 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteDatabase._insert4739 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._isReadOnly4740 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isReadOnly", "()Z");
			global::android.database.sqlite.SQLiteDatabase._getPath4741 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.database.sqlite.SQLiteDatabase._query4742 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._query4743 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._query4744 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._create4745 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "create", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._isOpen4746 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isOpen", "()Z");
			global::android.database.sqlite.SQLiteDatabase._update4747 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteDatabase._getVersion4748 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getVersion", "()I");
			global::android.database.sqlite.SQLiteDatabase._setVersion4749 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setVersion", "(I)V");
			global::android.database.sqlite.SQLiteDatabase._setLocale4750 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase4751 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase4752 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/io/File;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased4753 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteDatabase._releaseMemory4754 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "releaseMemory", "()I");
			global::android.database.sqlite.SQLiteDatabase._setLockingEnabled4755 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLockingEnabled", "(Z)V");
			global::android.database.sqlite.SQLiteDatabase._beginTransaction4756 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransaction", "()V");
			global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener4757 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransactionWithListener", "(Landroid/database/sqlite/SQLiteTransactionListener;)V");
			global::android.database.sqlite.SQLiteDatabase._endTransaction4758 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "endTransaction", "()V");
			global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful4759 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setTransactionSuccessful", "()V");
			global::android.database.sqlite.SQLiteDatabase._inTransaction4760 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "inTransaction", "()Z");
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread4761 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByCurrentThread", "()Z");
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads4762 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByOtherThreads", "()Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContended4763 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContended", "()Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely4764 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "(J)Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely4765 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "()Z");
			global::android.database.sqlite.SQLiteDatabase._getSyncedTables4766 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getSyncedTables", "()Ljava/util/Map;");
			global::android.database.sqlite.SQLiteDatabase._openDatabase4767 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._getMaximumSize4768 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getMaximumSize", "()J");
			global::android.database.sqlite.SQLiteDatabase._setMaximumSize4769 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setMaximumSize", "(J)J");
			global::android.database.sqlite.SQLiteDatabase._getPageSize4770 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPageSize", "()J");
			global::android.database.sqlite.SQLiteDatabase._setPageSize4771 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setPageSize", "(J)V");
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable4772 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable4773 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._findEditTable4774 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "findEditTable", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.sqlite.SQLiteDatabase._compileStatement4775 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "compileStatement", "(Ljava/lang/String;)Landroid/database/sqlite/SQLiteStatement;");
			global::android.database.sqlite.SQLiteDatabase._queryWithFactory4776 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "queryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._rawQuery4777 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory4778 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQueryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._insertOrThrow4779 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._replaceOrThrow4780 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "replaceOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict4781 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "insertWithOnConflict", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;I)J");
			global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict4782 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "updateWithOnConflict", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.database.sqlite.SQLiteDatabase._execSQL4783 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			global::android.database.sqlite.SQLiteDatabase._execSQL4784 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._needUpgrade4785 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "needUpgrade", "(I)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}