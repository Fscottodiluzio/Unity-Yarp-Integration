//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Stamp : Portable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Stamp(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.Stamp_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Stamp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Stamp() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Stamp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Stamp() : this(yarpPINVOKE.new_Stamp__SWIG_0(), true) {
  }

  public Stamp(int count, double time) : this(yarpPINVOKE.new_Stamp__SWIG_1(count, time), true) {
  }

  public int getCount() {
    int ret = yarpPINVOKE.Stamp_getCount(swigCPtr);
    return ret;
  }

  public double getTime() {
    double ret = yarpPINVOKE.Stamp_getTime(swigCPtr);
    return ret;
  }

  public bool isValid() {
    bool ret = yarpPINVOKE.Stamp_isValid(swigCPtr);
    return ret;
  }

  public int getMaxCount() {
    int ret = yarpPINVOKE.Stamp_getMaxCount(swigCPtr);
    return ret;
  }

  public void update() {
    yarpPINVOKE.Stamp_update__SWIG_0(swigCPtr);
  }

  public void update(double time) {
    yarpPINVOKE.Stamp_update__SWIG_1(swigCPtr, time);
  }

  public new bool read(ConnectionReader connection) {
    bool ret = yarpPINVOKE.Stamp_read(swigCPtr, ConnectionReader.getCPtr(connection));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool write(ConnectionWriter connection) {
    bool ret = yarpPINVOKE.Stamp_write(swigCPtr, ConnectionWriter.getCPtr(connection));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
