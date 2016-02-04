//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PortWriter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PortWriter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PortWriter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PortWriter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PortWriter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public new bool write(ConnectionWriter connection) {
    bool ret = yarpPINVOKE.PortWriter_write(swigCPtr, ConnectionWriter.getCPtr(connection));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void onCompletion() {
    yarpPINVOKE.PortWriter_onCompletion(swigCPtr);
  }

  public virtual void onCommencement() {
    yarpPINVOKE.PortWriter_onCommencement(swigCPtr);
  }

  public virtual SWIGTYPE_p_Type getWriteType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type(yarpPINVOKE.PortWriter_getWriteType(swigCPtr), true);
    return ret;
  }

}
