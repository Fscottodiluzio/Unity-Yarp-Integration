//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PortWriterWrapper : PortWriter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PortWriterWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.PortWriterWrapper_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PortWriterWrapper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PortWriterWrapper() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PortWriterWrapper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual PortWriter getInternal() {
    global::System.IntPtr cPtr = yarpPINVOKE.PortWriterWrapper_getInternal(swigCPtr);
    PortWriter ret = (cPtr == global::System.IntPtr.Zero) ? null : new PortWriter(cPtr, false);
    return ret;
  }

}
