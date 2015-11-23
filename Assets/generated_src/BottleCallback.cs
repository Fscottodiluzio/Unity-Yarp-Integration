//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class BottleCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BottleCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BottleCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BottleCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_BottleCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public new void onRead(Bottle datum) {
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes0)) yarpPINVOKE.BottleCallback_onReadSwigExplicitBottleCallback__SWIG_0(swigCPtr, Bottle.getCPtr(datum)); else yarpPINVOKE.BottleCallback_onRead__SWIG_0(swigCPtr, Bottle.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(Bottle datum, TypedReaderBottle reader) {
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes1)) yarpPINVOKE.BottleCallback_onReadSwigExplicitBottleCallback__SWIG_1(swigCPtr, Bottle.getCPtr(datum), TypedReaderBottle.getCPtr(reader)); else yarpPINVOKE.BottleCallback_onRead__SWIG_1(swigCPtr, Bottle.getCPtr(datum), TypedReaderBottle.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public BottleCallback() : this(yarpPINVOKE.new_BottleCallback(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateBottleCallback_0(SwigDirectoronRead__SWIG_0);
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateBottleCallback_1(SwigDirectoronRead__SWIG_1);
    yarpPINVOKE.BottleCallback_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(BottleCallback));
    return hasDerivedMethod;
  }

  private void SwigDirectoronRead__SWIG_0(global::System.IntPtr datum) {
    onRead(new Bottle(datum, false));
  }

  private void SwigDirectoronRead__SWIG_1(global::System.IntPtr datum, global::System.IntPtr reader) {
    onRead(new Bottle(datum, false), new TypedReaderBottle(reader, false));
  }

  public delegate void SwigDelegateBottleCallback_0(global::System.IntPtr datum);
  public delegate void SwigDelegateBottleCallback_1(global::System.IntPtr datum, global::System.IntPtr reader);

  private SwigDelegateBottleCallback_0 swigDelegate0;
  private SwigDelegateBottleCallback_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(Bottle) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(Bottle), typeof(TypedReaderBottle) };
}
