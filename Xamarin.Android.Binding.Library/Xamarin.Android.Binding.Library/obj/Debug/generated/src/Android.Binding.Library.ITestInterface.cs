using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Binding.Library {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.wada811.android.binding.library']/interface[@name='TestInterface']"
	[Register ("com/wada811/android/binding/library/TestInterface", "", "Android.Binding.Library.ITestInterfaceInvoker")]
	public partial interface ITestInterface : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.wada811.android.binding.library']/interface[@name='TestInterface']/method[@name='toast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("toast", "(Landroid/content/Context;Ljava/lang/String;)V", "GetToast_Landroid_content_Context_Ljava_lang_String_Handler:Android.Binding.Library.ITestInterfaceInvoker, Xamarin.Android.Binding.Library")]
		void Toast (global::Android.Content.Context p0, string p1);

	}

	[global::Android.Runtime.Register ("com/wada811/android/binding/library/TestInterface", DoNotGenerateAcw=true)]
	internal class ITestInterfaceInvoker : global::Java.Lang.Object, ITestInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/wada811/android/binding/library/TestInterface");
		IntPtr class_ref;

		public static ITestInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITestInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.wada811.android.binding.library.TestInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITestInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITestInterfaceInvoker); }
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
			global::Android.Binding.Library.ITestInterface __this = global::Java.Lang.Object.GetObject<global::Android.Binding.Library.ITestInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Toast (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_toast_Landroid_content_Context_Ljava_lang_String_;
		public unsafe void Toast (global::Android.Content.Context p0, string p1)
		{
			if (id_toast_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_toast_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toast", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_toast_Landroid_content_Context_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
