//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PortWriterBufferBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PortWriterBufferBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PortWriterBufferBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PortWriterBufferBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PortWriterBufferBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual PortWriterWrapper create(PortWriterBufferManager man, SWIGTYPE_p_void tracker) {
    global::System.IntPtr cPtr = yarpPINVOKE.PortWriterBufferBase_create(swigCPtr, PortWriterBufferManager.getCPtr(man), SWIGTYPE_p_void.getCPtr(tracker));
    PortWriterWrapper ret = (cPtr == global::System.IntPtr.Zero) ? null : new PortWriterWrapper(cPtr, false);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void getContent() {
    global::System.IntPtr cPtr = yarpPINVOKE.PortWriterBufferBase_getContent(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public bool releaseContent() {
    bool ret = yarpPINVOKE.PortWriterBufferBase_releaseContent(swigCPtr);
    return ret;
  }

  public int getCount() {
    int ret = yarpPINVOKE.PortWriterBufferBase_getCount(swigCPtr);
    return ret;
  }

  public void attach(Port port) {
    yarpPINVOKE.PortWriterBufferBase_attach(swigCPtr, Port.getCPtr(port));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void detach() {
    yarpPINVOKE.PortWriterBufferBase_detach(swigCPtr);
  }

  public new void write(bool strict) {
    yarpPINVOKE.PortWriterBufferBase_write(swigCPtr, strict);
  }

  public void waitForWrite() {
    yarpPINVOKE.PortWriterBufferBase_waitForWrite(swigCPtr);
  }

}
