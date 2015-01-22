package kidozen.android;


public class DataVisualizationActivity_JSValidationWebChromeClient
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseWindow:(Landroid/webkit/WebView;)V:GetOnCloseWindow_Landroid_webkit_WebView_Handler\n" +
			"n_onProgressChanged:(Landroid/webkit/WebView;I)V:GetOnProgressChanged_Landroid_webkit_WebView_IHandler\n" +
			"n_onReceivedTitle:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnReceivedTitle_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"n_onJsBeforeUnload:(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z:GetOnJsBeforeUnload_Landroid_webkit_WebView_Ljava_lang_String_Ljava_lang_String_Landroid_webkit_JsResult_Handler\n" +
			"n_onCreateWindow:(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z:GetOnCreateWindow_Landroid_webkit_WebView_ZZLandroid_os_Message_Handler\n" +
			"n_onReceivedIcon:(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V:GetOnReceivedIcon_Landroid_webkit_WebView_Landroid_graphics_Bitmap_Handler\n" +
			"n_onConsoleMessage:(Landroid/webkit/ConsoleMessage;)Z:GetOnConsoleMessage_Landroid_webkit_ConsoleMessage_Handler\n" +
			"";
		mono.android.Runtime.register ("Kidozen.Android.DataVisualizationActivity/JSValidationWebChromeClient, kido.android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", DataVisualizationActivity_JSValidationWebChromeClient.class, __md_methods);
	}


	public DataVisualizationActivity_JSValidationWebChromeClient () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DataVisualizationActivity_JSValidationWebChromeClient.class)
			mono.android.TypeManager.Activate ("Kidozen.Android.DataVisualizationActivity/JSValidationWebChromeClient, kido.android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCloseWindow (android.webkit.WebView p0)
	{
		n_onCloseWindow (p0);
	}

	private native void n_onCloseWindow (android.webkit.WebView p0);


	public void onProgressChanged (android.webkit.WebView p0, int p1)
	{
		n_onProgressChanged (p0, p1);
	}

	private native void n_onProgressChanged (android.webkit.WebView p0, int p1);


	public void onReceivedTitle (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onReceivedTitle (p0, p1);
	}

	private native void n_onReceivedTitle (android.webkit.WebView p0, java.lang.String p1);


	public boolean onJsBeforeUnload (android.webkit.WebView p0, java.lang.String p1, java.lang.String p2, android.webkit.JsResult p3)
	{
		return n_onJsBeforeUnload (p0, p1, p2, p3);
	}

	private native boolean n_onJsBeforeUnload (android.webkit.WebView p0, java.lang.String p1, java.lang.String p2, android.webkit.JsResult p3);


	public boolean onCreateWindow (android.webkit.WebView p0, boolean p1, boolean p2, android.os.Message p3)
	{
		return n_onCreateWindow (p0, p1, p2, p3);
	}

	private native boolean n_onCreateWindow (android.webkit.WebView p0, boolean p1, boolean p2, android.os.Message p3);


	public void onReceivedIcon (android.webkit.WebView p0, android.graphics.Bitmap p1)
	{
		n_onReceivedIcon (p0, p1);
	}

	private native void n_onReceivedIcon (android.webkit.WebView p0, android.graphics.Bitmap p1);


	public boolean onConsoleMessage (android.webkit.ConsoleMessage p0)
	{
		return n_onConsoleMessage (p0);
	}

	private native boolean n_onConsoleMessage (android.webkit.ConsoleMessage p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
