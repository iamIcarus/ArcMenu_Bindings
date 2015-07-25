using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Capricorn {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.capricorn']/class[@name='RotateAndTranslateAnimation']"
	[global::Android.Runtime.Register ("com/capricorn/RotateAndTranslateAnimation", DoNotGenerateAcw=true)]
	public partial class RotateAndTranslateAnimation : global::Android.Views.Animations.Animation {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/capricorn/RotateAndTranslateAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RotateAndTranslateAnimation); }
		}

		protected RotateAndTranslateAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.capricorn']/class[@name='RotateAndTranslateAnimation']/constructor[@name='RotateAndTranslateAnimation' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register (".ctor", "(FFFFFF)V", "")]
		public RotateAndTranslateAnimation (float p0, float p1, float p2, float p3, float p4, float p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RotateAndTranslateAnimation)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFFFF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FFFFFF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				return;
			}

			if (id_ctor_FFFFFF == IntPtr.Zero)
				id_ctor_FFFFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFFF)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FFFFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

	}
}
