/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IControlMode : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IControlMode(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IControlMode obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IControlMode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IControlMode(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool setPositionMode(int j) {
    bool ret = yarpPINVOKE.IControlMode_setPositionMode(swigCPtr, j);
    return ret;
  }

  public virtual bool setVelocityMode(int j) {
    bool ret = yarpPINVOKE.IControlMode_setVelocityMode(swigCPtr, j);
    return ret;
  }

  public virtual bool setTorqueMode(int j) {
    bool ret = yarpPINVOKE.IControlMode_setTorqueMode(swigCPtr, j);
    return ret;
  }

  public virtual bool setImpedancePositionMode(int j) {
    bool ret = yarpPINVOKE.IControlMode_setImpedancePositionMode(swigCPtr, j);
    return ret;
  }

  public virtual bool setImpedanceVelocityMode(int j) {
    bool ret = yarpPINVOKE.IControlMode_setImpedanceVelocityMode(swigCPtr, j);
    return ret;
  }

  public virtual bool setOpenLoopMode(int j) {
    bool ret = yarpPINVOKE.IControlMode_setOpenLoopMode(swigCPtr, j);
    return ret;
  }

  public virtual bool getControlMode(int j, SWIGTYPE_p_int mode) {
    bool ret = yarpPINVOKE.IControlMode_getControlMode__SWIG_0(swigCPtr, j, SWIGTYPE_p_int.getCPtr(mode));
    return ret;
  }

  public virtual bool getControlModes(SWIGTYPE_p_int modes) {
    bool ret = yarpPINVOKE.IControlMode_getControlModes__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(modes));
    return ret;
  }

  public int getControlMode(int j) {
    int ret = yarpPINVOKE.IControlMode_getControlMode__SWIG_1(swigCPtr, j);
    return ret;
  }

  public bool getControlModes(IVector data) {
    bool ret = yarpPINVOKE.IControlMode_getControlModes__SWIG_1(swigCPtr, IVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
