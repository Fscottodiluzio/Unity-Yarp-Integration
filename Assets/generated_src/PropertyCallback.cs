//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PropertyCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PropertyCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PropertyCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PropertyCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PropertyCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public new void onRead(Property datum) {
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes0)) yarpPINVOKE.PropertyCallback_onReadSwigExplicitPropertyCallback__SWIG_0(swigCPtr, Property.getCPtr(datum)); else yarpPINVOKE.PropertyCallback_onRead__SWIG_0(swigCPtr, Property.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(Property datum, TypedReaderProperty reader) {
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes1)) yarpPINVOKE.PropertyCallback_onReadSwigExplicitPropertyCallback__SWIG_1(swigCPtr, Property.getCPtr(datum), TypedReaderProperty.getCPtr(reader)); else yarpPINVOKE.PropertyCallback_onRead__SWIG_1(swigCPtr, Property.getCPtr(datum), TypedReaderProperty.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public PropertyCallback() : this(yarpPINVOKE.new_PropertyCallback(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes0))
      swigDelegate0 = new SwigDelegatePropertyCallback_0(SwigDirectoronRead__SWIG_0);
    if (SwigDerivedClassHasMethod("onRead", swigMethodTypes1))
      swigDelegate1 = new SwigDelegatePropertyCallback_1(SwigDirectoronRead__SWIG_1);
    yarpPINVOKE.PropertyCallback_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(PropertyCallback));
    return hasDerivedMethod;
  }

  private void SwigDirectoronRead__SWIG_0(global::System.IntPtr datum) {
    onRead(new Property(datum, false));
  }

  private void SwigDirectoronRead__SWIG_1(global::System.IntPtr datum, global::System.IntPtr reader) {
    onRead(new Property(datum, false), new TypedReaderProperty(reader, false));
  }

  public delegate void SwigDelegatePropertyCallback_0(global::System.IntPtr datum);
  public delegate void SwigDelegatePropertyCallback_1(global::System.IntPtr datum, global::System.IntPtr reader);

  private SwigDelegatePropertyCallback_0 swigDelegate0;
  private SwigDelegatePropertyCallback_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(Property) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(Property), typeof(TypedReaderProperty) };
}
