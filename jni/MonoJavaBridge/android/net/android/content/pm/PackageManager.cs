namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class PackageManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PackageManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PackageManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected PackageManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class NameNotFoundException : android.util.AndroidException
		{ 
			internal new static global::java.lang.Class staticClass; 
			static NameNotFoundException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PackageManager.NameNotFoundException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.pm.PackageManager.NameNotFoundException(@__env); 
				} 
			} 
			protected NameNotFoundException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _NameNotFoundException1666; 
			public NameNotFoundException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, _NameNotFoundException1666, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _NameNotFoundException1667; 
			public NameNotFoundException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, _NameNotFoundException1667, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.pm.PackageManager.NameNotFoundException.staticClass = @__class; 
				global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException1666 = @__env.GetMethodID(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "()V"); 
				global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException1667 = @__env.GetMethodID(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkPermission1668; 
		public abstract int checkPermission(java.lang.String arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageInfo1669; 
		public abstract android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationInfo1670; 
		public abstract android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getText1671; 
		public abstract java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _resolveActivity1672; 
		public abstract android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable1673; 
		public abstract android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getXml1674; 
		public abstract android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getLaunchIntentForPackage1675; 
		public abstract android.content.Intent getLaunchIntentForPackage(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageGids1676; 
		public abstract int[] getPackageGids(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getPermissionInfo1677; 
		public abstract android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _queryPermissionsByGroup1678; 
		public abstract java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getPermissionGroupInfo1679; 
		public abstract android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getAllPermissionGroups1680; 
		public abstract java.util.List getAllPermissionGroups(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getActivityInfo1681; 
		public abstract android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getReceiverInfo1682; 
		public abstract android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceInfo1683; 
		public abstract android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getInstalledPackages1684; 
		public abstract java.util.List getInstalledPackages(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _addPermission1685; 
		public abstract bool addPermission(android.content.pm.PermissionInfo arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _removePermission1686; 
		public abstract void removePermission(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _checkSignatures1687; 
		public abstract int checkSignatures(java.lang.String arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _checkSignatures1688; 
		public abstract int checkSignatures(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackagesForUid1689; 
		public abstract java.lang.String[] getPackagesForUid(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getNameForUid1690; 
		public abstract java.lang.String getNameForUid(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getInstalledApplications1691; 
		public abstract java.util.List getInstalledApplications(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemSharedLibraryNames1692; 
		public abstract java.lang.String[] getSystemSharedLibraryNames(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemAvailableFeatures1693; 
		public abstract android.content.pm.FeatureInfo[] getSystemAvailableFeatures(); 
		internal static global::net.sf.jni4net.jni.MethodId _hasSystemFeature1694; 
		public abstract bool hasSystemFeature(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _queryIntentActivities1695; 
		public abstract java.util.List queryIntentActivities(android.content.Intent arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _queryIntentActivityOptions1696; 
		public abstract java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _queryBroadcastReceivers1697; 
		public abstract java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _resolveService1698; 
		public abstract android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _queryIntentServices1699; 
		public abstract java.util.List queryIntentServices(android.content.Intent arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _resolveContentProvider1700; 
		public abstract android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _queryContentProviders1701; 
		public abstract java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getInstrumentationInfo1702; 
		public abstract android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _queryInstrumentation1703; 
		public abstract java.util.List queryInstrumentation(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getActivityIcon1704; 
		public abstract android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getActivityIcon1705; 
		public abstract android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultActivityIcon1706; 
		public abstract android.graphics.drawable.Drawable getDefaultActivityIcon(); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationIcon1707; 
		public abstract android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationIcon1708; 
		public abstract android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationLabel1709; 
		public abstract java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getResourcesForActivity1710; 
		public abstract android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getResourcesForApplication1711; 
		public abstract android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getResourcesForApplication1712; 
		public abstract android.content.res.Resources getResourcesForApplication(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageArchiveInfo1713; 
		public virtual android.content.pm.PackageInfo getPackageArchiveInfo(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageInfo>(@__env, @__env.CallObjectMethodPtr(this, _getPackageArchiveInfo1713, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PackageManager.staticClass, _getPackageArchiveInfo1713, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstallerPackageName1714; 
		public abstract java.lang.String getInstallerPackageName(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _addPackageToPreferred1715; 
		public abstract void addPackageToPreferred(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _removePackageFromPreferred1716; 
		public abstract void removePackageFromPreferred(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferredPackages1717; 
		public abstract java.util.List getPreferredPackages(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _addPreferredActivity1718; 
		public abstract void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _clearPackagePreferredActivities1719; 
		public abstract void clearPackagePreferredActivities(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferredActivities1720; 
		public abstract int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _setComponentEnabledSetting1721; 
		public abstract void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getComponentEnabledSetting1722; 
		public abstract int getComponentEnabledSetting(android.content.ComponentName arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setApplicationEnabledSetting1723; 
		public abstract void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationEnabledSetting1724; 
		public abstract int getApplicationEnabledSetting(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _isSafeMode1725; 
		public abstract bool isSafeMode(); 
		internal static global::net.sf.jni4net.jni.MethodId _PackageManager1726; 
		public PackageManager()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PackageManager.staticClass, _PackageManager1726, this); 
		} 
		public static int GET_ACTIVITIES
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int GET_RECEIVERS
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int GET_SERVICES
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int GET_PROVIDERS
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int GET_INSTRUMENTATION
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int GET_INTENT_FILTERS
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int GET_SIGNATURES
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int GET_RESOLVED_FILTER
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int GET_META_DATA
		{ 
			get 
			{ 
				return 128; 
			} 
		} 
		public static int GET_GIDS
		{ 
			get 
			{ 
				return 256; 
			} 
		} 
		public static int GET_DISABLED_COMPONENTS
		{ 
			get 
			{ 
				return 512; 
			} 
		} 
		public static int GET_SHARED_LIBRARY_FILES
		{ 
			get 
			{ 
				return 1024; 
			} 
		} 
		public static int GET_URI_PERMISSION_PATTERNS
		{ 
			get 
			{ 
				return 2048; 
			} 
		} 
		public static int GET_PERMISSIONS
		{ 
			get 
			{ 
				return 4096; 
			} 
		} 
		public static int GET_UNINSTALLED_PACKAGES
		{ 
			get 
			{ 
				return 8192; 
			} 
		} 
		public static int GET_CONFIGURATIONS
		{ 
			get 
			{ 
				return 16384; 
			} 
		} 
		public static int MATCH_DEFAULT_ONLY
		{ 
			get 
			{ 
				return 65536; 
			} 
		} 
		public static int PERMISSION_GRANTED
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int PERMISSION_DENIED
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int SIGNATURE_MATCH
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int SIGNATURE_NEITHER_SIGNED
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SIGNATURE_FIRST_NOT_SIGNED
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int SIGNATURE_SECOND_NOT_SIGNED
		{ 
			get 
			{ 
				return -2; 
			} 
		} 
		public static int SIGNATURE_NO_MATCH
		{ 
			get 
			{ 
				return -3; 
			} 
		} 
		public static int SIGNATURE_UNKNOWN_PACKAGE
		{ 
			get 
			{ 
				return -4; 
			} 
		} 
		public static int COMPONENT_ENABLED_STATE_DEFAULT
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int COMPONENT_ENABLED_STATE_ENABLED
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int COMPONENT_ENABLED_STATE_DISABLED
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DONT_KILL_APP
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int PKG_INSTALL_INCOMPLETE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int PKG_INSTALL_COMPLETE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static java.lang.String FEATURE_CAMERA
		{ 
			get 
			{ 
				return "android.hardware.camera"; 
			} 
		} 
		public static java.lang.String FEATURE_CAMERA_AUTOFOCUS
		{ 
			get 
			{ 
				return "android.hardware.camera.autofocus"; 
			} 
		} 
		public static java.lang.String FEATURE_CAMERA_FLASH
		{ 
			get 
			{ 
				return "android.hardware.camera.flash"; 
			} 
		} 
		public static java.lang.String FEATURE_SENSOR_LIGHT
		{ 
			get 
			{ 
				return "android.hardware.sensor.light"; 
			} 
		} 
		public static java.lang.String FEATURE_SENSOR_PROXIMITY
		{ 
			get 
			{ 
				return "android.hardware.sensor.proximity"; 
			} 
		} 
		public static java.lang.String FEATURE_TELEPHONY
		{ 
			get 
			{ 
				return "android.hardware.telephony"; 
			} 
		} 
		public static java.lang.String FEATURE_TELEPHONY_CDMA
		{ 
			get 
			{ 
				return "android.hardware.telephony.cdma"; 
			} 
		} 
		public static java.lang.String FEATURE_TELEPHONY_GSM
		{ 
			get 
			{ 
				return "android.hardware.telephony.gsm"; 
			} 
		} 
		public static java.lang.String FEATURE_TOUCHSCREEN_MULTITOUCH
		{ 
			get 
			{ 
				return "android.hardware.touchscreen.multitouch"; 
			} 
		} 
		public static java.lang.String FEATURE_LIVE_WALLPAPER
		{ 
			get 
			{ 
				return "android.software.live_wallpaper"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.PackageManager.staticClass = @__class; 
			global::android.content.pm.PackageManager._checkPermission1668 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.content.pm.PackageManager._getPackageInfo1669 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;"); 
			global::android.content.pm.PackageManager._getApplicationInfo1670 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;"); 
			global::android.content.pm.PackageManager._getText1671 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.PackageManager._resolveActivity1672 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;"); 
			global::android.content.pm.PackageManager._getDrawable1673 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.PackageManager._getXml1674 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;"); 
			global::android.content.pm.PackageManager._getLaunchIntentForPackage1675 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.pm.PackageManager._getPackageGids1676 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPackageGids", "(Ljava/lang/String;)[I"); 
			global::android.content.pm.PackageManager._getPermissionInfo1677 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;"); 
			global::android.content.pm.PackageManager._queryPermissionsByGroup1678 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._getPermissionGroupInfo1679 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;"); 
			global::android.content.pm.PackageManager._getAllPermissionGroups1680 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._getActivityInfo1681 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;"); 
			global::android.content.pm.PackageManager._getReceiverInfo1682 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;"); 
			global::android.content.pm.PackageManager._getServiceInfo1683 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;"); 
			global::android.content.pm.PackageManager._getInstalledPackages1684 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getInstalledPackages", "(I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._addPermission1685 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z"); 
			global::android.content.pm.PackageManager._removePermission1686 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "removePermission", "(Ljava/lang/String;)V"); 
			global::android.content.pm.PackageManager._checkSignatures1687 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.content.pm.PackageManager._checkSignatures1688 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "checkSignatures", "(II)I"); 
			global::android.content.pm.PackageManager._getPackagesForUid1689 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;"); 
			global::android.content.pm.PackageManager._getNameForUid1690 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getNameForUid", "(I)Ljava/lang/String;"); 
			global::android.content.pm.PackageManager._getInstalledApplications1691 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getInstalledApplications", "(I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._getSystemSharedLibraryNames1692 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;"); 
			global::android.content.pm.PackageManager._getSystemAvailableFeatures1693 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;"); 
			global::android.content.pm.PackageManager._hasSystemFeature1694 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z"); 
			global::android.content.pm.PackageManager._queryIntentActivities1695 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._queryIntentActivityOptions1696 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._queryBroadcastReceivers1697 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._resolveService1698 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;"); 
			global::android.content.pm.PackageManager._queryIntentServices1699 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._resolveContentProvider1700 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;"); 
			global::android.content.pm.PackageManager._queryContentProviders1701 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._getInstrumentationInfo1702 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;"); 
			global::android.content.pm.PackageManager._queryInstrumentation1703 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._getActivityIcon1704 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.PackageManager._getActivityIcon1705 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.PackageManager._getDefaultActivityIcon1706 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.PackageManager._getApplicationIcon1707 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.PackageManager._getApplicationIcon1708 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.PackageManager._getApplicationLabel1709 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.PackageManager._getResourcesForActivity1710 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;"); 
			global::android.content.pm.PackageManager._getResourcesForApplication1711 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;"); 
			global::android.content.pm.PackageManager._getResourcesForApplication1712 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;"); 
			global::android.content.pm.PackageManager._getPackageArchiveInfo1713 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;"); 
			global::android.content.pm.PackageManager._getInstallerPackageName1714 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.content.pm.PackageManager._addPackageToPreferred1715 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V"); 
			global::android.content.pm.PackageManager._removePackageFromPreferred1716 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V"); 
			global::android.content.pm.PackageManager._getPreferredPackages1717 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPreferredPackages", "(I)Ljava/util/List;"); 
			global::android.content.pm.PackageManager._addPreferredActivity1718 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V"); 
			global::android.content.pm.PackageManager._clearPackagePreferredActivities1719 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V"); 
			global::android.content.pm.PackageManager._getPreferredActivities1720 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I"); 
			global::android.content.pm.PackageManager._setComponentEnabledSetting1721 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V"); 
			global::android.content.pm.PackageManager._getComponentEnabledSetting1722 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I"); 
			global::android.content.pm.PackageManager._setApplicationEnabledSetting1723 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V"); 
			global::android.content.pm.PackageManager._getApplicationEnabledSetting1724 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I"); 
			global::android.content.pm.PackageManager._isSafeMode1725 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "isSafeMode", "()Z"); 
			global::android.content.pm.PackageManager._PackageManager1726 = @__env.GetMethodID(global::android.content.pm.PackageManager.staticClass, "<init>", "()V"); 
		} 
	} 
} 