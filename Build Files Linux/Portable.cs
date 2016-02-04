/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Portable : PortReader {
  private HandleRef swigCPtr;

  internal Portable(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.Portable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Portable obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Portable() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Portable(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new bool read(ConnectionReader connection) {
    bool ret = yarpPINVOKE.Portable_read(swigCPtr, ConnectionReader.getCPtr(connection));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new bool write(ConnectionWriter connection) {
    bool ret = yarpPINVOKE.Portable_write(swigCPtr, ConnectionWriter.getCPtr(connection));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Type getType() {
    SWIGTYPE_p_Type ret = new SWIGTYPE_p_Type(yarpPINVOKE.Portable_getType(swigCPtr), true);
    return ret;
  }

  public static bool copyPortable(PortWriter writer, PortReader reader) {
    bool ret = yarpPINVOKE.Portable_copyPortable(PortWriter.getCPtr(writer), PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
