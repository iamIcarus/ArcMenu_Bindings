using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Capricorn {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.capricorn']/class[@name='RayMenu']"
	[global::Android.Runtime.Register ("com/capricorn/RayMenu", DoNotGenerateAcw=true)]
	public partial class RayMenu : global::Android.Widget.RelativeLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/capricorn/RayMenu", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RayMenu); }
		}

		protected RayMenu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.capricorn']/class[@name='RayMenu']/constructor[@name='RayMenu' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public RayMenu (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RayMenu)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.capricorn']/class[@name='RayMenu']/constructor[@name='RayMenu' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public RayMenu (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RayMenu)) {
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

		static Delegate cb_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetAddItem_Landroid_view_View_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_ == null)
				cb_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddItem_Landroid_view_View_Landroid_view_View_OnClickListener_);
			return cb_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_;
		}

		static void n_AddItem_Landroid_view_View_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Capricorn.RayMenu __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.RayMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p1 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='RayMenu']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View.OnClickListener']]"
		[Register ("addItem", "(Landroid/view/View;Landroid/view/View$OnClickListener;)V", "GetAddItem_Landroid_view_View_Landroid_view_View_OnClickListener_Handler")]
		public virtual void AddItem (global::Android.Views.View p0, global::Android.Views.View.IOnClickListener p1)
		{
			if (id_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "addItem", "(Landroid/view/View;Landroid/view/View$OnClickListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItem", "(Landroid/view/View;Landroid/view/View$OnClickListener;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
