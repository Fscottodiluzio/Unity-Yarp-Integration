/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TypedReaderCallbackImageInt : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderCallbackImageInt(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TypedReaderCallbackImageInt obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderCallbackImageInt() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderCallbackImageInt(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new void onRead(ImageInt datum) {
    yarpPINVOKE.TypedReaderCallbackImageInt_onRead__SWIG_0(swigCPtr, ImageInt.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageInt datum, TypedReaderImageInt reader) {
    yarpPINVOKE.TypedReaderCallbackImageInt_onRead__SWIG_1(swigCPtr, ImageInt.getCPtr(datum), TypedReaderImageInt.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypedReaderCallbackImageInt() : this(yarpPINVOKE.new_TypedReaderCallbackImageInt(), true) {
  }

}
