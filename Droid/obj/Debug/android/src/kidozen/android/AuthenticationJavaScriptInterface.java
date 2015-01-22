package kidozen.android;


public class AuthenticationJavaScriptInterface
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getTitleCallback:(Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("Kidozen.Android.AuthenticationJavaScriptInterface, kido.android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", AuthenticationJavaScriptInterface.class, __md_methods);
	}


	public AuthenticationJavaScriptInterface () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AuthenticationJavaScriptInterface.class)
			mono.android.TypeManager.Activate ("Kidozen.Android.AuthenticationJavaScriptInterface, kido.android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public AuthenticationJavaScriptInterface (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == AuthenticationJavaScriptInterface.class)
			mono.android.TypeManager.Activate ("Kidozen.Android.AuthenticationJavaScriptInterface, kido.android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	@android.webkit.JavascriptInterface

	public void getTitleCallback (java.lang.String p0)
	{
		n_getTitleCallback (p0);
	}

	private native void n_getTitleCallback (java.lang.String p0);

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
