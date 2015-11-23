//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TypedReaderProperty : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderProperty(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TypedReaderProperty obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderProperty() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderProperty(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.TypedReaderProperty_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.TypedReaderProperty_setStrict__SWIG_1(swigCPtr);
  }

  public new Property read(bool shouldWait) {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderProperty_read__SWIG_0(swigCPtr, shouldWait);
    Property ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public new Property read() {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderProperty_read__SWIG_1(swigCPtr);
    Property ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public virtual void interrupt() {
    yarpPINVOKE.TypedReaderProperty_interrupt(swigCPtr);
  }

  public new Property lastRead() {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderProperty_lastRead(swigCPtr);
    Property ret = (cPtr == global::System.IntPtr.Zero) ? null : new Property(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.TypedReaderProperty_isClosed(swigCPtr);
    return ret;
  }

  public new void useCallback(PropertyCallback callback) {
    yarpPINVOKE.TypedReaderProperty_useCallback(swigCPtr, PropertyCallback.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void disableCallback() {
    yarpPINVOKE.TypedReaderProperty_disableCallback(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.TypedReaderProperty_getPendingReads(swigCPtr);
    return ret;
  }

  public virtual string getName() {
    string ret = yarpPINVOKE.TypedReaderProperty_getName(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.TypedReaderProperty_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void acquire() {
    global::System.IntPtr cPtr = yarpPINVOKE.TypedReaderProperty_acquire(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void release(SWIGTYPE_p_void handle) {
    yarpPINVOKE.TypedReaderProperty_release(swigCPtr, SWIGTYPE_p_void.getCPtr(handle));
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.TypedReaderProperty_setTargetPeriod(swigCPtr, period);
  }

}
