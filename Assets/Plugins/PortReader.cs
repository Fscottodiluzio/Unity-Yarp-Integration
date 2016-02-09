//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PortReader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PortReader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PortReader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PortReader() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PortReader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public new bool read(ConnectionReader reader) {
    bool ret = yarpPINVOKE.PortReader_read(swigCPtr, ConnectionReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Type getReadType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type((SwigDerivedClassHasMethod("getReadType", swigMethodTypes1) ? yarpPINVOKE.PortReader_getReadTypeSwigExplicitPortReader(swigCPtr) : yarpPINVOKE.PortReader_getReadType(swigCPtr)), true);
    return ret;
  }

  public PortReader() : this(yarpPINVOKE.new_PortReader(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("read", swigMethodTypes0))
      swigDelegate0 = new SwigDelegatePortReader_0(SwigDirectorread);
    if (SwigDerivedClassHasMethod("getReadType", swigMethodTypes1))
      swigDelegate1 = new SwigDelegatePortReader_1(SwigDirectorgetReadType);
    yarpPINVOKE.PortReader_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(PortReader));
    return hasDerivedMethod;
  }

  private bool SwigDirectorread(global::System.IntPtr reader) {
    return read(new ConnectionReader(reader, false));
  }

  private global::System.IntPtr SwigDirectorgetReadType() {
    return SWIGTYPE_p_Type.getCPtr(getReadType()).Handle;
  }

  public delegate bool SwigDelegatePortReader_0(global::System.IntPtr reader);
  public delegate global::System.IntPtr SwigDelegatePortReader_1();

  private SwigDelegatePortReader_0 swigDelegate0;
  private SwigDelegatePortReader_1 swigDelegate1;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ConnectionReader) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
}
