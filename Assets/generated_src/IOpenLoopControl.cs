//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IOpenLoopControl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IOpenLoopControl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IOpenLoopControl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IOpenLoopControl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IOpenLoopControl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool setRefOutput(int j, double v) {
    bool ret = yarpPINVOKE.IOpenLoopControl_setRefOutput(swigCPtr, j, v);
    return ret;
  }

  public virtual bool setRefOutputs(SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IOpenLoopControl_setRefOutputs(swigCPtr, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool getRefOutput(int j, SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IOpenLoopControl_getRefOutput(swigCPtr, j, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool getRefOutputs(SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IOpenLoopControl_getRefOutputs(swigCPtr, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool getOutput(int j, SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IOpenLoopControl_getOutput(swigCPtr, j, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool getOutputs(SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IOpenLoopControl_getOutputs(swigCPtr, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool setOpenLoopMode() {
    bool ret = yarpPINVOKE.IOpenLoopControl_setOpenLoopMode(swigCPtr);
    return ret;
  }

}
