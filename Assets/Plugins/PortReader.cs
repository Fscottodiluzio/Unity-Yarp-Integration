/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PortReader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PortReader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PortReader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PortReader() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PortReader(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new bool read(ConnectionReader connection) {
    bool ret = yarpPINVOKE.PortReader_read(swigCPtr, ConnectionReader.getCPtr(connection));
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

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(PortReader));
    return hasDerivedMethod;
  }

  private bool SwigDirectorread(IntPtr connection) {
    return read(new ConnectionReader(connection, false));
  }

  private IntPtr SwigDirectorgetReadType() {
    return SWIGTYPE_p_Type.getCPtr(getReadType()).Handle;
  }

  public delegate bool SwigDelegatePortReader_0(IntPtr connection);
  public delegate IntPtr SwigDelegatePortReader_1();

  private SwigDelegatePortReader_0 swigDelegate0;
  private SwigDelegatePortReader_1 swigDelegate1;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(ConnectionReader) };
  private static Type[] swigMethodTypes1 = new Type[] {  };
}
