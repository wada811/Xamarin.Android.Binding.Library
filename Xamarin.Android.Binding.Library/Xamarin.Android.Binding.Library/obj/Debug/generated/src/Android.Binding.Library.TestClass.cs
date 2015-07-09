using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Binding.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']"
	[global::Android.Runtime.Register ("com/wada811/android/binding/library/TestClass", DoNotGenerateAcw=true)]
	public partial class TestClass : global::Java.Lang.Object, global::Android.Binding.Library.ITestInterface {


		static IntPtr aBoolean_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/field[@name='aBoolean']"
		[Register ("aBoolean")]
		public bool ABoolean {
			get {
				if (aBoolean_jfieldId == IntPtr.Zero)
					aBoolean_jfieldId = JNIEnv.GetFieldID (class_ref, "aBoolean", "Z");
				return JNIEnv.GetBooleanField (Handle, aBoolean_jfieldId);
			}
			set {
				if (aBoolean_jfieldId == IntPtr.Zero)
					aBoolean_jfieldId = JNIEnv.GetFieldID (class_ref, "aBoolean", "Z");
				try {
					JNIEnv.SetField (Handle, aBoolean_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr aDouble_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/field[@name='aDouble']"
		[Register ("aDouble")]
		public double ADouble {
			get {
				if (aDouble_jfieldId == IntPtr.Zero)
					aDouble_jfieldId = JNIEnv.GetFieldID (class_ref, "aDouble", "D");
				return JNIEnv.GetDoubleField (Handle, aDouble_jfieldId);
			}
			set {
				if (aDouble_jfieldId == IntPtr.Zero)
					aDouble_jfieldId = JNIEnv.GetFieldID (class_ref, "aDouble", "D");
				try {
					JNIEnv.SetField (Handle, aDouble_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr aFloat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/field[@name='aFloat']"
		[Register ("aFloat")]
		public float AFloat {
			get {
				if (aFloat_jfieldId == IntPtr.Zero)
					aFloat_jfieldId = JNIEnv.GetFieldID (class_ref, "aFloat", "F");
				return JNIEnv.GetFloatField (Handle, aFloat_jfieldId);
			}
			set {
				if (aFloat_jfieldId == IntPtr.Zero)
					aFloat_jfieldId = JNIEnv.GetFieldID (class_ref, "aFloat", "F");
				try {
					JNIEnv.SetField (Handle, aFloat_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr aLong_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/field[@name='aLong']"
		[Register ("aLong")]
		public long ALong {
			get {
				if (aLong_jfieldId == IntPtr.Zero)
					aLong_jfieldId = JNIEnv.GetFieldID (class_ref, "aLong", "J");
				return JNIEnv.GetLongField (Handle, aLong_jfieldId);
			}
			set {
				if (aLong_jfieldId == IntPtr.Zero)
					aLong_jfieldId = JNIEnv.GetFieldID (class_ref, "aLong", "J");
				try {
					JNIEnv.SetField (Handle, aLong_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr aString_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/field[@name='aString']"
		[Register ("aString")]
		public string AString {
			get {
				if (aString_jfieldId == IntPtr.Zero)
					aString_jfieldId = JNIEnv.GetFieldID (class_ref, "aString", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, aString_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (aString_jfieldId == IntPtr.Zero)
					aString_jfieldId = JNIEnv.GetFieldID (class_ref, "aString", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, aString_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr anInt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/field[@name='anInt']"
		[Register ("anInt")]
		public int AnInt {
			get {
				if (anInt_jfieldId == IntPtr.Zero)
					anInt_jfieldId = JNIEnv.GetFieldID (class_ref, "anInt", "I");
				return JNIEnv.GetIntField (Handle, anInt_jfieldId);
			}
			set {
				if (anInt_jfieldId == IntPtr.Zero)
					anInt_jfieldId = JNIEnv.GetFieldID (class_ref, "anInt", "I");
				try {
					JNIEnv.SetField (Handle, anInt_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/wada811/android/binding/library/TestClass", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestClass); }
		}

		protected TestClass (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe TestClass (float p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TestClass)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(F)V", __args);
					return;
				}

				if (id_ctor_F == IntPtr.Zero)
					id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_F, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe TestClass (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TestClass)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe TestClass (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TestClass)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TestClass (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (TestClass)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestClass ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TestClass)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe TestClass (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TestClass)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/constructor[@name='TestClass' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe TestClass (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TestClass)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_toast_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToast_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_toast_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_toast_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Toast_Landroid_content_Context_Ljava_lang_String_);
			return cb_toast_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_Toast_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Binding.Library.TestClass __this = global::Java.Lang.Object.GetObject<global::Android.Binding.Library.TestClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Toast (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_toast_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.wada811.android.binding.library']/class[@name='TestClass']/method[@name='toast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("toast", "(Landroid/content/Context;Ljava/lang/String;)V", "GetToast_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void Toast (global::Android.Content.Context p0, string p1)
		{
			if (id_toast_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_toast_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toast", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_toast_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toast", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
