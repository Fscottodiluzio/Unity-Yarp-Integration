//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TypedReaderCallbackImageMono16 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderCallbackImageMono16(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TypedReaderCallbackImageMono16 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderCallbackImageMono16() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderCallbackImageMono16(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public new void onRead(ImageMono16 datum) {
    yarpPINVOKE.TypedReaderCallbackImageMono16_onRead__SWIG_0(swigCPtr, ImageMono16.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageMono16 datum, TypedReaderImageMono16 reader) {
    yarpPINVOKE.TypedReaderCallbackImageMono16_onRead__SWIG_1(swigCPtr, ImageMono16.getCPtr(datum), TypedReaderImageMono16.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypedReaderCallbackImageMono16() : this(yarpPINVOKE.new_TypedReaderCallbackImageMono16(), true) {
  }

}
