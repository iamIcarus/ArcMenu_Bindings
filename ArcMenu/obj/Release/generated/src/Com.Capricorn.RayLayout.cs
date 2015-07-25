using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Capricorn {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.capricorn']/class[@name='RayLayout']"
	[global::Android.Runtime.Register ("com/capricorn/RayLayout", DoNotGenerateAcw=true)]
	public partial class RayLayout : global::Android.Views.ViewGroup {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/capricorn/RayLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RayLayout); }
		}

		protected RayLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.capricorn']/class[@name='RayLayout']/constructor[@name='RayLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public RayLayout (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RayLayout)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.capricorn']/class[@name='RayLayout']/constructor[@name='RayLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public RayLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RayLayout)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isExpanded;
#pragma warning disable 0169
		static Delegate GetIsExpandedHandler ()
		{
			if (cb_isExpanded == null)
				cb_isExpanded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpanded);
			return cb_isExpanded;
		}

		static bool n_IsExpanded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Capricorn.RayLayout __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.RayLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpanded;
		}
#pragma warning restore 0169

		static IntPtr id_isExpanded;
		public virtual bool IsExpanded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='RayLayout']/method[@name='isExpanded' and count(parameter)=0]"
			[Register ("isExpanded", "()Z", "GetIsExpandedHandler")]
			get {
				if (id_isExpanded == IntPtr.Zero)
					id_isExpanded = JNIEnv.GetMethodID (class_ref, "isExpanded", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isExpanded);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpanded", "()Z"));
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Capricorn.RayLayout __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.RayLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='RayLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_setChildSize_I;
#pragma warning disable 0169
		static Delegate GetSetChildSize_IHandler ()
		{
			if (cb_setChildSize_I == null)
				cb_setChildSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetChildSize_I);
			return cb_setChildSize_I;
		}

		static void n_SetChildSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Capricorn.RayLayout __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.RayLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChildSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChildSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='RayLayout']/method[@name='setChildSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChildSize", "(I)V", "GetSetChildSize_IHandler")]
		public virtual void SetChildSize (int p0)
		{
			if (id_setChildSize_I == IntPtr.Zero)
				id_setChildSize_I = JNIEnv.GetMethodID (class_ref, "setChildSize", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setChildSize_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChildSize", "(I)V"), new JValue (p0));
		}

		static Delegate cb_switchState_Z;
#pragma warning disable 0169
		static Delegate GetSwitchState_ZHandler ()
		{
			if (cb_switchState_Z == null)
				cb_switchState_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SwitchState_Z);
			return cb_switchState_Z;
		}

		static void n_SwitchState_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Capricorn.RayLayout __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.RayLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwitchState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_switchState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='RayLayout']/method[@name='switchState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("switchState", "(Z)V", "GetSwitchState_ZHandler")]
		public virtual void SwitchState (bool p0)
		{
			if (id_switchState_Z == IntPtr.Zero)
				id_switchState_Z = JNIEnv.GetMethodID (class_ref, "switchState", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_switchState_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchState", "(Z)V"), new JValue (p0));
		}

	}
}
