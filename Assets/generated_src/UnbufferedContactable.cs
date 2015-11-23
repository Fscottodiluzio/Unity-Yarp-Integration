//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class UnbufferedContactable : Contactable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UnbufferedContactable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.UnbufferedContactable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UnbufferedContactable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnbufferedContactable() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_UnbufferedContactable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new bool write(PortWriter writer, PortWriter callback) {
    bool ret = yarpPINVOKE.UnbufferedContactable_write__SWIG_0(swigCPtr, PortWriter.getCPtr(writer), PortWriter.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool write(PortWriter writer) {
    bool ret = yarpPINVOKE.UnbufferedContactable_write__SWIG_1(swigCPtr, PortWriter.getCPtr(writer));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool write(PortWriter writer, PortReader reader, PortWriter callback) {
    bool ret = yarpPINVOKE.UnbufferedContactable_write__SWIG_2(swigCPtr, PortWriter.getCPtr(writer), PortReader.getCPtr(reader), PortWriter.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool write(PortWriter writer, PortReader reader) {
    bool ret = yarpPINVOKE.UnbufferedContactable_write__SWIG_3(swigCPtr, PortWriter.getCPtr(writer), PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool read(PortReader reader, bool willReply) {
    bool ret = yarpPINVOKE.UnbufferedContactable_read__SWIG_0(swigCPtr, PortReader.getCPtr(reader), willReply);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool read(PortReader reader) {
    bool ret = yarpPINVOKE.UnbufferedContactable_read__SWIG_1(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool reply(PortWriter writer) {
    bool ret = yarpPINVOKE.UnbufferedContactable_reply(swigCPtr, PortWriter.getCPtr(writer));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool replyAndDrop(PortWriter writer) {
    bool ret = yarpPINVOKE.UnbufferedContactable_replyAndDrop(swigCPtr, PortWriter.getCPtr(writer));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
