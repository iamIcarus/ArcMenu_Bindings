using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Capricorn {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']"
	[global::Android.Runtime.Register ("com/capricorn/ArcMenu", DoNotGenerateAcw=true)]
	public partial class ArcMenu : global::Android.Widget.RelativeLayout {


		static IntPtr isAnimating_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']/field[@name='isAnimating']"
		[Register ("isAnimating")]
		public global::Java.Lang.Boolean IsAnimating {
			get {
				if (isAnimating_jfieldId == IntPtr.Zero)
					isAnimating_jfieldId = JNIEnv.GetFieldID (class_ref, "isAnimating", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, isAnimating_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (isAnimating_jfieldId == IntPtr.Zero)
					isAnimating_jfieldId = JNIEnv.GetFieldID (class_ref, "isAnimating", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, isAnimating_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/capricorn/ArcMenu", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArcMenu); }
		}

		protected ArcMenu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']/constructor[@name='ArcMenu' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ArcMenu (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ArcMenu)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']/constructor[@name='ArcMenu' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public ArcMenu (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ArcMenu)) {
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
			global::Com.Capricorn.ArcMenu __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.ArcMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p1 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addItem_Landroid_view_View_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View.OnClickListener']]"
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

		static Delegate cb_setAtributes_FFII;
#pragma warning disable 0169
		static Delegate GetSetAtributes_FFIIHandler ()
		{
			if (cb_setAtributes_FFII == null)
				cb_setAtributes_FFII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, int, int>) n_SetAtributes_FFII);
			return cb_setAtributes_FFII;
		}

		static void n_SetAtributes_FFII (IntPtr jnienv, IntPtr native__this, float p0, float p1, int p2, int p3)
		{
			global::Com.Capricorn.ArcMenu __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.ArcMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAtributes (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setAtributes_FFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']/method[@name='setAtributes' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setAtributes", "(FFII)V", "GetSetAtributes_FFIIHandler")]
		public virtual void SetAtributes (float p0, float p1, int p2, int p3)
		{
			if (id_setAtributes_FFII == IntPtr.Zero)
				id_setAtributes_FFII = JNIEnv.GetMethodID (class_ref, "setAtributes", "(FFII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAtributes_FFII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAtributes", "(FFII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_setButtonImage_I;
#pragma warning disable 0169
		static Delegate GetSetButtonImage_IHandler ()
		{
			if (cb_setButtonImage_I == null)
				cb_setButtonImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetButtonImage_I);
			return cb_setButtonImage_I;
		}

		static void n_SetButtonImage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Capricorn.ArcMenu __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.ArcMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetButtonImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setButtonImage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']/method[@name='setButtonImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonImage", "(I)V", "GetSetButtonImage_IHandler")]
		public virtual void SetButtonImage (int p0)
		{
			if (id_setButtonImage_I == IntPtr.Zero)
				id_setButtonImage_I = JNIEnv.GetMethodID (class_ref, "setButtonImage", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setButtonImage_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButtonImage", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setButtonIndicatorImage_I;
#pragma warning disable 0169
		static Delegate GetSetButtonIndicatorImage_IHandler ()
		{
			if (cb_setButtonIndicatorImage_I == null)
				cb_setButtonIndicatorImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetButtonIndicatorImage_I);
			return cb_setButtonIndicatorImage_I;
		}

		static void n_SetButtonIndicatorImage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Capricorn.ArcMenu __this = global::Java.Lang.Object.GetObject<global::Com.Capricorn.ArcMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetButtonIndicatorImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setButtonIndicatorImage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.capricorn']/class[@name='ArcMenu']/method[@name='setButtonIndicatorImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonIndicatorImage", "(I)V", "GetSetButtonIndicatorImage_IHandler")]
		public virtual void SetButtonIndicatorImage (int p0)
		{
			if (id_setButtonIndicatorImage_I == IntPtr.Zero)
				id_setButtonIndicatorImage_I = JNIEnv.GetMethodID (class_ref, "setButtonIndicatorImage", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setButtonIndicatorImage_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButtonIndicatorImage", "(I)V"), new JValue (p0));
		}

	}
}
